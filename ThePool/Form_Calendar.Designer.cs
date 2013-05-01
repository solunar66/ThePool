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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox_info = new System.Windows.Forms.GroupBox();
            this.dataGridView_info = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItem_delete = new System.Windows.Forms.ToolStripMenuItem();
            this.button_quit = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.flowLayoutPanel_out = new System.Windows.Forms.FlowLayoutPanel();
            this.label_out = new System.Windows.Forms.Label();
            this.flowLayoutPanel_in = new System.Windows.Forms.FlowLayoutPanel();
            this.label_in = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_type = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column_volume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_info = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox_info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_info)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.flowLayoutPanel_out.SuspendLayout();
            this.flowLayoutPanel_in.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_info
            // 
            this.groupBox_info.Controls.Add(this.dataGridView_info);
            this.groupBox_info.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox_info.Location = new System.Drawing.Point(12, 241);
            this.groupBox_info.Name = "groupBox_info";
            this.groupBox_info.Size = new System.Drawing.Size(370, 201);
            this.groupBox_info.TabIndex = 0;
            this.groupBox_info.TabStop = false;
            this.groupBox_info.Text = "请选择日期";
            // 
            // dataGridView_info
            // 
            this.dataGridView_info.AllowUserToResizeRows = false;
            this.dataGridView_info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_info.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_type,
            this.Column_volume,
            this.Column_info});
            this.dataGridView_info.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView_info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_info.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView_info.Location = new System.Drawing.Point(3, 17);
            this.dataGridView_info.MultiSelect = false;
            this.dataGridView_info.Name = "dataGridView_info";
            this.dataGridView_info.RowTemplate.Height = 23;
            this.dataGridView_info.Size = new System.Drawing.Size(364, 181);
            this.dataGridView_info.TabIndex = 0;
            this.dataGridView_info.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_delete});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(149, 26);
            // 
            // ToolStripMenuItem_delete
            // 
            this.ToolStripMenuItem_delete.Name = "ToolStripMenuItem_delete";
            this.ToolStripMenuItem_delete.Size = new System.Drawing.Size(148, 22);
            this.ToolStripMenuItem_delete.Text = "删除当前记录";
            this.ToolStripMenuItem_delete.Click += new System.EventHandler(this.ToolStripMenuItem_delete_Click);
            // 
            // button_quit
            // 
            this.button_quit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_quit.Location = new System.Drawing.Point(307, 450);
            this.button_quit.Name = "button_quit";
            this.button_quit.Size = new System.Drawing.Size(75, 21);
            this.button_quit.TabIndex = 1;
            this.button_quit.Text = "退 出";
            this.button_quit.UseVisualStyleBackColor = true;
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(12, 450);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 21);
            this.button_save.TabIndex = 1;
            this.button_save.Text = "保 存";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // flowLayoutPanel_out
            // 
            this.flowLayoutPanel_out.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.flowLayoutPanel_out.AutoScroll = true;
            this.flowLayoutPanel_out.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel_out.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel_out.Controls.Add(this.label_out);
            this.flowLayoutPanel_out.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flowLayoutPanel_out.ForeColor = System.Drawing.Color.LightGreen;
            this.flowLayoutPanel_out.Location = new System.Drawing.Point(12, 217);
            this.flowLayoutPanel_out.Name = "flowLayoutPanel_out";
            this.flowLayoutPanel_out.Size = new System.Drawing.Size(370, 18);
            this.flowLayoutPanel_out.TabIndex = 2;
            // 
            // label_out
            // 
            this.label_out.AutoSize = true;
            this.label_out.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_out.Location = new System.Drawing.Point(3, 0);
            this.label_out.Name = "label_out";
            this.label_out.Size = new System.Drawing.Size(84, 12);
            this.label_out.TabIndex = 0;
            this.label_out.Text = "本月支出日: ";
            // 
            // flowLayoutPanel_in
            // 
            this.flowLayoutPanel_in.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.flowLayoutPanel_in.AutoScroll = true;
            this.flowLayoutPanel_in.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel_in.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel_in.Controls.Add(this.label_in);
            this.flowLayoutPanel_in.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flowLayoutPanel_in.ForeColor = System.Drawing.Color.Red;
            this.flowLayoutPanel_in.Location = new System.Drawing.Point(12, 197);
            this.flowLayoutPanel_in.Name = "flowLayoutPanel_in";
            this.flowLayoutPanel_in.Size = new System.Drawing.Size(370, 18);
            this.flowLayoutPanel_in.TabIndex = 2;
            // 
            // label_in
            // 
            this.label_in.AutoSize = true;
            this.label_in.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_in.Location = new System.Drawing.Point(3, 0);
            this.label_in.Name = "label_in";
            this.label_in.Size = new System.Drawing.Size(84, 12);
            this.label_in.TabIndex = 0;
            this.label_in.Text = "本月收入日: ";
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn1.HeaderText = "金额(万)";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 80;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "描述";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column_volume.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column_volume.HeaderText = "金额(万)";
            this.Column_volume.Name = "Column_volume";
            this.Column_volume.Width = 80;
            // 
            // Column_info
            // 
            this.Column_info.HeaderText = "描述";
            this.Column_info.Name = "Column_info";
            this.Column_info.Width = 180;
            // 
            // Form_Calendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_quit;
            this.ClientSize = new System.Drawing.Size(394, 478);
            this.Controls.Add(this.flowLayoutPanel_in);
            this.Controls.Add(this.flowLayoutPanel_out);
            this.Controls.Add(this.groupBox_info);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.button_quit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Calendar";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form_Calendar";
            this.Load += new System.EventHandler(this.Form_Calendar_Load);
            this.groupBox_info.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_info)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.flowLayoutPanel_out.ResumeLayout(false);
            this.flowLayoutPanel_out.PerformLayout();
            this.flowLayoutPanel_in.ResumeLayout(false);
            this.flowLayoutPanel_in.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_info;
        private System.Windows.Forms.DataGridView dataGridView_info;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_delete;
        private System.Windows.Forms.Button button_quit;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_out;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_in;
        private System.Windows.Forms.Label label_out;
        private System.Windows.Forms.Label label_in;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_volume;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_info;

    }
}