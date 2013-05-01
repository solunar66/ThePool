using System;
using System.Collections;
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

        DateTime toMonth;

        List<Calendar> monthInfo = new List<Calendar>();

        DataSet dsType = new DataSet();

        /// <summary>
        /// show current month
        /// </summary>
        /// <param name="toMonth"></param>
        public Form_Calendar(DateTime today)
        {
            InitializeComponent();

            dsType.Tables.Add();
            dsType.Tables[0].Columns.Add("type", typeof(string));
            dsType.Tables[0].Columns.Add("value", typeof(int));
            dsType.Tables[0].Rows.Add("收入", 0);
            dsType.Tables[0].Rows.Add("支出", 1);

            toMonth = today;

            Controls.Add(dateControl);
            dateControl.BorderStyle = BorderStyle.FixedSingle;
            dateControl.Dock = DockStyle.Top;
            dateControl.DrawLine = false;
            dateControl.ShowJieriInfo = false;
            // to unify the special day display
            dateControl.SpecialForeColor = Color.Black;
            dateControl.FontChinaDay = new Font("宋体", 7);
            dateControl.MarkDayColor = Color.LightBlue;
            dateControl.BackColor = Color.White;
            dateControl.Date = today;
            dateControl.MouseDown += new MouseEventHandler(dateControl_MouseDown);
            dateControl.PaintDate += new ChinaDateControl.OnPaintDate(dateControl_PaintDate);

            Text = "                                      "
                 + "------ " + today.Year.ToString() + "年" + today.Month.ToString() + "月" + " ------";
        }

        private void dateControl_MouseDown(object sender, MouseEventArgs e)
        {
            groupBox_info.Text = dateControl.CurrentDateTime.ToShortDateString();
            dataGridView_info.Rows.Clear();

            // find and display the info of the day
            foreach (Calendar calendar in monthInfo)
            {
                if (calendar.date == dateControl.CurrentDateTime)
                {
                    dataGridView_info.Rows.Add();
                    (dataGridView_info.Rows[dataGridView_info.Rows.Count - 2].Cells[0] as DataGridViewComboBoxCell).DataSource = dsType.Tables[0];
                    (dataGridView_info.Rows[dataGridView_info.Rows.Count - 2].Cells[0] as DataGridViewComboBoxCell).DisplayMember = "type";
                    (dataGridView_info.Rows[dataGridView_info.Rows.Count - 2].Cells[0] as DataGridViewComboBoxCell).ValueMember = "value";
                    (dataGridView_info.Rows[dataGridView_info.Rows.Count - 2].Cells[0] as DataGridViewComboBoxCell).Value = (int)(((Flow)calendar.flows[0]).type);
                    dataGridView_info.Rows[dataGridView_info.Rows.Count - 2].Cells[1].Value = ((Flow)calendar.flows[0]).volume;
                    dataGridView_info.Rows[dataGridView_info.Rows.Count - 2].Cells[2].Value = ((Flow)calendar.flows[0]).comment;
                    dataGridView_info.Rows[dataGridView_info.Rows.Count - 2].ReadOnly = true;
                }
            }
            foreach (Calendar calendar in Form_Main.ar_Calendars)
            {
                if (calendar.date == dateControl.CurrentDateTime)
                {
                    foreach (Flow flow in calendar.flows)
                    {
                        dataGridView_info.Rows.Add();
                        (dataGridView_info.Rows[dataGridView_info.Rows.Count - 2].Cells[0] as DataGridViewComboBoxCell).DataSource = dsType.Tables[0];
                        (dataGridView_info.Rows[dataGridView_info.Rows.Count - 2].Cells[0] as DataGridViewComboBoxCell).DisplayMember = "type";
                        (dataGridView_info.Rows[dataGridView_info.Rows.Count - 2].Cells[0] as DataGridViewComboBoxCell).ValueMember = "value";
                        (dataGridView_info.Rows[dataGridView_info.Rows.Count - 2].Cells[0] as DataGridViewComboBoxCell).Value = (int)flow.type;
                        dataGridView_info.Rows[dataGridView_info.Rows.Count - 2].Cells[1].Value = flow.volume;
                        dataGridView_info.Rows[dataGridView_info.Rows.Count - 2].Cells[2].Value = flow.comment;
                    }
                    break;
                }
            }
        }

        private void dateControl_PaintDate(CDate.myArgs e1)
        {
            //foreach (Label l in flowLayoutPanel_in.Controls)
            //{
            //    try
            //    {
            //        int day = int.Parse(l.Text);
            //        if (e1.Date.Day == day) e1.IsSpecial = true;
            //    }
            //    catch { }
            //}
            //foreach (Label l in flowLayoutPanel_out.Controls)
            //{
            //    try
            //    {
            //        int day = int.Parse(l.Text);
            //        if (e1.Date.Day == day) e1.IsSpecial = true;
            //    }
            //    catch { }
            //}
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
            DateTime start = new DateTime(toMonth.Year,toMonth.Month,1);
            DateTime end = start.AddDays(1 - start.Day).AddMonths(1).AddDays(-1);
            int intervel;

            // loop partners' paybacks
            // loop projects' paybacks
            // loop debts' outputs
            // loop calendar's comments
            // the generated rows are readonly

            foreach (Partner partner in Form_Main.ar_Partners)
            {
                foreach (Fund fund in partner.funds)
                {
                    if (fund.start < start && fund.end >= start)
                    {
                        switch (fund.cycle)
                        {
                            case Cycle.monthly: intervel = 1; break;
                            case Cycle.seasonly: intervel = 3; break;
                            case Cycle.halfyearly: intervel = 6; break;
                            case Cycle.yearly: intervel = 12; break;
                            case Cycle.undefined:
                            default: intervel = 0; break;
                        }
                        if (intervel == 0) continue;
                        else
                        {
                            if (((toMonth.Year - fund.start.Year) * 12 + toMonth.Month - fund.start.Month) % intervel == 0)
                            {
                                Calendar c = new Calendar();
                                c.date = new DateTime(toMonth.Year, toMonth.Month, fund.start.Day);
                                c.flows = new ArrayList();
                                Flow flow = new Flow();
                                flow.type = FlowType.payout;
                                flow.volume = fund.volume * fund.rate * 12 / intervel;
                                flow.comment = "股东\"" + partner.name + "\"资金(" + fund.volume + "万)结息";
                                c.flows.Add(flow);
                                monthInfo.Add(c);
                            }
                        }
                    }
                }
            }

            foreach (Project project in Form_Main.ar_Projects)
            {
                if (project.start < start && project.end >= start)
                {
                    switch (project.cycle)
                    {
                        case Cycle.monthly: intervel = 1; break;
                        case Cycle.seasonly: intervel = 3; break;
                        case Cycle.halfyearly: intervel = 6; break;
                        case Cycle.yearly: intervel = 12; break;
                        case Cycle.undefined:
                        default: intervel = 0; break;
                    }
                    if (intervel == 0) continue;
                    else
                    {
                        if (((toMonth.Year - project.start.Year) * 12 + toMonth.Month - project.start.Month) % intervel == 0)
                        {
                            Calendar c = new Calendar();
                            c.date = new DateTime(toMonth.Year, toMonth.Month, project.start.Day);
                            c.flows = new ArrayList();
                            Flow flow = new Flow();
                            flow.type = FlowType.income;
                            flow.volume = project.volume * project.rate * 12 / intervel;
                            flow.comment = "投资\"" + project.name + "\"资金(" + project.volume + "万)结息";
                            c.flows.Add(flow);
                            monthInfo.Add(c);
                        }
                    }
                }
            }

            foreach (Debt debt in Form_Main.ar_Debts)
            {
                if (debt.start < start && debt.end >= start)
                {
                    switch (debt.cycle)
                    {
                        case Cycle.monthly: intervel = 1; break;
                        case Cycle.seasonly: intervel = 3; break;
                        case Cycle.halfyearly: intervel = 6; break;
                        case Cycle.yearly: intervel = 12; break;
                        case Cycle.undefined:
                        default: intervel = 0; break;
                    }
                    if (intervel == 0) continue;
                    else
                    {
                        if (((toMonth.Year - debt.start.Year) * 12 + toMonth.Month - debt.start.Month) % intervel == 0)
                        {
                            Calendar c = new Calendar();
                            c.date = new DateTime(toMonth.Year, toMonth.Month, debt.start.Day);
                            c.flows = new ArrayList();
                            Flow flow = new Flow();
                            flow.type = FlowType.payout;
                            flow.volume = debt.volume;
                            flow.comment = "负债\"" + debt.name + "\"资金(" + debt.volume + "万)支出";
                            c.flows.Add(flow);
                            monthInfo.Add(c);
                        }
                    }
                }
            }

            foreach (Calendar calendar in monthInfo)
            {
                Label label = new Label();
                label.AutoSize = true;
                label.Text = calendar.date.Day.ToString();
                if (((Flow)calendar.flows[0]).type == FlowType.income)
                {
                    foreach (Label l in flowLayoutPanel_in.Controls)
                    {
                        if (l.Text == label.Text) return;
                    }
                    flowLayoutPanel_in.Controls.Add(label);
                    
                }
                else if (((Flow)calendar.flows[0]).type == FlowType.payout)
                {
                    foreach (Label l in flowLayoutPanel_out.Controls)
                    {
                        if (l.Text == label.Text) return;
                    }
                    flowLayoutPanel_out.Controls.Add(label);
                }
                else { }
            }

            foreach (Calendar calendar in Form_Main.ar_Calendars)
            {
                if (calendar.date >= start && calendar.date <= end)
                {
                    foreach (Flow flow in calendar.flows)
                    {
                        Label l = new Label();
                        l.ForeColor = Color.Blue;
                        l.AutoSize = true;
                        l.Text = calendar.date.Day.ToString();
                        if (flow.type == FlowType.income)
                        {
                            foreach (Label l_in in flowLayoutPanel_in.Controls)
                            {
                                if (l_in.Text == l.Text) return;
                            }
                            flowLayoutPanel_in.Controls.Add(l);
                        }
                        else if (flow.type == FlowType.payout)
                        {
                            foreach (Label l_out in flowLayoutPanel_out.Controls)
                            {
                                if (l_out.Text == l.Text) return;
                            }
                            flowLayoutPanel_out.Controls.Add(l);
                        }
                        else { }
                    }
                }
            }
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            Calendar calendar = new Calendar();
            calendar.date = dateControl.CurrentDateTime;
            calendar.flows = new ArrayList();
            foreach (DataGridViewRow row in dataGridView_info.Rows)
            {
                if (!row.ReadOnly && !row.IsNewRow && row.Cells[0].Value != null && row.Cells[1].Value != null)
                {
                    float volume;
                    if (!float.TryParse(row.Cells[1].Value.ToString(), out volume))
                    {
                        MessageBox.Show("输入数据异常!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        Flow flow = new Flow();
                        flow.type = row.Cells[0].Value.ToString() == "0" ? FlowType.income : FlowType.payout;
                        flow.volume = volume;
                        flow.comment = row.Cells[2].Value == null ? "" : row.Cells[2].Value.ToString();
                        calendar.flows.Add(flow);
                    }
                }
            }
            foreach (Calendar c in Form_Main.ar_Calendars)
            {
                if (c.date == calendar.date)
                {
                    Form_Main.ar_Calendars.Remove(c);
                    break;
                }
            }
            Form_Main.ar_Calendars.Add(calendar);
            try
            {
                Xml.UpdateCalendar(Form_Main.file_Calendars, Form_Main.ar_Calendars);
                MessageBox.Show(groupBox_info.Text + " 数据保存成功!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(groupBox_info.Text + " 数据保存失败!\n\n" + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
