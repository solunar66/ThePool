using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CDate;

namespace ThePool
{
    public partial class Form_Calendar : Form
    {
        ChinaDateControl dateControl = new ChinaDateControl();

        /// <summary>
        /// show current month
        /// </summary>
        /// <param name="toMonth"></param>
        public Form_Calendar(DateTime today)
        {
            InitializeComponent();

            Controls.Add(dateControl);
            dateControl.Dock = DockStyle.Top;
            dateControl.DrawLine = false;
            dateControl.ShowJieriInfo = false;
            dateControl.FontChinaDay = new Font("宋体", 7);
            dateControl.MarkDayColor = Color.LightBlue;
            dateControl.Date = today;
            dateControl.MouseDown += new MouseEventHandler(dateControl_MouseDown);

            Text = "                                            "
                 + "------ " + today.Year.ToString() + "年" + today.Month.ToString() + "月" + " ------";
        }

        private void dateControl_MouseDown(object sender, MouseEventArgs e)
        {
            groupBox_info.Text = dateControl.CurrentDateTime.ToShortDateString();
        }

        private void ToolStripMenuItem_delete_Click(object sender, EventArgs e)
        {
            dataGridView_info.Rows.Remove(dataGridView_info.SelectedRows[0]);
        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                dataGridView_info.Rows[e.RowIndex].Selected = true;
            }
        }
    }
}
