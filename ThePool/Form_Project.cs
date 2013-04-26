using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ThePool
{
    public partial class Form_Project : Form
    {
        public Form_Project()
        {
            InitializeComponent();
        }

        private void Clear()
        {
            groupbox_info.Text = "项目信息";
            groupbox_info.ForeColor = Color.FromKnownColor(KnownColor.ControlText);
            textBox_name.Text = "";
            textBox_contact.Text = "";
            textBox_phone.Text = "";
            textBox_comment.Text = "";
            numericUpDown_volume.Value = 0;
            numericUpDown_rate.Value = 0;
            comboBox_cycle.SelectedIndex = 0;
            dateTimePicker_start.Value = DateTime.Now;
            dateTimePicker_end.Value = DateTime.Now;
        }

        private void Form_Project_Load(object sender, EventArgs e)
        {
            listBox_name.Items.Clear();
            Clear();

            foreach (Project project in Form_Main.ar_Projects)
            {
                listBox_name.Items.Add(project.name);
            }
        }

        private void button_load_Click(object sender, EventArgs e)
        {
            Clear();
            foreach (Project project in Form_Main.ar_Projects)
            {
                if (project.name == listBox_name.SelectedItem.ToString())
                {
                    textBox_name.Text = project.name;
                    textBox_contact.Text = project.contact;
                    textBox_phone.Text = project.telephone;
                    textBox_comment.Text = project.comment;
                    numericUpDown_volume.Value = project.volume;
                    numericUpDown_rate.Value = (decimal)project.rate;
                    comboBox_cycle.SelectedIndex = (int)project.cycle;
                    dateTimePicker_start.Value = project.start;
                    dateTimePicker_end.Value = project.end;
                }
            }
        }

        private void button_new_Click(object sender, EventArgs e)
        {
            Clear();

            groupbox_info.Text = "请输入新项目信息";
            groupbox_info.ForeColor = Color.Red;
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (textBox_name.Text == "")
            {
                MessageBox.Show("请选择要删除的项目并读取项目信息!", "删除项目", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (DialogResult.Yes == MessageBox.Show("请确认删除项目信息: \"" + textBox_name.Text + "\"\n\n(删除项目将影响以往的投资记录, 建议保留项目信息, 并更新该项目周期截止时间)", "删除项目", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                foreach (Project project in Form_Main.ar_Projects)
                {
                    if (project.name == textBox_name.Text)
                    {
                        Form_Main.ar_Projects.Remove(project);
                        try
                        {
                            Xml.UpdateProject(Form_Main.file_Projects, Form_Main.ar_Projects);
                            MessageBox.Show("项目信息删除成功!", "删除项目", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Form_Project_Load(this, null);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("项目信息删除失败!\n\n(" + ex.Message + ")", "删除项目", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        return;
                    }
                }
                MessageBox.Show("项目信息未找到!\n\n(" + textBox_name.Text + ")", "删除项目", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            Project proj = new Project();
            proj.name = textBox_name.Text;
            proj.contact = textBox_contact.Text;
            proj.telephone = textBox_phone.Text;
            proj.comment = textBox_comment.Text;
            proj.volume = (int)numericUpDown_volume.Value;
            proj.rate = (float)numericUpDown_rate.Value;
            proj.cycle = (Cycle)Enum.ToObject(typeof(Cycle), byte.Parse(comboBox_cycle.SelectedIndex.ToString()));
            proj.start = dateTimePicker_start.Value;
            proj.end = dateTimePicker_end.Value;
            foreach (Project project in Form_Main.ar_Projects)
            {
                if (project.name == textBox_name.Text)
                {
                    if (DialogResult.Yes == MessageBox.Show("请确认更新项目信息: \"" + project.name + "\"", "更新项目", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        Form_Main.ar_Projects.Insert(Form_Main.ar_Projects.IndexOf(project), proj);
                        Form_Main.ar_Projects.Remove(project);
                        try
                        {
                            Xml.UpdateProject(Form_Main.file_Projects, Form_Main.ar_Projects);
                            MessageBox.Show("项目信息更新成功!", "更新项目", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("项目信息更新失败!\n\n(" + ex.Message + ")", "更新项目", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    return;
                }
            }
            if (DialogResult.Yes == MessageBox.Show("请确认添加项目: \"" + proj.name + "\"", "新建项目", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                Form_Main.ar_Projects.Add(proj);
                try
                {
                    Xml.UpdateProject(Form_Main.file_Projects, Form_Main.ar_Projects);
                    MessageBox.Show("项目信息添加成功!", "新建项目", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form_Project_Load(this, null);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("项目信息添加失败!\n\n(" + ex.Message + ")", "新建项目", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
