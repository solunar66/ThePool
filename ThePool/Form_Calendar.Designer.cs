namespace ThePool
{
    partial class Form_Calendar
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
            this.components = new System.ComponentModel.Container();
            this.groupBox_info = new System.Windows.Forms.GroupBox();
            this.dataGridView_info = new System.Windows.Forms.DataGridView();
            this.Column_type = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column_volume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_info = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItem_delete = new System.Windows.Forms.ToolStripMenuItem();
            this.button_quit = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.groupBox_info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_info)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_info
            // 
            this.groupBox_info.Controls.Add(this.dataGridView_info);
            this.groupBox_info.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox_info.Location = new System.Drawing.Point(12, 197);
            this.groupBox_info.Name = "groupBox_info";
            this.groupBox_info.Size = new System.Drawing.Size(370, 230);
            this.groupBox_info.TabIndex = 0;
            this.groupBox_info.TabStop = false;
            this.groupBox_info.Text = "date";
            // 
            // dataGridView_info
            // 
            this.dataGridView_info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_info.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_type,
            this.Column_volume,
            this.Column_info});
            this.dataGridView_info.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView_info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_info.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView_info.Location = new System.Drawing.Point(3, 16);
            this.dataGridView_info.Name = "dataGridView_info";
            this.dataGridView_info.Size = new System.Drawing.Size(364, 211);
            this.dataGridView_info.TabIndex = 0;
            this.dataGridView_info.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDown);
            // 
            // Column_type
            // 
            this.Column_type.HeaderText = "收支";
            this.Column_type.Items.AddRange(new object[] {
            "收入",
            "支出"});
            this.Column_type.Name = "Column_type";
            this.Column_type.Width = 60;
            // 
            // Column_volume
            // 
            this.Column_volume.HeaderText = "金额(万)";
            this.Column_volume.Name = "Column_volume";
            this.Column_volume.Width = 80;
            // 
            // Column_info
            // 
            this.Column_info.HeaderText = "描述";
            this.Column_info.Name = "Column_info";
            this.Column_info.Width = 150;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_delete});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(147, 26);
            // 
            // ToolStripMenuItem_delete
            // 
            this.ToolStripMenuItem_delete.Name = "ToolStripMenuItem_delete";
            this.ToolStripMenuItem_delete.Size = new System.Drawing.Size(146, 22);
            this.ToolStripMenuItem_delete.Text = "删除当前记录";
            this.ToolStripMenuItem_delete.Click += new System.EventHandler(this.ToolStripMenuItem_delete_Click);
            // 
            // button_quit
            // 
            this.button_quit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_quit.Location = new System.Drawing.Point(307, 436);
            this.button_quit.Name = "button_quit";
            this.button_quit.Size = new System.Drawing.Size(75, 23);
            this.button_quit.TabIndex = 1;
            this.button_quit.Text = "退 出";
            this.button_quit.UseVisualStyleBackColor = true;
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(12, 436);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 23);
            this.button_save.TabIndex = 1;
            this.button_save.Text = "保 存";
            this.button_save.UseVisualStyleBackColor = true;
            // 
            // Form_Calendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_quit;
            this.ClientSize = new System.Drawing.Size(394, 467);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.button_quit);
            this.Controls.Add(this.groupBox_info);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Calendar";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form_Calendar";
            this.groupBox_info.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_info)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_info;
        private System.Windows.Forms.DataGridView dataGridView_info;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_delete;
        private System.Windows.Forms.Button button_quit;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_volume;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_info;
        private System.Windows.Forms.Button button_save;

    }
}