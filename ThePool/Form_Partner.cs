using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ThePool
{
    public partial class Form_Partner : Form
    {
        DataSet dsCycle = new DataSet();

        public Form_Partner()
        {
            InitializeComponent();

            dsCycle.Tables.Add();
            dsCycle.Tables[0].Columns.Add("name", typeof(string));
            dsCycle.Tables[0].Columns.Add("value", typeof(int));
            dsCycle.Tables[0].Rows.Add("未定义", 0);
            dsCycle.Tables[0].Rows.Add("每月", 1);
            dsCycle.Tables[0].Rows.Add("每季度", 2);
            dsCycle.Tables[0].Rows.Add("每半年", 3);
            dsCycle.Tables[0].Rows.Add("每年", 4);


            CalendarColumn start = new CalendarColumn();
            start.HeaderText="起始时间";
            start.Width = 85;
            CalendarColumn end = new CalendarColumn();
            end.HeaderText = "起始时间";
            end.Width = 85;
            dataGridView_volume.Columns.Insert(3, start);
            dataGridView_volume.Columns.Insert(4, end);

            groupbox_info.Text = "股东信息";
            groupbox_info.ForeColor = Color.FromKnownColor(KnownColor.ControlText);
        }

        private void Clear()
        {
            textBox_name.Text = "";
            textBox_phone.Text = "";
            textBox_comment.Text = "";
            dataGridView_volume.Rows.Clear();
        }

        private void Form_Partner_Load(object sender, EventArgs e)
        {
            listBox_name.Items.Clear();
            Clear();
            foreach (Partner partner in Form_Main.ar_Partners)
            {
                listBox_name.Items.Add(partner.name);
            }
        }

        private void button_load_Click(object sender, EventArgs e)
        {
            if (listBox_name.SelectedItem == null)
            {
                MessageBox.Show("请在左侧列表中选择要显示的股东姓名", "请选择股东", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Clear();
            foreach (Partner partner in Form_Main.ar_Partners)
            {
                if (partner.name == listBox_name.SelectedItem.ToString())
                {
                    textBox_name.Text = partner.name;
                    textBox_phone.Text = partner.telephone;
                    textBox_comment.Text = partner.comment;
                    dataGridView_volume.Rows.Clear();
                    foreach (Fund fund in partner.funds)
                    {
                        dataGridView_volume.Rows.Add();
                        int index = dataGridView_volume.Rows.Count - 2;
                        dataGridView_volume.Rows[index].Cells[0].Value = fund.volume.ToString();
                        dataGridView_volume.Rows[index].Cells[1].Value = fund.rate.ToString();
                        (dataGridView_volume.Rows[index].Cells[2] as DataGridViewComboBoxCell).DataSource = dsCycle.Tables[0];
                        (dataGridView_volume.Rows[index].Cells[2] as DataGridViewComboBoxCell).DisplayMember = "name";
                        (dataGridView_volume.Rows[index].Cells[2] as DataGridViewComboBoxCell).ValueMember = "value";
                        (dataGridView_volume.Rows[index].Cells[2] as DataGridViewComboBoxCell).Value = (int)fund.cycle;
                        dataGridView_volume.Rows[index].Cells[3].Value = fund.start;
                        dataGridView_volume.Rows[index].Cells[4].Value = fund.end;
                    }
                    return;
                }
            }
            
            MessageBox.Show("股东信息读取失败！请重新打开本窗口以刷新股东信息", "读取失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button_inject_Click(object sender, EventArgs e)
        {

        }

        private void button_eject_Click(object sender, EventArgs e)
        {

        }

        private void button_new_Click(object sender, EventArgs e)
        {
            textBox_name.Text = "";
            textBox_phone.Text = "";
            textBox_comment.Text = "";
            dataGridView_volume.Rows.Clear();
            groupbox_info.Text = "请输入新股东信息";
            groupbox_info.ForeColor = Color.Red;
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (textBox_name.Text == "")
            {
                MessageBox.Show("请选择要删除的股东并读取股东信息!", "删除股东", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (DialogResult.Yes == MessageBox.Show("请确认删除股东信息: \"" + textBox_name.Text + "\"\n\n(删除股东将影响其以往的投资记录, 建议保留股东信息, 并更新该股东投资周期截止时间)", "删除股东", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                foreach (Partner partner in Form_Main.ar_Partners)
                {
                    if (partner.name == textBox_name.Text)
                    {
                        Form_Main.ar_Partners.Remove(partner);
                        try
                        {
                            Xml.UpdatePartner(Form_Main.file_Partners, Form_Main.ar_Partners);
                            MessageBox.Show("股东信息删除成功!", "删除股东", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Form_Partner_Load(this, null);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("股东信息删除失败!\n\n(" + ex.Message + ")", "删除股东", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        return;
                    }
                }
                MessageBox.Show("股东信息未找到!\n\n(" + textBox_name.Text + ")", "删除股东", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if (textBox_name.Text == "")
            {
                MessageBox.Show("请输入股东姓名!", "更新股东", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_name.Focus();
                return;
            }

            Partner partner = new Partner();
            partner.name = textBox_name.Text;
            partner.telephone = textBox_phone.Text;
            partner.comment = textBox_comment.Text;
            partner.funds = new ArrayList();
            foreach (DataGridViewRow row in dataGridView_volume.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[1] != null && row.Cells[2].Value != null)
                {
                    Fund fund = new Fund();
                    fund.volume = double.Parse(row.Cells[0].Value.ToString());
                    fund.rate = double.Parse(row.Cells[1].Value.ToString());
                    if (row.Cells[2].Value.ToString() == "0")
                    { fund.cycle = Cycle.undefined; }
                    else if(row.Cells[2].Value.ToString() == "1")
                    { fund.cycle = Cycle.monthly; }
                    else if(row.Cells[2].Value.ToString() == "2")
                    { fund.cycle = Cycle.seasonly; }
                    else if (row.Cells[2].Value.ToString() == "3")
                    { fund.cycle = Cycle.halfyearly; }
                    else if (row.Cells[2].Value.ToString() == "4")
                    { fund.cycle = Cycle.yearly; }
                    else
                    { fund.cycle = Cycle.undefined; }
                    fund.start = (DateTime)row.Cells[3].Value;
                    fund.end = (DateTime)row.Cells[4].Value;
                    fund.comment = row.Cells[5].Value == null ? "" : row.Cells[5].Value.ToString();
                    partner.funds.Add(fund);
                }
            }
            foreach(Partner par in Form_Main.ar_Partners)
            {
                if (par.name == partner.name)
                {
                    if (DialogResult.Yes == MessageBox.Show("请确认更新股东信息: \"" + par.name + "\"", "更新股东信息", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        Form_Main.ar_Partners.Insert(Form_Main.ar_Partners.IndexOf(par), partner);
                        Form_Main.ar_Partners.Remove(par);
                        try
                        {
                            Xml.UpdatePartner(Form_Main.file_Partners, Form_Main.ar_Partners);
                            MessageBox.Show("股东信息更新成功!", "更新股东信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("股东信息更新失败!\n\n(" + ex.Message + ")", "更新股东信息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    return;
                }                
            }
            if (DialogResult.Yes == MessageBox.Show("请确认添加股东: \"" + partner.name + "\"", "新添加股东", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                Form_Main.ar_Partners.Add(partner);
                try
                {
                    Xml.UpdatePartner(Form_Main.file_Partners, Form_Main.ar_Partners);
                    MessageBox.Show("股东信息添加成功!", "新建股东", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form_Partner_Load(this, null);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("股东信息添加失败!\n\n(" + ex.Message + ")", "新建股东", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button_quit_Click(object sender, EventArgs e)
        {

        }
    }
}
