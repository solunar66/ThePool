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
            dateControl.BorderStyle = BorderStyle.FixedSingle;
            dateControl.Dock = DockStyle.Top;
            dateControl.DrawLine = false;
            dateControl.ShowJieriInfo = false;
            dateControl.FontChinaDay = new Font("宋体", 7);
            dateControl.MarkDayColor = Color.LightBlue;
            dateControl.BackColor = Color.White;
            dateControl.Date = today;
            dateControl.MouseDown += new MouseEventHandler(dateControl_MouseDown);

            Text = "                                            "
                 + "------ " + today.Year.ToString() + "年" + today.Month.ToString() + "月" + " ------";
        }

        private void dateControl_MouseDown(object sender, MouseEventArgs e)
        {
            groupBox_info.Text = dateControl.CurrentDateTime.ToShortDateString();

            // find and display the info of the day
        }

        private void ToolStripMenuItem_delete_Click(object sender, EventArgs e)
        {
            if (dataGridView_info.SelectedRows[0].ReadOnly || dataGridView_info.SelectedRows[0].IsNewRow) return;
            dataGridView_info.Rows.Remove(dataGridView_info.SelectedRows[0]);
        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                dataGridView_info.Rows[e.RowIndex].Selected = true;
            }
        }

        private void Form_Calendar_Load(object sender, EventArgs e)
        {
            // loop partners' paybacks
            // loop projects' paybacks
            // loop debts' outputs
            // loop calendar's comments
            // the generated rows are readonly
            
            
        }

        private void button_save_Click(object sender, EventArgs e)
        {

        }
    }
}
