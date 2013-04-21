namespace ThePool
{
    partial class Form_Main
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_partner = new System.Windows.Forms.Button();
            this.button_invest = new System.Windows.Forms.Button();
            this.button_quit = new System.Windows.Forms.Button();
            this.button_debt = new System.Windows.Forms.Button();
            this.dateTimePicker_year = new System.Windows.Forms.DateTimePicker();
            this.button_pre = new System.Windows.Forms.Button();
            this.button_next = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(596, 272);
            this.panel1.TabIndex = 0;
            // 
            // button_partner
            // 
            this.button_partner.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_partner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_partner.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_partner.Location = new System.Drawing.Point(12, 312);
            this.button_partner.Name = "button_partner";
            this.button_partner.Size = new System.Drawing.Size(100, 32);
            this.button_partner.TabIndex = 1;
            this.button_partner.Text = "股 东";
            this.button_partner.UseVisualStyleBackColor = true;
            this.button_partner.Click += new System.EventHandler(this.button_partner_Click);
            // 
            // button_invest
            // 
            this.button_invest.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_invest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_invest.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_invest.Location = new System.Drawing.Point(118, 312);
            this.button_invest.Name = "button_invest";
            this.button_invest.Size = new System.Drawing.Size(100, 32);
            this.button_invest.TabIndex = 1;
            this.button_invest.Text = "投 资";
            this.button_invest.UseVisualStyleBackColor = true;
            this.button_invest.Click += new System.EventHandler(this.button_invest_Click);
            // 
            // button_quit
            // 
            this.button_quit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_quit.Location = new System.Drawing.Point(484, 312);
            this.button_quit.Name = "button_quit";
            this.button_quit.Size = new System.Drawing.Size(100, 32);
            this.button_quit.TabIndex = 1;
            this.button_quit.Text = "退 出";
            this.button_quit.UseVisualStyleBackColor = true;
            this.button_quit.Click += new System.EventHandler(this.button_quit_Click);
            // 
            // button_debt
            // 
            this.button_debt.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_debt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_debt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_debt.Location = new System.Drawing.Point(224, 312);
            this.button_debt.Name = "button_debt";
            this.button_debt.Size = new System.Drawing.Size(100, 32);
            this.button_debt.TabIndex = 1;
            this.button_debt.Text = "负 债";
            this.button_debt.UseVisualStyleBackColor = true;
            this.button_debt.Click += new System.EventHandler(this.button_debt_Click);
            // 
            // dateTimePicker_year
            // 
            this.dateTimePicker_year.CustomFormat = "yyyy年";
            this.dateTimePicker_year.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_year.Location = new System.Drawing.Point(267, 7);
            this.dateTimePicker_year.Name = "dateTimePicker_year";
            this.dateTimePicker_year.ShowUpDown = true;
            this.dateTimePicker_year.Size = new System.Drawing.Size(62, 21);
            this.dateTimePicker_year.TabIndex = 2;
            this.dateTimePicker_year.ValueChanged += new System.EventHandler(this.dateTimePicker_year_ValueChanged);
            // 
            // button_pre
            // 
            this.button_pre.Location = new System.Drawing.Point(186, 5);
            this.button_pre.Name = "button_pre";
            this.button_pre.Size = new System.Drawing.Size(75, 23);
            this.button_pre.TabIndex = 3;
            this.button_pre.Text = "<<";
            this.button_pre.UseVisualStyleBackColor = true;
            this.button_pre.Click += new System.EventHandler(this.button_pre_Click);
            // 
            // button_next
            // 
            this.button_next.Location = new System.Drawing.Point(335, 5);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(75, 23);
            this.button_next.TabIndex = 3;
            this.button_next.Text = ">>";
            this.button_next.UseVisualStyleBackColor = true;
            this.button_next.Click += new System.EventHandler(this.button_next_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_quit;
            this.ClientSize = new System.Drawing.Size(596, 350);
            this.Controls.Add(this.button_next);
            this.Controls.Add(this.button_pre);
            this.Controls.Add(this.dateTimePicker_year);
            this.Controls.Add(this.button_quit);
            this.Controls.Add(this.button_debt);
            this.Controls.Add(this.button_invest);
            this.Controls.Add(this.button_partner);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(350, 280);
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Pool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_partner;
        private System.Windows.Forms.Button button_invest;
        private System.Windows.Forms.Button button_quit;
        private System.Windows.Forms.Button button_debt;
        private System.Windows.Forms.DateTimePicker dateTimePicker_year;
        private System.Windows.Forms.Button button_pre;
        private System.Windows.Forms.Button button_next;
    }
}

