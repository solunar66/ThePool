namespace ThePool
{
    partial class Form_Partner
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox_name = new System.Windows.Forms.ListBox();
            this.dataGridView_volume = new System.Windows.Forms.DataGridView();
            this.groupbox_info = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_phone = new System.Windows.Forms.TextBox();
            this.textBox_comment = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.button_load = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button_quit = new System.Windows.Forms.Button();
            this.Column_volume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_cycle = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column_start = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_end = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_volume)).BeginInit();
            this.groupbox_info.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox_name
            // 
            this.listBox_name.FormattingEnabled = true;
            this.listBox_name.ItemHeight = 12;
            this.listBox_name.Location = new System.Drawing.Point(12, 22);
            this.listBox_name.Name = "listBox_name";
            this.listBox_name.ScrollAlwaysVisible = true;
            this.listBox_name.Size = new System.Drawing.Size(100, 280);
            this.listBox_name.TabIndex = 0;
            // 
            // dataGridView_volume
            // 
            this.dataGridView_volume.AllowUserToResizeRows = false;
            this.dataGridView_volume.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_volume.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_volume,
            this.Column_rate,
            this.Column_cycle,
            this.Column_start,
            this.Column_end,
            this.Column_comment});
            this.dataGridView_volume.Location = new System.Drawing.Point(6, 116);
            this.dataGridView_volume.MultiSelect = false;
            this.dataGridView_volume.Name = "dataGridView_volume";
            this.dataGridView_volume.RowTemplate.Height = 23;
            this.dataGridView_volume.Size = new System.Drawing.Size(436, 149);
            this.dataGridView_volume.TabIndex = 1;
            this.dataGridView_volume.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView1_CellValidating);
            // 
            // groupbox_info
            // 
            this.groupbox_info.Controls.Add(this.button3);
            this.groupbox_info.Controls.Add(this.button2);
            this.groupbox_info.Controls.Add(this.button1);
            this.groupbox_info.Controls.Add(this.dataGridView_volume);
            this.groupbox_info.Controls.Add(this.label3);
            this.groupbox_info.Controls.Add(this.label7);
            this.groupbox_info.Controls.Add(this.label1);
            this.groupbox_info.Controls.Add(this.textBox_phone);
            this.groupbox_info.Controls.Add(this.textBox_comment);
            this.groupbox_info.Controls.Add(this.textBox_name);
            this.groupbox_info.Location = new System.Drawing.Point(159, 5);
            this.groupbox_info.Name = "groupbox_info";
            this.groupbox_info.Size = new System.Drawing.Size(450, 297);
            this.groupbox_info.TabIndex = 2;
            this.groupbox_info.TabStop = false;
            this.groupbox_info.Text = "股东信息";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(103, 270);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 21);
            this.button3.TabIndex = 5;
            this.button3.Text = "删除股东";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 270);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 21);
            this.button2.TabIndex = 5;
            this.button2.Text = "新建股东";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(351, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 21);
            this.button1.TabIndex = 5;
            this.button1.Text = "保存股东信息";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "联系电话";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 3;
            this.label7.Text = "备注";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "姓名";
            // 
            // textBox_phone
            // 
            this.textBox_phone.Location = new System.Drawing.Point(128, 41);
            this.textBox_phone.MaxLength = 11;
            this.textBox_phone.Name = "textBox_phone";
            this.textBox_phone.Size = new System.Drawing.Size(100, 21);
            this.textBox_phone.TabIndex = 2;
            // 
            // textBox_comment
            // 
            this.textBox_comment.Location = new System.Drawing.Point(6, 84);
            this.textBox_comment.MaxLength = 8;
            this.textBox_comment.Name = "textBox_comment";
            this.textBox_comment.Size = new System.Drawing.Size(436, 21);
            this.textBox_comment.TabIndex = 2;
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(6, 41);
            this.textBox_name.MaxLength = 8;
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(100, 21);
            this.textBox_name.TabIndex = 2;
            // 
            // button_load
            // 
            this.button_load.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_load.Location = new System.Drawing.Point(118, 144);
            this.button_load.Name = "button_load";
            this.button_load.Size = new System.Drawing.Size(35, 28);
            this.button_load.TabIndex = 3;
            this.button_load.Text = ">>";
            this.button_load.UseVisualStyleBackColor = true;
            this.button_load.Click += new System.EventHandler(this.button_load_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "股东列表";
            // 
            // button_quit
            // 
            this.button_quit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_quit.Location = new System.Drawing.Point(510, 307);
            this.button_quit.Name = "button_quit";
            this.button_quit.Size = new System.Drawing.Size(91, 21);
            this.button_quit.TabIndex = 8;
            this.button_quit.Text = "退 出";
            this.button_quit.UseVisualStyleBackColor = true;
            // 
            // Column_volume
            // 
            this.Column_volume.HeaderText = "资金(万)";
            this.Column_volume.Name = "Column_volume";
            this.Column_volume.Width = 80;
            // 
            // Column_rate
            // 
            this.Column_rate.HeaderText = "利率(%)";
            this.Column_rate.Name = "Column_rate";
            this.Column_rate.Width = 75;
            // 
            // Column_cycle
            // 
            this.Column_cycle.HeaderText = "付息周期";
            this.Column_cycle.Items.AddRange(new object[] {
            "不定期",
            "每月",
            "每季度",
            "每半年",
            "每年"});
            this.Column_cycle.Name = "Column_cycle";
            this.Column_cycle.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column_cycle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column_cycle.Width = 80;
            // 
            // Column_start
            // 
            this.Column_start.HeaderText = "起始时间";
            this.Column_start.Name = "Column_start";
            this.Column_start.Width = 80;
            // 
            // Column_end
            // 
            this.Column_end.HeaderText = "终止时间";
            this.Column_end.Name = "Column_end";
            this.Column_end.Width = 80;
            // 
            // Column_comment
            // 
            this.Column_comment.HeaderText = "备注";
            this.Column_comment.Name = "Column_comment";
            this.Column_comment.Width = 150;
            // 
            // Form_Partner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_quit;
            this.ClientSize = new System.Drawing.Size(619, 332);
            this.Controls.Add(this.button_quit);
            this.Controls.Add(this.button_load);
            this.Controls.Add(this.groupbox_info);
            this.Controls.Add(this.listBox_name);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Partner";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "股东信息";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_volume)).EndInit();
            this.groupbox_info.ResumeLayout(false);
            this.groupbox_info.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_name;
        private System.Windows.Forms.DataGridView dataGridView_volume;
        private System.Windows.Forms.GroupBox groupbox_info;
        private System.Windows.Forms.Button button_load;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_phone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_comment;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_quit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_volume;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_rate;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column_cycle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_start;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_end;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_comment;
    }
}