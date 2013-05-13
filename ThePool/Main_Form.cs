using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ThePool
{
    public partial class Main_Form : Form
    {
        DataGridView tempDGV;

        public Main_Form()
        {
            InitializeComponent();
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 12; i++)
            {
                DataGridView dgv;
                GenerateDGV("dgv" + i.ToString(), out dgv);
                dgv.Rows[0].Cells[1].Value = "2013-" + (i + 1).ToString();
                dgv.Rows[0].Cells[4].ToolTipText = "本月新投资A";
                flowLayoutPanel1.Controls.Add(dgv);
            }
        }

        private void GenerateDGV(string name, out DataGridView DGV)
        {
            DGV = new DataGridView();

            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewButtonColumn Column_Header = new DataGridViewButtonColumn();
            DataGridViewTextBoxColumn Column_Date = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn Column_Total = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn Column_Cash = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn Column_Invest = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn Column_Income = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn Column_Payout = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn Column_Adjust = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn Column_Comment = new DataGridViewTextBoxColumn();
            // 
            // dataGridView
            // 
            DGV.AllowUserToAddRows = false;
            DGV.AllowUserToDeleteRows = false;
            DGV.AllowUserToResizeRows = false;
            DGV.ForeColor = Color.Black;
            DGV.BackgroundColor = Color.White;
            DGV.DefaultCellStyle.SelectionBackColor = Color.White;
            DGV.DefaultCellStyle.SelectionForeColor = Color.Black;
            DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV.Columns.AddRange(new DataGridViewColumn[] {
            Column_Header,
            Column_Date,
            Column_Total,
            Column_Cash,
            Column_Invest,
            Column_Income,
            Column_Payout,
            Column_Adjust,
            Column_Comment});
            DGV.Location = new System.Drawing.Point(3, 3);
            DGV.Name = name;
            DGV.ReadOnly = true;
            DGV.RowHeadersVisible = false;
            DGV.RowTemplate.Height = 23;
            DGV.Size = new System.Drawing.Size(1500, 60);
            DGV.TabIndex = 0;
            DGV.CellContentClick += new DataGridViewCellEventHandler(DGV_CellContentClick);
            // 
            // Column_Header
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Column_Header.DefaultCellStyle = dataGridViewCellStyle1;
            Column_Header.HeaderText = "";
            Column_Header.Name = "Column_Header";
            Column_Header.ReadOnly = true;
            Column_Header.Resizable = DataGridViewTriState.False;
            Column_Header.Width = 30;
            Column_Header.SortMode = DataGridViewColumnSortMode.NotSortable;
            Column_Header.Resizable = DataGridViewTriState.False;
            // 
            // Column_Date
            // 
            Column_Date.HeaderText = "";
            Column_Date.Name = "Column_Date";
            Column_Date.ReadOnly = true;
            Column_Date.Resizable = DataGridViewTriState.False;
            Column_Date.SortMode = DataGridViewColumnSortMode.NotSortable;
            Column_Date.Resizable = DataGridViewTriState.False;
            Column_Date.DefaultCellStyle.Font = new Font(DGV.DefaultCellStyle.Font, FontStyle.Bold);
            // 
            // Column_Total
            // 
            Column_Total.HeaderText = "总资产";
            Column_Total.Name = "Column_Total";
            Column_Total.ReadOnly = true;
            Column_Total.Resizable = DataGridViewTriState.True;
            Column_Total.SortMode = DataGridViewColumnSortMode.NotSortable;
            Column_Total.Resizable = DataGridViewTriState.False;
            // 
            // Column_Cash
            // 
            Column_Cash.HeaderText = "现金";
            Column_Cash.Name = "Column_Cash";
            Column_Cash.ReadOnly = true;
            Column_Cash.Resizable = DataGridViewTriState.True;
            Column_Cash.SortMode = DataGridViewColumnSortMode.NotSortable;
            Column_Cash.Resizable = DataGridViewTriState.False;
            // 
            // Column_Invest
            // 
            Column_Invest.HeaderText = "投资额";
            Column_Invest.Name = "Column_Invest";
            Column_Invest.ReadOnly = true;
            Column_Invest.SortMode = DataGridViewColumnSortMode.NotSortable;
            Column_Invest.Resizable = DataGridViewTriState.False;
            // 
            // Column_Income
            // 
            Column_Income.HeaderText = "收入";
            Column_Income.Name = "Column_Income";
            Column_Income.ReadOnly = true;
            Column_Income.SortMode = DataGridViewColumnSortMode.NotSortable;
            Column_Income.Resizable = DataGridViewTriState.False;
            // 
            // Column_Payout
            // 
            Column_Payout.HeaderText = "支出";
            Column_Payout.Name = "Column_Payout";
            Column_Payout.ReadOnly = true;
            Column_Payout.SortMode = DataGridViewColumnSortMode.NotSortable;
            Column_Payout.Resizable = DataGridViewTriState.False;
            // 
            // Column_Adjust
            // 
            Column_Adjust.HeaderText = "调整";
            Column_Adjust.Name = "Column_Adjust";
            Column_Adjust.ReadOnly = true;
            Column_Adjust.SortMode = DataGridViewColumnSortMode.NotSortable;
            Column_Adjust.Resizable = DataGridViewTriState.False;
            //
            // Column_Comment
            // 
            Column_Comment.HeaderText = "备注";
            Column_Comment.Name = "Column_Comment";
            Column_Comment.ReadOnly = true;
            Column_Comment.SortMode = DataGridViewColumnSortMode.NotSortable;
            Column_Comment.Width = 1766;

            DGV.Rows.Add();
            DGV.Rows[0].Cells[0].Value = "+";
        }

        private void GenerateGB(string name, out GroupBox GB)
        {
            GB = new GroupBox();
            GB.Name = name;
            GB.Text = name;

            TabControl tabControl_month;
            TabPage tabPage_cash;
            Button button_new;
            Button button_save;
            GroupBox groupbox_cash;
            ComboBox comboBox_day;
            ComboBox comboBox_cycle;
            NumericUpDown numericUpDown_volume;
            NumericUpDown numericUpDown_rate;
            Label label3;
            Label label10;
            Label label2;
            Label label7;
            Label label6;
            Label label4;
            Label label8;
            Label label5;
            TextBox textBox_phone;
            TextBox textBox_comment;
            TextBox textBox_contact;
            TextBox textBox_name;
            Label label1;
            NumericUpDown numericUpDown_cash;
            TabPage tabPage_invest;
            Label label18;
            NumericUpDown numericUpDown_invest;
            GroupBox groupBox_invest;
            ComboBox comboBox_dayinvest;
            ComboBox comboBox_cycleinvest;
            Button button_stopinvest;
            NumericUpDown numericUpDown_volumeinvest;
            NumericUpDown numericUpDown_rateinvest;
            Button button_updateinvest;
            Label label9;
            Label label11;
            Label label12;
            Label label13;
            Label label14;
            Label label15;
            Label label16;
            Label label17;
            TextBox textBox_telephoneinvest;
            TextBox textBox_commentinvest;
            TextBox textBox_contactinvest;
            TextBox textBox_nameinvest;
            ListBox listBox_invest;
            TabPage tabPage_debt;
            Label label23;
            NumericUpDown numericUpDown_debt;
            GroupBox groupBox_debt;
            ComboBox comboBox_daydebt;
            Label label22;
            ComboBox comboBox_cycledebt;
            NumericUpDown numericUpDown_volumedebt;
            Label label19;
            Button button3;
            Label label20;
            Label label21;
            Label label24;
            TextBox textBox_commentdebt;
            TextBox textBox_namedebt;
            Button button_stopdebt;
            Button button_updatedebt;
            Button button_newdebt;
            ListBox listBox_debt;
            TabPage tabPage_payout;
            DataGridView dataGridView_payout;
            Button button_savepayout;
            Label label25;
            NumericUpDown numericUpDown_payout;
            TabPage tabPage_income;
            DataGridView dataGridView_income;
            Button button_saveincome;
            Label label26;
            NumericUpDown numericUpDown_income;            
            DataGridViewTextBoxColumn Column_payout_day;
            DataGridViewTextBoxColumn Column_payout_volume;
            DataGridViewTextBoxColumn Column_payout_comment;            
            DataGridViewTextBoxColumn Column_income_day;
            DataGridViewTextBoxColumn Column_income_volume;
            DataGridViewTextBoxColumn Column_income_comment;
            ContextMenuStrip contextMenuStrip1;
            ToolStripMenuItem ToolStripMenuItem_delete;

            tabControl_month = new TabControl();
            tabPage_cash = new TabPage();
            button_new = new Button();
            button_save = new Button();
            groupbox_cash = new GroupBox();
            comboBox_day = new ComboBox();
            comboBox_cycle = new ComboBox();
            numericUpDown_volume = new NumericUpDown();
            numericUpDown_rate = new NumericUpDown();
            label3 = new Label();
            label10 = new Label();
            label2 = new Label();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            label8 = new Label();
            label5 = new Label();
            textBox_phone = new TextBox();
            textBox_comment = new TextBox();
            textBox_contact = new TextBox();
            textBox_name = new TextBox();
            label1 = new Label();
            numericUpDown_cash = new NumericUpDown();
            tabPage_invest = new TabPage();
            label18 = new Label();
            numericUpDown_invest = new NumericUpDown();
            groupBox_invest = new GroupBox();
            comboBox_dayinvest = new ComboBox();
            comboBox_cycleinvest = new ComboBox();
            button_stopinvest = new Button();
            numericUpDown_volumeinvest = new NumericUpDown();
            numericUpDown_rateinvest = new NumericUpDown();
            button_updateinvest = new Button();
            label9 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            textBox_telephoneinvest = new TextBox();
            textBox_commentinvest = new TextBox();
            textBox_contactinvest = new TextBox();
            textBox_nameinvest = new TextBox();
            listBox_invest = new ListBox();
            tabPage_debt = new TabPage();
            label23 = new Label();
            numericUpDown_debt = new NumericUpDown();
            groupBox_debt = new GroupBox();
            comboBox_daydebt = new ComboBox();
            label22 = new Label();
            comboBox_cycledebt = new ComboBox();
            numericUpDown_volumedebt = new NumericUpDown();
            label19 = new Label();
            button3 = new Button();
            label20 = new Label();
            label21 = new Label();
            label24 = new Label();
            textBox_commentdebt = new TextBox();
            textBox_namedebt = new TextBox();
            button_stopdebt = new Button();
            button_updatedebt = new Button();
            button_newdebt = new Button();
            listBox_debt = new ListBox();
            tabPage_payout = new TabPage();
            dataGridView_payout = new DataGridView();
            button_savepayout = new Button();
            label25 = new Label();
            numericUpDown_payout = new NumericUpDown();
            tabPage_income = new TabPage();
            dataGridView_income = new DataGridView();
            button_saveincome = new Button();
            label26 = new Label();
            numericUpDown_income = new NumericUpDown();
            Column_payout_day = new DataGridViewTextBoxColumn();
            Column_payout_volume = new DataGridViewTextBoxColumn();
            Column_payout_comment = new DataGridViewTextBoxColumn();
            Column_income_day = new DataGridViewTextBoxColumn();
            Column_income_volume = new DataGridViewTextBoxColumn();
            Column_income_comment = new DataGridViewTextBoxColumn();
            contextMenuStrip1 = new ContextMenuStrip();
            ToolStripMenuItem_delete = new ToolStripMenuItem();
            contextMenuStrip1.SuspendLayout();
            GB.SuspendLayout();
            tabControl_month.SuspendLayout();
            tabPage_cash.SuspendLayout();
            groupbox_cash.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(numericUpDown_volume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(numericUpDown_rate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(numericUpDown_cash)).BeginInit();
            tabPage_invest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(numericUpDown_invest)).BeginInit();
            groupBox_invest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(numericUpDown_volumeinvest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(numericUpDown_rateinvest)).BeginInit();
            tabPage_debt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(numericUpDown_debt)).BeginInit();
            groupBox_debt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(numericUpDown_volumedebt)).BeginInit();
            tabPage_payout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(dataGridView_payout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(numericUpDown_payout)).BeginInit();
            tabPage_income.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(dataGridView_income)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(numericUpDown_income)).BeginInit();
            SuspendLayout();
            // 
            // groupBox_month
            // 
            GB.Controls.Add(tabControl_month);
            
            GB.Size = new System.Drawing.Size(735, 255);
            GB.TabIndex = 1;
            GB.TabStop = false;
            // 
            // tabControl_month
            // 
            tabControl_month.Controls.Add(tabPage_cash);
            tabControl_month.Controls.Add(tabPage_invest);
            tabControl_month.Controls.Add(tabPage_debt);
            tabControl_month.Controls.Add(tabPage_payout);
            tabControl_month.Controls.Add(tabPage_income);
            tabControl_month.Dock = DockStyle.Fill;
            tabControl_month.ItemSize = new System.Drawing.Size(145, 20);
            tabControl_month.Location = new System.Drawing.Point(3, 17);
            tabControl_month.Name = "tabControl_month";
            tabControl_month.RightToLeft = RightToLeft.No;
            tabControl_month.SelectedIndex = 0;
            tabControl_month.Size = new System.Drawing.Size(729, 235);
            tabControl_month.SizeMode = TabSizeMode.Fixed;
            tabControl_month.TabIndex = 2;
            // 
            // tabPage_cash
            // 
            tabPage_cash.Controls.Add(button_new);
            tabPage_cash.Controls.Add(button_save);
            tabPage_cash.Controls.Add(groupbox_cash);
            tabPage_cash.Controls.Add(label1);
            tabPage_cash.Controls.Add(numericUpDown_cash);
            tabPage_cash.Location = new System.Drawing.Point(4, 24);
            tabPage_cash.Name = "tabPage_cash";
            tabPage_cash.Padding = new Padding(3);
            tabPage_cash.Size = new System.Drawing.Size(721, 207);
            tabPage_cash.TabIndex = 0;
            tabPage_cash.Text = "现金";
            tabPage_cash.UseVisualStyleBackColor = true;
            // 
            // button_new
            // 
            button_new.Location = new System.Drawing.Point(624, 111);
            button_new.Name = "button_new";
            button_new.Size = new System.Drawing.Size(75, 23);
            button_new.FlatStyle = FlatStyle.Flat;
            button_new.FlatAppearance.BorderSize = 0;
            button_new.TabIndex = 7;
            button_new.Text = "清 空";
            button_new.UseVisualStyleBackColor = true;
            // 
            // button_save
            // 
            button_save.Location = new System.Drawing.Point(624, 151);
            button_save.Name = "button_save";
            button_save.Size = new System.Drawing.Size(75, 23);
            button_save.TabIndex = 7;
            button_save.Text = "保存新投资";
            button_save.UseVisualStyleBackColor = true;
            // 
            // groupbox_cash
            // 
            groupbox_cash.Controls.Add(comboBox_day);
            groupbox_cash.Controls.Add(comboBox_cycle);
            groupbox_cash.Controls.Add(numericUpDown_volume);
            groupbox_cash.Controls.Add(numericUpDown_rate);
            groupbox_cash.Controls.Add(label3);
            groupbox_cash.Controls.Add(label10);
            groupbox_cash.Controls.Add(label2);
            groupbox_cash.Controls.Add(label7);
            groupbox_cash.Controls.Add(label6);
            groupbox_cash.Controls.Add(label4);
            groupbox_cash.Controls.Add(label8);
            groupbox_cash.Controls.Add(label5);
            groupbox_cash.Controls.Add(textBox_phone);
            groupbox_cash.Controls.Add(textBox_comment);
            groupbox_cash.Controls.Add(textBox_contact);
            groupbox_cash.Controls.Add(textBox_name);
            groupbox_cash.Location = new System.Drawing.Point(136, 20);
            groupbox_cash.Name = "groupbox_cash";
            groupbox_cash.Size = new System.Drawing.Size(471, 167);
            groupbox_cash.TabIndex = 6;
            groupbox_cash.TabStop = false;
            // 
            // comboBox_day
            // 
            comboBox_day.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_day.FormattingEnabled = true;
            comboBox_day.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            comboBox_day.Location = new System.Drawing.Point(350, 81);
            comboBox_day.Name = "comboBox_day";
            comboBox_day.Size = new System.Drawing.Size(100, 20);
            comboBox_day.TabIndex = 6;
            // 
            // comboBox_cycle
            // 
            comboBox_cycle.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_cycle.FormattingEnabled = true;
            comboBox_cycle.Items.AddRange(new object[] {
            "不定期",
            "每月",
            "每季度",
            "每半年",
            "每年"});
            comboBox_cycle.Location = new System.Drawing.Point(236, 81);
            comboBox_cycle.Name = "comboBox_cycle";
            comboBox_cycle.Size = new System.Drawing.Size(100, 20);
            comboBox_cycle.TabIndex = 6;
            // 
            // numericUpDown_volume
            // 
            numericUpDown_volume.Location = new System.Drawing.Point(6, 81);
            numericUpDown_volume.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            numericUpDown_volume.Name = "numericUpDown_volume";
            numericUpDown_volume.Size = new System.Drawing.Size(100, 21);
            numericUpDown_volume.TabIndex = 4;
            numericUpDown_volume.TextAlign = HorizontalAlignment.Right;
            // 
            // numericUpDown_rate
            // 
            numericUpDown_rate.DecimalPlaces = 2;
            numericUpDown_rate.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            numericUpDown_rate.Location = new System.Drawing.Point(121, 81);
            numericUpDown_rate.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            numericUpDown_rate.Name = "numericUpDown_rate";
            numericUpDown_rate.Size = new System.Drawing.Size(100, 21);
            numericUpDown_rate.TabIndex = 4;
            numericUpDown_rate.TextAlign = HorizontalAlignment.Right;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(236, 14);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(53, 12);
            label3.TabIndex = 3;
            label3.Text = "联系电话";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(6, 64);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(65, 12);
            label10.TabIndex = 3;
            label10.Text = "资金量(万)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(121, 64);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(53, 12);
            label2.TabIndex = 3;
            label2.Text = "年化利率";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(6, 116);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(29, 12);
            label7.TabIndex = 3;
            label7.Text = "备注";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(350, 67);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(41, 12);
            label6.TabIndex = 3;
            label6.Text = "付息日";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(121, 14);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(41, 12);
            label4.TabIndex = 3;
            label4.Text = "联系人";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(236, 67);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(53, 12);
            label8.TabIndex = 3;
            label8.Text = "付息周期";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(6, 14);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(77, 12);
            label5.TabIndex = 3;
            label5.Text = "投资项目名称";
            // 
            // textBox_phone
            // 
            textBox_phone.Location = new System.Drawing.Point(236, 32);
            textBox_phone.MaxLength = 11;
            textBox_phone.Name = "textBox_phone";
            textBox_phone.Size = new System.Drawing.Size(100, 21);
            textBox_phone.TabIndex = 2;
            // 
            // textBox_comment
            // 
            textBox_comment.Location = new System.Drawing.Point(6, 133);
            textBox_comment.MaxLength = 8;
            textBox_comment.Name = "textBox_comment";
            textBox_comment.Size = new System.Drawing.Size(444, 21);
            textBox_comment.TabIndex = 2;
            // 
            // textBox_contact
            // 
            textBox_contact.Location = new System.Drawing.Point(121, 32);
            textBox_contact.MaxLength = 8;
            textBox_contact.Name = "textBox_contact";
            textBox_contact.Size = new System.Drawing.Size(100, 21);
            textBox_contact.TabIndex = 2;
            // 
            // textBox_name
            // 
            textBox_name.Location = new System.Drawing.Point(6, 32);
            textBox_name.MaxLength = 32;
            textBox_name.Name = "textBox_name";
            textBox_name.Size = new System.Drawing.Size(100, 21);
            textBox_name.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            label1.Location = new System.Drawing.Point(18, 25);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(84, 12);
            label1.TabIndex = 1;
            label1.Text = "本月现金(万)";
            // 
            // numericUpDown_cash
            // 
            numericUpDown_cash.Location = new System.Drawing.Point(20, 40);
            numericUpDown_cash.Name = "numericUpDown_cash";
            numericUpDown_cash.Enabled = false;
            numericUpDown_cash.Size = new System.Drawing.Size(87, 21);
            numericUpDown_cash.TabIndex = 0;
            numericUpDown_cash.TextAlign = HorizontalAlignment.Center;
            numericUpDown_cash.InterceptArrowKeys = false;
            numericUpDown_cash.Maximum = 100000;
            // 
            // tabPage_invest
            // 
            tabPage_invest.Controls.Add(label18);
            tabPage_invest.Controls.Add(numericUpDown_invest);
            tabPage_invest.Controls.Add(groupBox_invest);
            tabPage_invest.Controls.Add(listBox_invest);
            tabPage_invest.Location = new System.Drawing.Point(4, 24);
            tabPage_invest.Name = "tabPage_invest";
            tabPage_invest.Padding = new Padding(3);
            tabPage_invest.Size = new System.Drawing.Size(721, 207);
            tabPage_invest.TabIndex = 1;
            tabPage_invest.Text = "投资";
            tabPage_invest.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            label18.Location = new System.Drawing.Point(18, 25);
            label18.Name = "label18";
            label18.Size = new System.Drawing.Size(84, 12);
            label18.TabIndex = 14;
            label18.Text = "本月投资(万)";
            // 
            // numericUpDown_invest
            // 
            numericUpDown_invest.Location = new System.Drawing.Point(20, 40);
            numericUpDown_invest.Name = "numericUpDown_invest";
            numericUpDown_invest.Enabled = false;
            numericUpDown_invest.Size = new System.Drawing.Size(87, 21);
            numericUpDown_invest.TabIndex = 13;
            numericUpDown_invest.TextAlign = HorizontalAlignment.Center;
            numericUpDown_invest.InterceptArrowKeys = false;
            numericUpDown_invest.Maximum = 100000;
            // 
            // groupBox_invest
            // 
            groupBox_invest.Controls.Add(comboBox_dayinvest);
            groupBox_invest.Controls.Add(comboBox_cycleinvest);
            groupBox_invest.Controls.Add(button_stopinvest);
            groupBox_invest.Controls.Add(numericUpDown_volumeinvest);
            groupBox_invest.Controls.Add(numericUpDown_rateinvest);
            groupBox_invest.Controls.Add(button_updateinvest);
            groupBox_invest.Controls.Add(label9);
            groupBox_invest.Controls.Add(label11);
            groupBox_invest.Controls.Add(label12);
            groupBox_invest.Controls.Add(label13);
            groupBox_invest.Controls.Add(label14);
            groupBox_invest.Controls.Add(label15);
            groupBox_invest.Controls.Add(label16);
            groupBox_invest.Controls.Add(label17);
            groupBox_invest.Controls.Add(textBox_telephoneinvest);
            groupBox_invest.Controls.Add(textBox_commentinvest);
            groupBox_invest.Controls.Add(textBox_contactinvest);
            groupBox_invest.Controls.Add(textBox_nameinvest);
            groupBox_invest.Location = new System.Drawing.Point(258, 6);
            groupBox_invest.Name = "groupBox_invest";
            groupBox_invest.Size = new System.Drawing.Size(457, 195);
            groupBox_invest.TabIndex = 12;
            groupBox_invest.TabStop = false;
            // 
            // comboBox_dayinvest
            // 
            comboBox_dayinvest.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_dayinvest.FormattingEnabled = true;
            comboBox_dayinvest.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            comboBox_dayinvest.Location = new System.Drawing.Point(350, 81);
            comboBox_dayinvest.Name = "comboBox_dayinvest";
            comboBox_dayinvest.Size = new System.Drawing.Size(100, 20);
            comboBox_dayinvest.TabIndex = 6;
            // 
            // comboBox_cycleinvest
            // 
            comboBox_cycleinvest.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_cycleinvest.FormattingEnabled = true;
            comboBox_cycleinvest.Items.AddRange(new object[] {
            "不定期",
            "每月",
            "每季度",
            "每半年",
            "每年"});
            comboBox_cycleinvest.Location = new System.Drawing.Point(236, 81);
            comboBox_cycleinvest.Name = "comboBox_cycleinvest";
            comboBox_cycleinvest.Size = new System.Drawing.Size(100, 20);
            comboBox_cycleinvest.TabIndex = 6;
            // 
            // button_stopinvest
            // 
            button_stopinvest.Location = new System.Drawing.Point(246, 160);
            button_stopinvest.Name = "button_stopinvest";
            button_stopinvest.Size = new System.Drawing.Size(91, 25);
            button_stopinvest.TabIndex = 9;
            button_stopinvest.Text = "停止项目";
            button_stopinvest.UseVisualStyleBackColor = true;
            // 
            // numericUpDown_volumeinvest
            // 
            numericUpDown_volumeinvest.Location = new System.Drawing.Point(6, 81);
            numericUpDown_volumeinvest.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            numericUpDown_volumeinvest.Name = "numericUpDown_volumeinvest";
            numericUpDown_volumeinvest.Size = new System.Drawing.Size(100, 21);
            numericUpDown_volumeinvest.TabIndex = 4;
            numericUpDown_volumeinvest.TextAlign = HorizontalAlignment.Right;
            // 
            // numericUpDown_rateinvest
            // 
            numericUpDown_rateinvest.DecimalPlaces = 2;
            numericUpDown_rateinvest.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            numericUpDown_rateinvest.Location = new System.Drawing.Point(121, 81);
            numericUpDown_rateinvest.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            numericUpDown_rateinvest.Name = "numericUpDown_rateinvest";
            numericUpDown_rateinvest.Size = new System.Drawing.Size(100, 21);
            numericUpDown_rateinvest.TabIndex = 4;
            numericUpDown_rateinvest.TextAlign = HorizontalAlignment.Right;
            // 
            // button_updateinvest
            // 
            button_updateinvest.Location = new System.Drawing.Point(359, 160);
            button_updateinvest.Name = "button_updateinvest";
            button_updateinvest.Size = new System.Drawing.Size(91, 25);
            button_updateinvest.TabIndex = 8;
            button_updateinvest.Text = "更新项目";
            button_updateinvest.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(236, 14);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(53, 12);
            label9.TabIndex = 3;
            label9.Text = "联系电话";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(6, 64);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(65, 12);
            label11.TabIndex = 3;
            label11.Text = "资金量(万)";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new System.Drawing.Point(121, 64);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(53, 12);
            label12.TabIndex = 3;
            label12.Text = "年化利率";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new System.Drawing.Point(6, 116);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(29, 12);
            label13.TabIndex = 3;
            label13.Text = "备注";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new System.Drawing.Point(350, 67);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(41, 12);
            label14.TabIndex = 3;
            label14.Text = "付息日";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new System.Drawing.Point(121, 14);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(41, 12);
            label15.TabIndex = 3;
            label15.Text = "联系人";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new System.Drawing.Point(236, 67);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(53, 12);
            label16.TabIndex = 3;
            label16.Text = "付息周期";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new System.Drawing.Point(6, 14);
            label17.Name = "label17";
            label17.Size = new System.Drawing.Size(77, 12);
            label17.TabIndex = 3;
            label17.Text = "投资项目名称";
            // 
            // textBox_telephoneinvest
            // 
            textBox_telephoneinvest.Location = new System.Drawing.Point(236, 32);
            textBox_telephoneinvest.MaxLength = 11;
            textBox_telephoneinvest.Name = "textBox_telephoneinvest";
            textBox_telephoneinvest.Size = new System.Drawing.Size(100, 21);
            textBox_telephoneinvest.TabIndex = 2;
            // 
            // textBox_commentinvest
            // 
            textBox_commentinvest.Location = new System.Drawing.Point(6, 133);
            textBox_commentinvest.MaxLength = 8;
            textBox_commentinvest.Name = "textBox_commentinvest";
            textBox_commentinvest.Size = new System.Drawing.Size(444, 21);
            textBox_commentinvest.TabIndex = 2;
            // 
            // textBox_contactinvest
            // 
            textBox_contactinvest.Location = new System.Drawing.Point(121, 32);
            textBox_contactinvest.MaxLength = 8;
            textBox_contactinvest.Name = "textBox_contactinvest";
            textBox_contactinvest.Size = new System.Drawing.Size(100, 21);
            textBox_contactinvest.TabIndex = 2;
            // 
            // textBox_nameinvest
            // 
            textBox_nameinvest.Location = new System.Drawing.Point(6, 32);
            textBox_nameinvest.MaxLength = 32;
            textBox_nameinvest.Name = "textBox_nameinvest";
            textBox_nameinvest.Size = new System.Drawing.Size(100, 21);
            textBox_nameinvest.TabIndex = 2;
            // 
            // listBox_invest
            // 
            listBox_invest.FormattingEnabled = true;
            listBox_invest.ItemHeight = 12;
            listBox_invest.Location = new System.Drawing.Point(111, 5);
            listBox_invest.Name = "listBox_invest";
            listBox_invest.ScrollAlwaysVisible = true;
            listBox_invest.Size = new System.Drawing.Size(141, 196);
            listBox_invest.TabIndex = 7;
            // 
            // tabPage_debt
            // 
            tabPage_debt.Controls.Add(label23);
            tabPage_debt.Controls.Add(numericUpDown_debt);
            tabPage_debt.Controls.Add(groupBox_debt);
            tabPage_debt.Controls.Add(button_stopdebt);
            tabPage_debt.Controls.Add(button_updatedebt);
            tabPage_debt.Controls.Add(button_newdebt);
            tabPage_debt.Controls.Add(listBox_debt);
            tabPage_debt.Location = new System.Drawing.Point(4, 24);
            tabPage_debt.Name = "tabPage_debt";
            tabPage_debt.Padding = new Padding(3);
            tabPage_debt.Size = new System.Drawing.Size(721, 207);
            tabPage_debt.TabIndex = 4;
            tabPage_debt.Text = "负债";
            tabPage_debt.UseVisualStyleBackColor = true;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            label23.Location = new System.Drawing.Point(18, 25);
            label23.Name = "label23";
            label23.Size = new System.Drawing.Size(84, 12);
            label23.TabIndex = 25;
            label23.Text = "本月负债(万)";
            // 
            // numericUpDown_debt
            // 
            numericUpDown_debt.Location = new System.Drawing.Point(20, 40);
            numericUpDown_debt.Name = "numericUpDown_debt";
            numericUpDown_debt.Enabled = false;
            numericUpDown_debt.Size = new System.Drawing.Size(87, 21);
            numericUpDown_debt.TabIndex = 24;
            numericUpDown_debt.TextAlign = HorizontalAlignment.Center;
            numericUpDown_debt.InterceptArrowKeys = false;
            numericUpDown_debt.Maximum = 100000;
            // 
            // groupBox_debt
            // 
            groupBox_debt.Controls.Add(comboBox_daydebt);
            groupBox_debt.Controls.Add(label22);
            groupBox_debt.Controls.Add(comboBox_cycledebt);
            groupBox_debt.Controls.Add(numericUpDown_volumedebt);
            groupBox_debt.Controls.Add(label19);
            groupBox_debt.Controls.Add(button3);
            groupBox_debt.Controls.Add(label20);
            groupBox_debt.Controls.Add(label21);
            groupBox_debt.Controls.Add(label24);
            groupBox_debt.Controls.Add(textBox_commentdebt);
            groupBox_debt.Controls.Add(textBox_namedebt);
            groupBox_debt.Location = new System.Drawing.Point(273, 6);
            groupBox_debt.Name = "groupBox_debt";
            groupBox_debt.Size = new System.Drawing.Size(323, 195);
            groupBox_debt.TabIndex = 22;
            groupBox_debt.TabStop = false;
            groupBox_debt.Text = "负债信息";
            // 
            // comboBox_daydebt
            // 
            comboBox_daydebt.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_daydebt.FormattingEnabled = true;
            comboBox_daydebt.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            comboBox_daydebt.Location = new System.Drawing.Point(150, 95);
            comboBox_daydebt.Name = "comboBox_daydebt";
            comboBox_daydebt.Size = new System.Drawing.Size(100, 20);
            comboBox_daydebt.TabIndex = 14;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new System.Drawing.Point(150, 81);
            label22.Name = "label22";
            label22.Size = new System.Drawing.Size(41, 12);
            label22.TabIndex = 13;
            label22.Text = "结账日";
            // 
            // comboBox_cycledebt
            // 
            comboBox_cycledebt.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_cycledebt.FormattingEnabled = true;
            comboBox_cycledebt.Items.AddRange(new object[] {
            "不定期",
            "每月",
            "每季度",
            "每半年",
            "每年"});
            comboBox_cycledebt.Location = new System.Drawing.Point(27, 95);
            comboBox_cycledebt.Name = "comboBox_cycledebt";
            comboBox_cycledebt.Size = new System.Drawing.Size(100, 20);
            comboBox_cycledebt.TabIndex = 6;
            // 
            // numericUpDown_volumedebt
            // 
            numericUpDown_volumedebt.DecimalPlaces = 1;
            numericUpDown_volumedebt.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            numericUpDown_volumedebt.Location = new System.Drawing.Point(150, 45);
            numericUpDown_volumedebt.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            numericUpDown_volumedebt.Name = "numericUpDown_volumedebt";
            numericUpDown_volumedebt.Size = new System.Drawing.Size(100, 21);
            numericUpDown_volumedebt.TabIndex = 4;
            numericUpDown_volumedebt.TextAlign = HorizontalAlignment.Right;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new System.Drawing.Point(150, 30);
            label19.Name = "label19";
            label19.Size = new System.Drawing.Size(53, 12);
            label19.TabIndex = 3;
            label19.Text = "金额(万)";
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(403, 97);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(91, 25);
            button3.TabIndex = 12;
            button3.Text = "保存负债信息";
            button3.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new System.Drawing.Point(27, 130);
            label20.Name = "label20";
            label20.Size = new System.Drawing.Size(29, 12);
            label20.TabIndex = 3;
            label20.Text = "备注";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new System.Drawing.Point(27, 81);
            label21.Name = "label21";
            label21.Size = new System.Drawing.Size(29, 12);
            label21.TabIndex = 3;
            label21.Text = "周期";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new System.Drawing.Point(27, 27);
            label24.Name = "label24";
            label24.Size = new System.Drawing.Size(29, 12);
            label24.TabIndex = 3;
            label24.Text = "名称";
            // 
            // textBox_commentdebt
            // 
            textBox_commentdebt.Location = new System.Drawing.Point(27, 147);
            textBox_commentdebt.MaxLength = 8;
            textBox_commentdebt.Name = "textBox_commentdebt";
            textBox_commentdebt.Size = new System.Drawing.Size(272, 21);
            textBox_commentdebt.TabIndex = 2;
            // 
            // textBox_namedebt
            // 
            textBox_namedebt.Location = new System.Drawing.Point(27, 45);
            textBox_namedebt.MaxLength = 8;
            textBox_namedebt.Name = "textBox_namedebt";
            textBox_namedebt.Size = new System.Drawing.Size(100, 21);
            textBox_namedebt.TabIndex = 2;
            // 
            // button_stopdebt
            // 
            button_stopdebt.Location = new System.Drawing.Point(602, 140);
            button_stopdebt.Name = "button_stopdebt";
            button_stopdebt.Size = new System.Drawing.Size(91, 25);
            button_stopdebt.TabIndex = 20;
            button_stopdebt.Text = "终止负债";
            button_stopdebt.UseVisualStyleBackColor = true;
            // 
            // button_updatedebt
            // 
            button_updatedebt.Location = new System.Drawing.Point(602, 91);
            button_updatedebt.Name = "button_updatedebt";
            button_updatedebt.Size = new System.Drawing.Size(91, 25);
            button_updatedebt.TabIndex = 18;
            button_updatedebt.Text = "更新负债";
            button_updatedebt.UseVisualStyleBackColor = true;
            // 
            // button_newdebt
            // 
            button_newdebt.Location = new System.Drawing.Point(602, 41);
            button_newdebt.Name = "button_newdebt";
            button_newdebt.Size = new System.Drawing.Size(91, 25);
            button_newdebt.TabIndex = 19;
            button_newdebt.Text = "新建负债";
            button_newdebt.UseVisualStyleBackColor = true;
            // 
            // listBox_debt
            // 
            listBox_debt.FormattingEnabled = true;
            listBox_debt.ItemHeight = 12;
            listBox_debt.Location = new System.Drawing.Point(126, 6);
            listBox_debt.Name = "listBox_debt";
            listBox_debt.ScrollAlwaysVisible = true;
            listBox_debt.Size = new System.Drawing.Size(141, 196);
            listBox_debt.TabIndex = 21;
            // 
            // tabPage_payout
            // 
            tabPage_payout.Controls.Add(dataGridView_payout);
            tabPage_payout.Controls.Add(button_savepayout);
            tabPage_payout.Controls.Add(label25);
            tabPage_payout.Controls.Add(numericUpDown_payout);
            tabPage_payout.Location = new System.Drawing.Point(4, 24);
            tabPage_payout.Name = "tabPage_payout";
            tabPage_payout.Padding = new Padding(3);
            tabPage_payout.Size = new System.Drawing.Size(721, 207);
            tabPage_payout.TabIndex = 2;
            tabPage_payout.Text = "支出";
            tabPage_payout.UseVisualStyleBackColor = true;
            // 
            // Column_payout_day
            // 
            Column_payout_day.HeaderText = "支出日";
            Column_payout_day.Name = "Column_payout_day";
            Column_payout_day.Width = 65;
            // 
            // Column_payout_volume
            // 
            Column_payout_volume.HeaderText = "支出金额";
            Column_payout_volume.Name = "Column_payout_volume";
            Column_payout_volume.Width = 80;
            // 
            // Column_payout_comment
            // 
            Column_payout_comment.HeaderText = "说明";
            Column_payout_comment.Name = "Column_payout_comment";
            Column_payout_comment.Width = 300;
            // 
            // dataGridView_payout
            // 
            dataGridView_payout.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_payout.Location = new System.Drawing.Point(129, 18);
            dataGridView_payout.Name = "dataGridView_payout";
            dataGridView_payout.RowTemplate.Height = 23;
            dataGridView_payout.Size = new System.Drawing.Size(486, 171);
            dataGridView_payout.TabIndex = 30;
            dataGridView_payout.ContextMenuStrip = contextMenuStrip1;
            dataGridView_payout.Columns.AddRange(new DataGridViewColumn[] {
            Column_payout_day,
            Column_payout_volume,
            Column_payout_comment});
            dataGridView_payout.CellMouseDown += new DataGridViewCellMouseEventHandler(dataGridView_CellMouseDown);
            // 
            // button_savepayout
            // 
            button_savepayout.Location = new System.Drawing.Point(630, 166);
            button_savepayout.Name = "button_savepayout";
            button_savepayout.Size = new System.Drawing.Size(75, 23);
            button_savepayout.TabIndex = 29;
            button_savepayout.Text = "保存";
            button_savepayout.UseVisualStyleBackColor = true;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            label25.Location = new System.Drawing.Point(18, 25);
            label25.Name = "label25";
            label25.Size = new System.Drawing.Size(84, 12);
            label25.TabIndex = 27;
            label25.Text = "本月支出(万)";
            // 
            // numericUpDown_payout
            // 
            numericUpDown_payout.Location = new System.Drawing.Point(20, 40);
            numericUpDown_payout.Name = "numericUpDown_payout";
            numericUpDown_payout.Enabled = false;
            numericUpDown_payout.Size = new System.Drawing.Size(87, 21);
            numericUpDown_payout.TabIndex = 26;
            numericUpDown_payout.TextAlign = HorizontalAlignment.Center;
            numericUpDown_payout.InterceptArrowKeys = false;
            numericUpDown_payout.Maximum = 100000;
            // 
            // tabPage_income
            // 
            tabPage_income.Controls.Add(dataGridView_income);
            tabPage_income.Controls.Add(button_saveincome);
            tabPage_income.Controls.Add(label26);
            tabPage_income.Controls.Add(numericUpDown_income);
            tabPage_income.Location = new System.Drawing.Point(4, 24);
            tabPage_income.Name = "tabPage_income";
            tabPage_income.Padding = new Padding(3);
            tabPage_income.Size = new System.Drawing.Size(721, 207);
            tabPage_income.TabIndex = 3;
            tabPage_income.Text = "收入";
            tabPage_income.UseVisualStyleBackColor = true;
            // 
            // Column_income_day
            // 
            Column_income_day.HeaderText = "收入日";
            Column_income_day.Name = "Column_income_day";
            Column_income_day.Width = 65;
            // 
            // Column_income_volume
            // 
            Column_income_volume.HeaderText = "收入金额";
            Column_income_volume.Name = "Column_income_volume";
            Column_income_volume.Width = 80;
            // 
            // Column_income_comment
            // 
            Column_income_comment.HeaderText = "说明";
            Column_income_comment.Name = "Column_income_comment";
            Column_income_comment.Width = 300;
            // 
            // dataGridView_income
            // 
            dataGridView_income.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_income.Location = new System.Drawing.Point(129, 18);
            dataGridView_income.Name = "dataGridView_income";
            dataGridView_income.RowTemplate.Height = 23;
            dataGridView_income.Size = new System.Drawing.Size(486, 171);
            dataGridView_income.TabIndex = 34;
            dataGridView_income.ContextMenuStrip = contextMenuStrip1;
            dataGridView_income.Columns.AddRange(new DataGridViewColumn[] {
            Column_income_day,
            Column_income_volume,
            Column_income_comment});
            dataGridView_income.CellMouseDown += new DataGridViewCellMouseEventHandler(dataGridView_CellMouseDown);
            // 
            // button_saveincome
            // 
            button_saveincome.Location = new System.Drawing.Point(630, 166);
            button_saveincome.Name = "button_saveincome";
            button_saveincome.Size = new System.Drawing.Size(75, 23);
            button_saveincome.TabIndex = 33;
            button_saveincome.Text = "保存";
            button_saveincome.UseVisualStyleBackColor = true;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            label26.Location = new System.Drawing.Point(18, 25);
            label26.Name = "label26";
            label26.Size = new System.Drawing.Size(84, 12);
            label26.TabIndex = 32;
            label26.Text = "本月收入(万)";
            // 
            // numericUpDown_income
            // 
            numericUpDown_income.Location = new System.Drawing.Point(20, 40);
            numericUpDown_income.Name = "numericUpDown_income";
            numericUpDown_income.Enabled = false;
            numericUpDown_income.Size = new System.Drawing.Size(87, 21);
            numericUpDown_income.TabIndex = 31;
            numericUpDown_income.TextAlign = HorizontalAlignment.Center;
            numericUpDown_income.InterceptArrowKeys = false;
            numericUpDown_income.Maximum = 100000;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] {
            ToolStripMenuItem_delete});
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(153, 48);
            // 
            // ToolStripMenuItem_delete
            // 
            ToolStripMenuItem_delete.Name = "ToolStripMenuItem_delete";
            ToolStripMenuItem_delete.Size = new Size(152, 22);
            ToolStripMenuItem_delete.Text = "删除";
            ToolStripMenuItem_delete.Click += new EventHandler(ToolStripMenuItem_delete_Click);
            
            contextMenuStrip1.ResumeLayout(false);
            GB.ResumeLayout(false);
            tabControl_month.ResumeLayout(false);
            tabPage_cash.ResumeLayout(false);
            tabPage_cash.PerformLayout();
            groupbox_cash.ResumeLayout(false);
            groupbox_cash.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(numericUpDown_volume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(numericUpDown_rate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(numericUpDown_cash)).EndInit();
            tabPage_invest.ResumeLayout(false);
            tabPage_invest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(numericUpDown_invest)).EndInit();
            groupBox_invest.ResumeLayout(false);
            groupBox_invest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(numericUpDown_volumeinvest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(numericUpDown_rateinvest)).EndInit();
            tabPage_debt.ResumeLayout(false);
            tabPage_debt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(numericUpDown_debt)).EndInit();
            groupBox_debt.ResumeLayout(false);
            groupBox_debt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(numericUpDown_volumedebt)).EndInit();
            tabPage_payout.ResumeLayout(false);
            tabPage_payout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(dataGridView_payout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(numericUpDown_payout)).EndInit();
            tabPage_income.ResumeLayout(false);
            tabPage_income.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(dataGridView_income)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(numericUpDown_income)).EndInit();
            ResumeLayout(false);
        }

        private void tabPage1_SizeChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Height = tabPage1.Height - 37;
        }

        private void DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                DataGridView dgv = sender as DataGridView;
                if (dgv.Rows[0].Cells[0].Value.ToString() == "+")
                {
                    dgv.Rows[0].Cells[0].Value = "-";
                    GroupBox gb;
                    GenerateGB(dgv.Rows[0].Cells[1].Value.ToString(), out gb);
                    flowLayoutPanel1.Controls.Add(gb);
                    flowLayoutPanel1.Controls.SetChildIndex(gb, flowLayoutPanel1.Controls.IndexOf(dgv) + 1);
                }
                else
                {
                    dgv.Rows[0].Cells[0].Value = "+";
                    flowLayoutPanel1.Controls.RemoveAt(flowLayoutPanel1.Controls.IndexOf(dgv) + 1);
                }
            }
        }

        private void ToolStripMenuItem_delete_Click(object sender, EventArgs e)
        {
            if (tempDGV.SelectedRows[0].IsNewRow) return;
            if (tempDGV.SelectedRows[0].ReadOnly)
            {
                MessageBox.Show("投资或负债资金流不可直接删除！请编辑投资负债信息！", "删除失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            tempDGV.Rows.Remove(tempDGV.SelectedRows[0]);
        }

        private void dataGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DataGridView dgv = sender as DataGridView;
                dgv.Rows[e.RowIndex].Selected = true;
                tempDGV = dgv;
            }
        }

        private void listBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void button_pre_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = new DateTime(dateTimePicker1.Value.Year - 1, 1, 1);
        }

        private void button_next_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = new DateTime(dateTimePicker1.Value.Year + 1, 1, 1);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
