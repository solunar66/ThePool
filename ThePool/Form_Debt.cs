using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ThePool
{
    public partial class Form_Debt : Form
    {
        public Form_Debt()
        {
            InitializeComponent();
        }

        private void Clear()
        {
            groupbox_info.Text = "负债信息";
            groupbox_info.ForeColor = Color.FromKnownColor(KnownColor.ControlText);
            textBox_name.Text = "";
            textBox_comment.Text = "";
            numericUpDown_volume.Value = 0;
            comboBox_cycle.SelectedIndex = 0;
            dateTimePicker_start.Value = DateTime.Now;
            dateTimePicker_end.Value = DateTime.Now;
        }

        private void Form_Debt_Load(object sender, EventArgs e)
        {
            listBox_name.Items.Clear();
            Clear();

            foreach (Debt debt in Form_Main.ar_Debts)
            {
                listBox_name.Items.Add(debt.name);
            }
        }

        private void button_load_Click(object sender, EventArgs e)
        {
            Clear();
            foreach (Debt debt in Form_Main.ar_Debts)
            {
                if (debt.name == listBox_name.SelectedItem.ToString())
                {
                    textBox_name.Text = debt.name;
                    textBox_comment.Text = debt.comment;
                    numericUpDown_volume.Value = (decimal)debt.volume;
                    comboBox_cycle.SelectedIndex = (int)debt.cycle;
                    dateTimePicker_start.Value = debt.start;
                    dateTimePicker_end.Value = debt.end;
                }
            }
        }

        private void button_new_Click(object sender, EventArgs e)
        {
            Clear();

            groupbox_info.Text = "请输入新负债信息";
            groupbox_info.ForeColor = Color.Red;
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (textBox_name.Text == "")
            {
                MessageBox.Show("请选择要删除的负债并读取负债信息!", "删除负债", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (DialogResult.Yes == MessageBox.Show("请确认删除负债信息: \"" + textBox_name.Text + "\"\n\n(删除负债将影响以往的负债记录, 建议保留负债信息, 并更新该负债周期截止时间)", "删除负债", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                foreach (Debt debt in Form_Main.ar_Debts)
                {
                    if (debt.name == textBox_name.Text)
                    {
                        Form_Main.ar_Debts.Remove(debt);
                        try
                        {
                            Xml.UpdateDebt(Form_Main.file_Debts, Form_Main.ar_Debts);
                            MessageBox.Show("负债信息删除成功!", "删除负债", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Form_Debt_Load(this, null);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("负债信息删除失败!\n\n(" + ex.Message + ")", "删除负债", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        return;
                    }
                }
                MessageBox.Show("负债信息未找到!\n\n(" + textBox_name.Text + ")", "删除负债", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if (textBox_name.Text == "" || numericUpDown_volume.Value == 0)
            {
                MessageBox.Show("请输入完整负债信息!", "保存负债", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_name.Focus();
                return;
            }

            Debt debt = new Debt();
            debt.name = textBox_name.Text;
            debt.comment = textBox_comment.Text;
            debt.volume = (double)numericUpDown_volume.Value;
            debt.cycle = (Cycle)Enum.ToObject(typeof(Cycle), byte.Parse(comboBox_cycle.SelectedIndex.ToString()));
            debt.start = dateTimePicker_start.Value;
            debt.end = dateTimePicker_end.Value;
            foreach (Debt d in Form_Main.ar_Debts)
            {
                if (d.name == textBox_name.Text)
                {
                    if (DialogResult.Yes == MessageBox.Show("请确认更新负债信息: \"" + debt.name + "\"", "更新负债", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        Form_Main.ar_Debts.Insert(Form_Main.ar_Debts.IndexOf(d), debt);
                        Form_Main.ar_Debts.Remove(d);
                        try
                        {
                            Xml.UpdateDebt(Form_Main.file_Debts, Form_Main.ar_Debts);
                            MessageBox.Show("负债信息更新成功!", "更新负债", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("负债信息更新失败!\n\n(" + ex.Message + ")", "更新负债", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    return;
                }
            }
            if (DialogResult.Yes == MessageBox.Show("请确认添加负债: \"" + debt.name + "\"", "新建负债", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                Form_Main.ar_Debts.Add(debt);
                try
                {
                    Xml.UpdateDebt(Form_Main.file_Debts, Form_Main.ar_Debts);
                    MessageBox.Show("负债信息添加成功!", "新建负债", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form_Debt_Load(this, null);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("负债信息添加失败!\n\n(" + ex.Message + ")", "新建负债", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
