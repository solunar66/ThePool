using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ZedGraph;

namespace ThePool
{
    public partial class Form_Main : Form
    {
        ZedGraphControl zedGraph;
        GraphPane myPane;

        int ipt;
        object nearestObj;
        GraphPane tmpPane;

        public static ArrayList ar_Partners, ar_Projects, ar_Debts, ar_Calendars;
        public static string file_Partners  = @"data/XML_Partner.xml";
        public static string file_Projects  = @"data/XML_Project.xml";
        public static string file_Debts     = @"data/XML_Debt.xml";
        public static string file_Calendars = @"data/XML_Calendar.xml";
        
        public Form_Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            zedGraph = new ZedGraphControl();
            panel1.Controls.Add(zedGraph);
            zedGraph.Dock= DockStyle.Fill;
            zedGraph.PanModifierKeys = Keys.None;
            zedGraph.MouseMove += new MouseEventHandler(zedGraph_MouseMove);
            zedGraph.MouseClick+= new MouseEventHandler(zedGraph_MouseClick);

            myPane = zedGraph.GraphPane;

            // Set the title and axis labels
            myPane.Title.Text = "资金池(万)";
            myPane.XAxis.Title.Text = "日期 (点击柱状图显示详细信息)";
            myPane.YAxis.Title.Text = "总量";
            
            myPane.XAxis.Scale.MajorStep = 1;
            myPane.XAxis.Type = AxisType.Text;

            // Set BarBase to the YAxis for horizontal bars
            myPane.BarSettings.Base = BarBase.X;
            // Make the bars stack instead of cluster
            myPane.BarSettings.Type = BarType.Stack;

            // Fill the axis background with a color gradient
            myPane.Chart.Fill = new Fill(Color.White, Color.FromArgb(255, 255, 166), 45.0F);

            Reload();
        }

        public void Reload()
        {
            myPane.CurveList.Clear();

            ar_Partners  = Xml.LoadPartner(file_Partners);
            ar_Projects  = Xml.LoadProject(file_Projects);
            ar_Debts     = Xml.LoadDebt(file_Debts);
            ar_Calendars = Xml.LoadCalendar(file_Calendars);

            PointPairList invests = new PointPairList();
            PointPairList cash    = new PointPairList();
            List<string> Xlabelslist = new List<string>();

            //
            // To Do: the calculation
            //
            // for each month date
            DateTime start, end;
            // for interest payment calculation
            int intervel;
            // base:    partners' money
            // invest:  projects' money
            float baseMoney = 0;
            float baseInvest = 0;
            // income:  projects' interest
            float projInterest = 0;
            // payout:  partners' interest
            float parInterest = 0;
            // outcome: debts' money
            float debtMoney = 0;
            // adjust:  calendars' comment
            float adjustMoney = 0;

            for (int i = 1; i <= 12; i++)
            {
                baseMoney = 0;
                baseInvest = 0;
                projInterest = 0;
                parInterest = 0;
                debtMoney = 0;
                adjustMoney = 0;

                start = new DateTime(dateTimePicker_year.Value.Year, i, 1);
                end = start.AddDays(1 - start.Day).AddMonths(1).AddDays(-1);
                
/* partners */  foreach (Partner partner in ar_Partners)
                {
                    foreach (Fund fund in partner.funds)
                    {
                        if (fund.start < end) // except future invest
                        {
                            if (fund.end < end) // finished interest
                            {
                                parInterest += fund.volume * (fund.rate / 12) * ((fund.end.Year - fund.start.Year) * 12 + fund.end.Month - fund.start.Month);
                            }
                            else
                            {
                                baseMoney += fund.volume; // current base money
                                if (fund.cycle != Cycle.undefined) // undefined payback should be defined in calendar
                                {
                                    switch (fund.cycle)
                                    {
                                        case Cycle.monthly: intervel = 1; break;
                                        case Cycle.seasonly: intervel = 3; break;
                                        case Cycle.halfyearly: intervel = 6; break;
                                        case Cycle.yearly: intervel = 12; break;
                                        default: intervel = 0; break;
                                    }
                                    parInterest += fund.volume * (fund.rate * intervel / 12) * ((int)((end.Year - fund.start.Year) * 12 + end.Month - fund.start.Month) / intervel);
                                }
                            }
                        }
                    }
                }

/* projects */  foreach (Project project in ar_Projects)
                {
                    if (project.start < end)
                    {
                        if (project.end < end)
                        {
                            projInterest += project.volume * (project.rate / 12) * ((project.end.Year - project.start.Year) * 12 + project.end.Month - project.start.Month);
                        }
                        else
                        {
                            baseInvest += project.volume;
                            switch (project.cycle)
                            {
                                case Cycle.monthly: intervel = 1; break;
                                case Cycle.seasonly: intervel = 3; break;
                                case Cycle.halfyearly: intervel = 6; break;
                                case Cycle.yearly: intervel = 12; break;
                                default: intervel = 0; break;
                            }
                            projInterest += project.volume * (project.rate * intervel / 12) * ((int)((end.Year - project.start.Year) * 12 + end.Month - project.start.Month) / intervel);
                        }
                    }
                }

/* debts */     foreach (Debt debt in ar_Debts)
                {
                    if (debt.start < end)
                    {
                        switch (debt.cycle)
                        {
                            case Cycle.monthly: intervel = 1; break;
                            case Cycle.seasonly: intervel = 3; break;
                            case Cycle.halfyearly: intervel = 6; break;
                            case Cycle.yearly: intervel = 12; break;
                            default: intervel = 0; break;
                        }
                        if (debt.end < end)
                        {
                            debtMoney += debt.volume * ((debt.end.Year - debt.start.Year) * 12 + debt.end.Month - debt.start.Month) / intervel;
                        }
                        else
                        {
                            debtMoney += debt.volume * ((int)((end.Year - debt.start.Year) * 12 + end.Month - debt.start.Month) / intervel);
                        }
                    }
                }

/* calendar */  foreach (Calendar calendar in ar_Calendars)
                {
                    if (calendar.date <= end)
                    {
                        foreach (Flow flow in calendar.flows)
                        {
                            if (flow.type == FlowType.income)
                            {
                                adjustMoney += flow.volume;
                            }
                            else if (flow.type == FlowType.payout)
                            {
                                adjustMoney -= flow.volume;
                            }
                        }
                    }
                }

                // sum all up
                Xlabelslist.Add(i.ToString() + "月");
                invests.Add(new PointPair(i, baseInvest));
                cash.Add(new PointPair(i, baseMoney - baseInvest + projInterest - parInterest - debtMoney + adjustMoney));
            }
                        
            // degrees for horizontal bars
            myPane.XAxis.Scale.TextLabels = Xlabelslist.ToArray();
            BarItem barInvest = myPane.AddBar("资产", invests, Color.Red);
            barInvest.Bar.Fill = new Fill(Color.LightBlue);
            BarItem barCash = myPane.AddBar("现金", cash, Color.Blue);
            barCash.Bar.Fill = new Fill(Color.Gold);

            zedGraph.AxisChange();

            // Create TextObj's to provide labels for each bar
            CreateBarLabels(myPane, true, "N0");

            zedGraph.Refresh();
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            panel1.Location = new Point(0, 34);
            panel1.Width = Width - 16;
            panel1.Height = Height - 116;
            dateTimePicker_year.Location = new Point(Width / 2 - 36, 7);
            button_pre.Location = new Point(Width / 2 - 120, 5);
            button_next.Location = new Point(Width / 2 + 29, 5);
            button_partner.Location = new Point(0, Height - 76);
            button_invest.Location = new Point(button_invest.Location.X, Height - 76);
            button_debt.Location = new Point(button_debt.Location.X, Height - 76);
            button_quit.Location = new Point(Width - 128, Height - 76);
        }

        private void button_quit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_partner_Click(object sender, EventArgs e)
        {
            Form_Partner partner = new Form_Partner();
            partner.ShowDialog();
        }

        private void button_invest_Click(object sender, EventArgs e)
        {
            Form_Project project = new Form_Project();
            project.ShowDialog();
        }

        private void button_debt_Click(object sender, EventArgs e)
        {
            Form_Debt debt = new Form_Debt();
            debt.ShowDialog();
        }

        private void zedGraph_MouseMove(object sender, MouseEventArgs e)
        {
            using (Graphics g = zedGraph.CreateGraphics())
            {
                if (zedGraph.MasterPane.FindNearestPaneObject(new Point(e.X, e.Y), g, out tmpPane, out nearestObj, out ipt))
                {
                    if (nearestObj is BarItem && ipt >= 0)
                    {
                        zedGraph.Cursor = Cursors.Hand;                        
                    }
                    else
                    {
                        zedGraph.Cursor = Cursors.Default;
                    }
                }
            }
        }

        private void zedGraph_MouseClick(object sender, MouseEventArgs e)
        {
            if (zedGraph.Cursor == Cursors.Hand)
            {
                CurveItem tmpCurve;
                int tmpNearest;
                tmpCurve = null;
                tmpNearest = -1;

                myPane.FindNearestPoint(new PointF(e.X, e.Y), out tmpCurve, out tmpNearest);
                if (tmpCurve != null && tmpNearest != -1)
                {
                    Form_Calendar calendar = new Form_Calendar(new DateTime(dateTimePicker_year.Value.Year, (int)tmpCurve[tmpNearest].X, 1));
                    calendar.ShowDialog();
                }
            }
        }     

        private void CreateBarLabels(GraphPane pane, bool isBarCenter, string valueFormat)
        {
            pane.GraphObjList.Clear();

            bool isVertical = pane.BarSettings.Base == BarBase.X;

            // Make the gap between the bars and the labels = 2% of the axis range
            float labelOffset;
            if (isVertical)
                labelOffset = (float)(pane.YAxis.Scale.Max - pane.YAxis.Scale.Min) * 0.02f;
            else
                labelOffset = (float)(pane.XAxis.Scale.Max - pane.XAxis.Scale.Min) * 0.02f;

            // keep a count of the number of BarItems
            int curveIndex = 0;

            // Get a valuehandler to do some calculations for us
            ValueHandler valueHandler = new ValueHandler(pane, true);

            // Loop through each curve in the list
            foreach (CurveItem curve in pane.CurveList)
            {
                // work with BarItems only
                BarItem bar = curve as BarItem;
                if (bar != null)
                {
                    IPointList points = curve.Points;

                    // Loop through each point in the BarItem
                    for (int i = 0; i < points.Count; i++)
                    {
                        // Get the high, low and base values for the current bar
                        // note that this method will automatically calculate the "effective"
                        // values if the bar is stacked
                        double baseVal, lowVal, hiVal;
                        valueHandler.GetValues(curve, i, out baseVal, out lowVal, out hiVal);

                        // Get the value that corresponds to the center of the bar base
                        // This method figures out how the bars are positioned within a cluster
                        float centerVal = (float)valueHandler.BarCenterValue(bar,
                            bar.GetBarWidth(pane), i, baseVal, curveIndex);

                        // Create a text label -- note that we have to go back to the original point
                        // data for this, since hiVal and lowVal could be "effective" values from a bar stack
                        string barLabelText = (isVertical ? points[i].Y : points[i].X).ToString(valueFormat);

                        // Calculate the position of the label -- this is either the X or the Y coordinate
                        // depending on whether they are horizontal or vertical bars, respectively
                        float position;
                        if (isBarCenter)
                            position = (float)(hiVal + lowVal) / 2.0f;
                        else
                            position = (float)hiVal + labelOffset;

                        // Create the new TextObj
                        TextObj label;
                        if (isVertical)
                            label = new TextObj(barLabelText, centerVal, position);
                        else
                            label = new TextObj(barLabelText, position, centerVal);

                        // Configure the TextObj
                        label.Location.CoordinateFrame = CoordType.AxisXYScale;
                        label.FontSpec.Size = 12;
                        label.FontSpec.FontColor = Color.Black;
                        label.FontSpec.Angle = isVertical ? 0 : 90;
                        label.Location.AlignH = isBarCenter ? AlignH.Center : AlignH.Left;
                        label.Location.AlignV = AlignV.Center;
                        label.FontSpec.Border.IsVisible = false;
                        label.FontSpec.Fill.IsVisible = false;

                        // Add the TextObj to the GraphPane
                        pane.GraphObjList.Add(label);

                        //if(curveIndex == 1)
                        //{
                        //    string total = (points[i].Y + pane.CurveList[0].Points[i].Y).ToString();
                        //    TextObj totallabel = new TextObj(total, centerVal, position + hiVal - lowVal);
                        //    totallabel.Location.CoordinateFrame = CoordType.AxisXYScale;
                        //    totallabel.FontSpec.Size = 12;
                        //    totallabel.FontSpec.FontColor = Color.Black;
                        //    totallabel.FontSpec.Angle = isVertical ? 0 : 90;
                        //    totallabel.Location.AlignH = isBarCenter ? AlignH.Center : AlignH.Left;
                        //    totallabel.Location.AlignV = AlignV.Center;
                        //    totallabel.FontSpec.Border.IsVisible = false;
                        //    totallabel.FontSpec.Fill.IsVisible = false;
                        //    pane.GraphObjList.Add(totallabel);
                        //}
                    }
                }
                curveIndex++;
            }
        }

        private void dateTimePicker_year_ValueChanged(object sender, EventArgs e)
        {
            Reload();
        }

        private void button_pre_Click(object sender, EventArgs e)
        {
            dateTimePicker_year.Value = new DateTime(dateTimePicker_year.Value.Year - 1, 1, 1);
        }

        private void button_next_Click(object sender, EventArgs e)
        {
            dateTimePicker_year.Value = new DateTime(dateTimePicker_year.Value.Year + 1, 1, 1);
        }
    }
}
