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
            this.button_eject = new System.Windows.Forms.Button();
            this.button_inject = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_phone = new System.Windows.Forms.TextBox();
            this.textBox_comment = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_new = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.button_load = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button_quit = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_volume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_cycle = new System.Windows.Forms.DataGridViewComboBoxColumn();
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
            this.Column_comment});
            this.dataGridView_volume.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView_volume.Location = new System.Drawing.Point(6, 116);
            this.dataGridView_volume.MultiSelect = false;
            this.dataGridView_volume.Name = "dataGridView_volume";
            this.dataGridView_volume.RowTemplate.Height = 23;
            this.dataGridView_volume.Size = new System.Drawing.Size(436, 175);
            this.dataGridView_volume.TabIndex = 1;
            // 
            // groupbox_info
            // 
            this.groupbox_info.Controls.Add(this.button_eject);
            this.groupbox_info.Controls.Add(this.button_inject);
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
            // button_eject
            // 
            this.button_eject.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_eject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_eject.Location = new System.Drawing.Point(351, 266);
            this.button_eject.Name = "button_eject";
            this.button_eject.Size = new System.Drawing.Size(91, 25);
            this.button_eject.TabIndex = 5;
            this.button_eject.Text = "撤 资";
            this.button_eject.UseVisualStyleBackColor = true;
            this.button_eject.Visible = false;
            this.button_eject.Click += new System.EventHandler(this.button_eject_Click);
            // 
            // button_inject
            // 
            this.button_inject.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_inject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_inject.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_inject.Location = new System.Drawing.Point(254, 266);
            this.button_inject.Name = "button_inject";
            this.button_inject.Size = new System.Drawing.Size(91, 25);
            this.button_inject.TabIndex = 5;
            this.button_inject.Text = "注 资";
            this.button_inject.UseVisualStyleBackColor = true;
            this.button_inject.Visible = false;
            this.button_inject.Click += new System.EventHandler(this.button_inject_Click);
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
            this.textBox_name.MaxLength = 16;
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(100, 21);
            this.textBox_name.TabIndex = 2;
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(109, 308);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(91, 25);
            this.button_delete.TabIndex = 5;
            this.button_delete.Text = "删除股东";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_new
            // 
            this.button_new.Location = new System.Drawing.Point(12, 307);
            this.button_new.Name = "button_new";
            this.button_new.Size = new System.Drawing.Size(91, 25);
            this.button_new.TabIndex = 5;
            this.button_new.Text = "新建股东";
            this.button_new.UseVisualStyleBackColor = true;
            this.button_new.Click += new System.EventHandler(this.button_new_Click);
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(413, 307);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(91, 25);
            this.button_save.TabIndex = 5;
            this.button_save.Text = "保存股东信息";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_load
            // 
            this.button_load.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_load.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_load.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_load.Location = new System.Drawing.Point(118, 22);
            this.button_load.Name = "button_load";
            this.button_load.Size = new System.Drawing.Size(35, 280);
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
            this.button_quit.Size = new System.Drawing.Size(91, 25);
            this.button_quit.TabIndex = 8;
            this.button_quit.Text = "退 出";
            this.button_quit.UseVisualStyleBackColor = true;
            this.button_quit.Click += new System.EventHandler(this.button_quit_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "资金(万)";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 80;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "利率";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 60;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "备注";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // Column_volume
            // 
            this.Column_volume.HeaderText = "资金(万)";
            this.Column_volume.Name = "Column_volume";
            this.Column_volume.Width = 80;
            // 
            // Column_rate
            // 
            this.Column_rate.HeaderText = "年化利率";
            this.Column_rate.Name = "Column_rate";
            this.Column_rate.Width = 80;
            // 
            // Column_cycle
            // 
            this.Column_cycle.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
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
            // Column_comment
            // 
            this.Column_comment.HeaderText = "备注";
            this.Column_comment.Name = "Column_comment";
            this.Column_comment.Width = 300;
            // 
            // Form_Partner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_quit;
            this.ClientSize = new System.Drawing.Size(619, 339);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_quit);
            this.Controls.Add(this.button_new);
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
            this.Load += new System.EventHandler(this.Form_Partner_Load);
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
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_new;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_quit;
        private System.Windows.Forms.Button button_eject;
        private System.Windows.Forms.Button button_inject;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_volume;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_rate;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column_cycle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_comment;
    }
}