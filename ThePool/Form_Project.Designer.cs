namespace ThePool
{
    partial class Form_Project
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
            this.groupbox_info = new System.Windows.Forms.GroupBox();
            this.dateTimePicker_end = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_start = new System.Windows.Forms.DateTimePicker();
            this.comboBox_cycle = new System.Windows.Forms.ComboBox();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_new = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.numericUpDown_rate = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_phone = new System.Windows.Forms.TextBox();
            this.textBox_comment = new System.Windows.Forms.TextBox();
            this.textBox_contact = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.listBox_name = new System.Windows.Forms.ListBox();
            this.button_load = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button_quit = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.groupbox_info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_rate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupbox_info
            // 
            this.groupbox_info.Controls.Add(this.dateTimePicker_end);
            this.groupbox_info.Controls.Add(this.dateTimePicker_start);
            this.groupbox_info.Controls.Add(this.comboBox_cycle);
            this.groupbox_info.Controls.Add(this.button_delete);
            this.groupbox_info.Controls.Add(this.button_new);
            this.groupbox_info.Controls.Add(this.button_save);
            this.groupbox_info.Controls.Add(this.numericUpDown1);
            this.groupbox_info.Controls.Add(this.numericUpDown_rate);
            this.groupbox_info.Controls.Add(this.label3);
            this.groupbox_info.Controls.Add(this.label10);
            this.groupbox_info.Controls.Add(this.label5);
            this.groupbox_info.Controls.Add(this.label2);
            this.groupbox_info.Controls.Add(this.label7);
            this.groupbox_info.Controls.Add(this.label4);
            this.groupbox_info.Controls.Add(this.label8);
            this.groupbox_info.Controls.Add(this.label11);
            this.groupbox_info.Controls.Add(this.label9);
            this.groupbox_info.Controls.Add(this.label1);
            this.groupbox_info.Controls.Add(this.textBox_phone);
            this.groupbox_info.Controls.Add(this.textBox_comment);
            this.groupbox_info.Controls.Add(this.textBox_contact);
            this.groupbox_info.Controls.Add(this.textBox_name);
            this.groupbox_info.Location = new System.Drawing.Point(159, 6);
            this.groupbox_info.Name = "groupbox_info";
            this.groupbox_info.Size = new System.Drawing.Size(450, 266);
            this.groupbox_info.TabIndex = 5;
            this.groupbox_info.TabStop = false;
            this.groupbox_info.Text = "项目信息";
            // 
            // dateTimePicker_end
            // 
            this.dateTimePicker_end.CustomFormat = "yyyy - MM - dd";
            this.dateTimePicker_end.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_end.Location = new System.Drawing.Point(121, 146);
            this.dateTimePicker_end.Name = "dateTimePicker_end";
            this.dateTimePicker_end.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker_end.TabIndex = 7;
            // 
            // dateTimePicker_start
            // 
            this.dateTimePicker_start.CustomFormat = "yyyy - MM - dd";
            this.dateTimePicker_start.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_start.Location = new System.Drawing.Point(6, 146);
            this.dateTimePicker_start.Name = "dateTimePicker_start";
            this.dateTimePicker_start.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker_start.TabIndex = 7;
            // 
            // comboBox_cycle
            // 
            this.comboBox_cycle.FormattingEnabled = true;
            this.comboBox_cycle.Items.AddRange(new object[] {
            "不定期",
            "每月",
            "每季度",
            "每半年",
            "每年"});
            this.comboBox_cycle.Location = new System.Drawing.Point(236, 98);
            this.comboBox_cycle.Name = "comboBox_cycle";
            this.comboBox_cycle.Size = new System.Drawing.Size(100, 21);
            this.comboBox_cycle.TabIndex = 6;
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(105, 237);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(91, 23);
            this.button_delete.TabIndex = 5;
            this.button_delete.Text = "删除项目";
            this.button_delete.UseVisualStyleBackColor = true;
            // 
            // button_new
            // 
            this.button_new.Location = new System.Drawing.Point(8, 237);
            this.button_new.Name = "button_new";
            this.button_new.Size = new System.Drawing.Size(91, 23);
            this.button_new.TabIndex = 5;
            this.button_new.Text = "新建项目";
            this.button_new.UseVisualStyleBackColor = true;
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(353, 237);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(91, 23);
            this.button_save.TabIndex = 5;
            this.button_save.Text = "保存项目信息";
            this.button_save.UseVisualStyleBackColor = true;
            // 
            // numericUpDown_rate
            // 
            this.numericUpDown_rate.Location = new System.Drawing.Point(121, 98);
            this.numericUpDown_rate.Name = "numericUpDown_rate";
            this.numericUpDown_rate.Size = new System.Drawing.Size(85, 20);
            this.numericUpDown_rate.TabIndex = 4;
            this.numericUpDown_rate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "联系电话";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(207, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "回报率";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "备注";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(121, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "联系人";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(236, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "付息周期";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(104, 150);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "至";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "项目周期";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "名称";
            // 
            // textBox_phone
            // 
            this.textBox_phone.Location = new System.Drawing.Point(236, 44);
            this.textBox_phone.MaxLength = 11;
            this.textBox_phone.Name = "textBox_phone";
            this.textBox_phone.Size = new System.Drawing.Size(100, 20);
            this.textBox_phone.TabIndex = 2;
            // 
            // textBox_comment
            // 
            this.textBox_comment.Location = new System.Drawing.Point(6, 193);
            this.textBox_comment.MaxLength = 8;
            this.textBox_comment.Name = "textBox_comment";
            this.textBox_comment.Size = new System.Drawing.Size(436, 20);
            this.textBox_comment.TabIndex = 2;
            // 
            // textBox_contact
            // 
            this.textBox_contact.Location = new System.Drawing.Point(121, 44);
            this.textBox_contact.MaxLength = 8;
            this.textBox_contact.Name = "textBox_contact";
            this.textBox_contact.Size = new System.Drawing.Size(100, 20);
            this.textBox_contact.TabIndex = 2;
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(6, 44);
            this.textBox_name.MaxLength = 8;
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(100, 20);
            this.textBox_name.TabIndex = 2;
            // 
            // listBox_name
            // 
            this.listBox_name.FormattingEnabled = true;
            this.listBox_name.Location = new System.Drawing.Point(12, 25);
            this.listBox_name.Name = "listBox_name";
            this.listBox_name.ScrollAlwaysVisible = true;
            this.listBox_name.Size = new System.Drawing.Size(100, 212);
            this.listBox_name.TabIndex = 4;
            // 
            // button_load
            // 
            this.button_load.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_load.Location = new System.Drawing.Point(118, 119);
            this.button_load.Name = "button_load";
            this.button_load.Size = new System.Drawing.Size(35, 30);
            this.button_load.TabIndex = 6;
            this.button_load.Text = ">>";
            this.button_load.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "项目列表";
            // 
            // button_quit
            // 
            this.button_quit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_quit.Location = new System.Drawing.Point(511, 278);
            this.button_quit.Name = "button_quit";
            this.button_quit.Size = new System.Drawing.Size(91, 23);
            this.button_quit.TabIndex = 7;
            this.button_quit.Text = "退 出";
            this.button_quit.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "资金量(万)";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(6, 98);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(100, 20);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form_Project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_quit;
            this.ClientSize = new System.Drawing.Size(617, 313);
            this.Controls.Add(this.button_quit);
            this.Controls.Add(this.groupbox_info);
            this.Controls.Add(this.listBox_name);
            this.Controls.Add(this.button_load);
            this.Controls.Add(this.label6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Project";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "投资项目";
            this.groupbox_info.ResumeLayout(false);
            this.groupbox_info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_rate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupbox_info;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_new;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.NumericUpDown numericUpDown_rate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_phone;
        private System.Windows.Forms.TextBox textBox_comment;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.ListBox listBox_name;
        private System.Windows.Forms.Button button_load;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_contact;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_cycle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button_quit;
        private System.Windows.Forms.DateTimePicker dateTimePicker_end;
        private System.Windows.Forms.DateTimePicker dateTimePicker_start;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label10;

    }
}