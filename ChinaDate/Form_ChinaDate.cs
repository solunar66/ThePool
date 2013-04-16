using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace ChinaDate
{
	/// <summary>
	/// �������:����
	/// OICQ:25878 Email:webmaster@fangbian.com
	/// �����򼰸�����ChinaDateControl�ؼ���ѷ������������ʹ�����κη���ҵ��;�ĳ���֮��
	/// ���ʹ�ù��������κν���������������������ϵ
	/// ���������C#��������Ҫ.net frame1.1�汾֧��
	/// 
	/// ChinaDateControl�ؼ�������΢��˾�ṩ��System.Windows.Forms.MonthCalendar�ؼ���
	/// �������׼�ؼ�����м����ص�:
	/// 1.���ؼ�֧�ִ�1900�굽2050���ũ��
	/// 2.�ṩ��׼�¼����������ɿ�������Ƶ�ĳ���������ʾ��Ϣ
	/// 3.�ṩ���ԣ�������ʱ��ȡ����ƹ����ߵ�����������
	/// 4.�������ɿ����������ڻ��߱�־����ɫ������
	/// 
	/// лл��ʹ�ñ��ؼ�����ӭ�������ǵ���վ:www.dotnet.cn
	/// </summary>
	public class Form_ChinaDate : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel1;
		private CDate.ChinaDateControl chinaDateControl1;
		private System.Windows.Forms.DateTimePicker dt2;
		private System.Windows.Forms.DateTimePicker dt1;
		private System.Windows.Forms.ContextMenu contextMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem3;
		/// <summary>
		/// ����������������
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form_ChinaDate()
		{
			
			//
			// Windows ���������֧���������
			//
			InitializeComponent();
			//���������ؼ���������Ҫ�¼�
			//��ʾ������Ϣ���¼�����ĳ��Ϊ�ڼ��ջ�����PaintDate��ָ��Ϊ��������ʱ�������¼�
			this.chinaDateControl1.GetDateInfomation+=new CDate.ChinaDateControl.OnGetDateInfomation(chinaDateControl1_GetDateInfomation);
			//��ʾĳ��ǰ��������¼�
			this.chinaDateControl1.PaintDate+=new CDate.ChinaDateControl.OnPaintDate(chinaDateControl1_PaintDate);
			//
			// TODO: �� InitializeComponent ���ú�����κι��캯������
			//
		}

		/// <summary>
		/// ������������ʹ�õ���Դ��
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows ������������ɵĴ���
		/// <summary>
		/// �����֧������ķ��� - ��Ҫʹ�ô���༭���޸�
		/// �˷��������ݡ�
		/// </summary>
		private void InitializeComponent()
		{
            this.panel1 = new System.Windows.Forms.Panel();
            this.dt1 = new System.Windows.Forms.DateTimePicker();
            this.dt2 = new System.Windows.Forms.DateTimePicker();
            this.chinaDateControl1 = new CDate.ChinaDateControl();
            this.contextMenu1 = new System.Windows.Forms.ContextMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dt1);
            this.panel1.Controls.Add(this.dt2);
            this.panel1.Controls.Add(this.chinaDateControl1);
            this.panel1.Location = new System.Drawing.Point(7, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(386, 194);
            this.panel1.TabIndex = 0;
            // 
            // dt1
            // 
            this.dt1.CustomFormat = "yyyy";
            this.dt1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt1.Location = new System.Drawing.Point(0, 0);
            this.dt1.Name = "dt1";
            this.dt1.ShowUpDown = true;
            this.dt1.Size = new System.Drawing.Size(109, 20);
            this.dt1.TabIndex = 4;
            this.dt1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dt2
            // 
            this.dt2.CustomFormat = "MMMM";
            this.dt2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt2.Location = new System.Drawing.Point(194, 0);
            this.dt2.Name = "dt2";
            this.dt2.ShowUpDown = true;
            this.dt2.Size = new System.Drawing.Size(98, 20);
            this.dt2.TabIndex = 3;
            this.dt2.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // chinaDateControl1
            // 
            this.chinaDateControl1.BackColor = System.Drawing.SystemColors.Window;
            this.chinaDateControl1.CommonForeColor = System.Drawing.Color.Blue;
            this.chinaDateControl1.ContextMenu = this.contextMenu1;
            this.chinaDateControl1.Date = new System.DateTime(2003, 12, 19, 0, 0, 0, 0);
            this.chinaDateControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.chinaDateControl1.DrawLine = false;
            this.chinaDateControl1.FontChinaDay = new System.Drawing.Font("Times New Roman", 1F);
            this.chinaDateControl1.FontDay = new System.Drawing.Font("Times New Roman", 12F);
            this.chinaDateControl1.FontWeek = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chinaDateControl1.Location = new System.Drawing.Point(0, 23);
            this.chinaDateControl1.MarkDayColor = System.Drawing.Color.Blue;
            this.chinaDateControl1.Name = "chinaDateControl1";
            this.chinaDateControl1.ShowJieriInfo = false;
            this.chinaDateControl1.Size = new System.Drawing.Size(386, 171);
            this.chinaDateControl1.SpecialForeColor = System.Drawing.Color.Yellow;
            this.chinaDateControl1.TabIndex = 1;
            // 
            // contextMenu1
            // 
            this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem2,
            this.menuItem3});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.Text = "���ӱ���¼";
            this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 1;
            this.menuItem2.Text = "�޸ı���¼";
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 2;
            this.menuItem3.Text = "ɾ������¼";
            // 
            // Form_Calendar
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(488, 222);
            this.Controls.Add(this.panel1);
            this.Name = "Form_Calendar";
            this.Text = "�����ؼ���ʾ����";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// Ӧ�ó��������ڵ㡣
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form_ChinaDate());
		}

		private void dateTimePicker1_ValueChanged(object sender, System.EventArgs e)
		{
			this.chinaDateControl1.Date=new DateTime(this.dt1.Value.Year,this.dt2.Value.Month,1);
		}

		private void chinaDateControl1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			MessageBox.Show(this.chinaDateControl1.CurrentDateTime.ToShortDateString());
		}

		private void menuItem1_Click(object sender, System.EventArgs e)
		{
			MessageBox.Show(this.chinaDateControl1.CurrentDateTime.ToShortDateString());
		}

		private void chinaDateControl1_GetDateInfomation(CDate.myArgs e1)
		{
			//�ù���ȷ��12��24������ƹ�ʱ��ʾ����ʾ��Ϣ
			if(e1.Date.Month==12 && e1.Date.Day==24)
			{
				e1.Infomation ="ף���ʥ���ڿ���";
                
			}
			else if(e1.ChinaMonth.Equals("����") && e1.ChinaDay.EndsWith("��һ"))//��ũ��ָ��8�³�һ����ʾ��Ϣ
			{
				e1.Infomation ="�����Ǵ�����ү���գ�";
			}
		}

		private void chinaDateControl1_PaintDate(CDate.myArgs e1)
		{
			//��ũ��ָ�����³�һ�Ǹ��ж�����Ϣ������
			if(e1.ChinaMonth.Equals("����") && e1.ChinaDay.EndsWith("��һ"))
			{
                e1.IsSpecial = true;
                
			}
		}

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
	}
}
