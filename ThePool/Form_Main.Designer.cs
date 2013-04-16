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
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(596, 332);
            this.panel1.TabIndex = 0;
            // 
            // button_partner
            // 
            this.button_partner.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_partner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_partner.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_partner.Location = new System.Drawing.Point(0, 338);
            this.button_partner.Name = "button_partner";
            this.button_partner.Size = new System.Drawing.Size(100, 35);
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
            this.button_invest.Location = new System.Drawing.Point(115, 338);
            this.button_invest.Name = "button_invest";
            this.button_invest.Size = new System.Drawing.Size(100, 35);
            this.button_invest.TabIndex = 1;
            this.button_invest.Text = "投 资";
            this.button_invest.UseVisualStyleBackColor = true;
            this.button_invest.Click += new System.EventHandler(this.button_invest_Click);
            // 
            // button_quit
            // 
            this.button_quit.Location = new System.Drawing.Point(492, 338);
            this.button_quit.Name = "button_quit";
            this.button_quit.Size = new System.Drawing.Size(100, 35);
            this.button_quit.TabIndex = 1;
            this.button_quit.Text = "退 出";
            this.button_quit.UseVisualStyleBackColor = true;
            this.button_quit.Click += new System.EventHandler(this.button_quit_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 379);
            this.Controls.Add(this.button_quit);
            this.Controls.Add(this.button_invest);
            this.Controls.Add(this.button_partner);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(350, 300);
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
    }
}

