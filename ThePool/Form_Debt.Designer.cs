namespace ThePool
{
    partial class Form_Debt
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
            this.dateTimePicker_end = new System.Windows.Forms.DateTimePicker();
            this.groupbox_info = new System.Windows.Forms.GroupBox();
            this.dateTimePicker_start = new System.Windows.Forms.DateTimePicker();
            this.comboBox_cycle = new System.Windows.Forms.ComboBox();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_new = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.numericUpDown_volume = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_comment = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.button_load = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.listBox_name = new System.Windows.Forms.ListBox();
            this.button_quit = new System.Windows.Forms.Button();
            this.groupbox_info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_volume)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker_end
            // 
            this.dateTimePicker_end.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker_end.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_end.Location = new System.Drawing.Point(129, 92);
            this.dateTimePicker_end.Name = "dateTimePicker_end";
            this.dateTimePicker_end.Size = new System.Drawing.Size(100, 21);
            this.dateTimePicker_end.TabIndex = 7;
            // 
            // groupbox_info
            // 
            this.groupbox_info.Controls.Add(this.dateTimePicker_end);
            this.groupbox_info.Controls.Add(this.dateTimePicker_start);
            this.groupbox_info.Controls.Add(this.comboBox_cycle);
            this.groupbox_info.Controls.Add(this.button_delete);
            this.groupbox_info.Controls.Add(this.button_new);
            this.groupbox_info.Controls.Add(this.button_save);
            this.groupbox_info.Controls.Add(this.numericUpDown_volume);
            this.groupbox_info.Controls.Add(this.label10);
            this.groupbox_info.Controls.Add(this.label7);
            this.groupbox_info.Controls.Add(this.label8);
            this.groupbox_info.Controls.Add(this.label11);
            this.groupbox_info.Controls.Add(this.label9);
            this.groupbox_info.Controls.Add(this.label1);
            this.groupbox_info.Controls.Add(this.textBox_comment);
            this.groupbox_info.Controls.Add(this.textBox_name);
            this.groupbox_info.Location = new System.Drawing.Point(159, 12);
            this.groupbox_info.Name = "groupbox_info";
            this.groupbox_info.Size = new System.Drawing.Size(450, 213);
            this.groupbox_info.TabIndex = 10;
            this.groupbox_info.TabStop = false;
            this.groupbox_info.Text = "负债信息";
            // 
            // dateTimePicker_start
            // 
            this.dateTimePicker_start.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker_start.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_start.Location = new System.Drawing.Point(6, 92);
            this.dateTimePicker_start.Name = "dateTimePicker_start";
            this.dateTimePicker_start.Size = new System.Drawing.Size(100, 21);
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
            this.comboBox_cycle.Location = new System.Drawing.Point(252, 40);
            this.comboBox_cycle.Name = "comboBox_cycle";
            this.comboBox_cycle.Size = new System.Drawing.Size(100, 20);
            this.comboBox_cycle.TabIndex = 6;
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(105, 186);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(91, 21);
            this.button_delete.TabIndex = 5;
            this.button_delete.Text = "删除负债";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_new
            // 
            this.button_new.Location = new System.Drawing.Point(8, 186);
            this.button_new.Name = "button_new";
            this.button_new.Size = new System.Drawing.Size(91, 21);
            this.button_new.TabIndex = 5;
            this.button_new.Text = "新建负债";
            this.button_new.UseVisualStyleBackColor = true;
            this.button_new.Click += new System.EventHandler(this.button_new_Click);
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(353, 186);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(91, 21);
            this.button_save.TabIndex = 5;
            this.button_save.Text = "保存负债信息";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // numericUpDown_volume
            // 
            this.numericUpDown_volume.Location = new System.Drawing.Point(129, 41);
            this.numericUpDown_volume.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_volume.Name = "numericUpDown_volume";
            this.numericUpDown_volume.Size = new System.Drawing.Size(100, 21);
            this.numericUpDown_volume.TabIndex = 4;
            this.numericUpDown_volume.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(129, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 3;
            this.label10.Text = "金额(万)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 3;
            this.label7.Text = "备注";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(252, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 3;
            this.label8.Text = "周期";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(109, 95);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 12);
            this.label11.TabIndex = 3;
            this.label11.Text = "至";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 3;
            this.label9.Text = "项目周期";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "名称";
            // 
            // textBox_comment
            // 
            this.textBox_comment.Location = new System.Drawing.Point(6, 147);
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
            this.button_load.Location = new System.Drawing.Point(118, 116);
            this.button_load.Name = "button_load";
            this.button_load.Size = new System.Drawing.Size(35, 28);
            this.button_load.TabIndex = 11;
            this.button_load.Text = ">>";
            this.button_load.UseVisualStyleBackColor = true;
            this.button_load.Click += new System.EventHandler(this.button_load_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "负债列表";
            // 
            // listBox_name
            // 
            this.listBox_name.FormattingEnabled = true;
            this.listBox_name.ItemHeight = 12;
            this.listBox_name.Location = new System.Drawing.Point(12, 29);
            this.listBox_name.Name = "listBox_name";
            this.listBox_name.ScrollAlwaysVisible = true;
            this.listBox_name.Size = new System.Drawing.Size(100, 196);
            this.listBox_name.TabIndex = 9;
            // 
            // button_quit
            // 
            this.button_quit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_quit.Location = new System.Drawing.Point(512, 231);
            this.button_quit.Name = "button_quit";
            this.button_quit.Size = new System.Drawing.Size(91, 21);
            this.button_quit.TabIndex = 12;
            this.button_quit.Text = "退 出";
            this.button_quit.UseVisualStyleBackColor = true;
            // 
            // Form_Debt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_quit;
            this.ClientSize = new System.Drawing.Size(624, 262);
            this.Controls.Add(this.groupbox_info);
            this.Controls.Add(this.button_load);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listBox_name);
            this.Controls.Add(this.button_quit);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Debt";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "负债支出";
            this.groupbox_info.ResumeLayout(false);
            this.groupbox_info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_volume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker_end;
        private System.Windows.Forms.GroupBox groupbox_info;
        private System.Windows.Forms.DateTimePicker dateTimePicker_start;
        private System.Windows.Forms.ComboBox comboBox_cycle;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_new;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.NumericUpDown numericUpDown_volume;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_comment;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Button button_load;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBox_name;
        private System.Windows.Forms.Button button_quit;
    }
}