using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace ChinaDate
{
	/// <summary>
	/// 程序设计:晓晖
	/// OICQ:25878 Email:webmaster@fangbian.com
	/// 本程序及附带的ChinaDateControl控件免费发布，可以免费使用于任何非商业用途的程序之中
	/// 如果使用过程中有任何建议或者意见可以与作者联系
	/// 本程序采用C#开发，需要.net frame1.1版本支持
	/// 
	/// ChinaDateControl控件类似于微软公司提供的System.Windows.Forms.MonthCalendar控件，
	/// 但是与标准控件相比有几个特点:
	/// 1.本控件支持从1900年到2050年的农历
	/// 2.提供标准事件，可以自由控制鼠标移到某天上面的提示信息
	/// 3.提供属性，可以随时获取鼠标移过或者单击处的日期
	/// 4.可以自由控制所有日期或者标志的颜色、字体
	/// 
	/// 谢谢您使用本控件，欢迎访问我们的网站:www.dotnet.cn
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
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form_ChinaDate()
		{
			
			//
			// Windows 窗体设计器支持所必需的
			//
			InitializeComponent();
			//处理日历控件的两个重要事件
			//显示额外信息的事件，当某天为节假日或者在PaintDate中指定为特殊日子时激发该事件
			this.chinaDateControl1.GetDateInfomation+=new CDate.ChinaDateControl.OnGetDateInfomation(chinaDateControl1_GetDateInfomation);
			//显示某天前激发这个事件
			this.chinaDateControl1.PaintDate+=new CDate.ChinaDateControl.OnPaintDate(chinaDateControl1_PaintDate);
			//
			// TODO: 在 InitializeComponent 调用后添加任何构造函数代码
			//
		}

		/// <summary>
		/// 清理所有正在使用的资源。
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

		#region Windows 窗体设计器生成的代码
		/// <summary>
		/// 设计器支持所需的方法 - 不要使用代码编辑器修改
		/// 此方法的内容。
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
            this.menuItem1.Text = "增加备忘录";
            this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 1;
            this.menuItem2.Text = "修改备忘录";
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 2;
            this.menuItem3.Text = "删除备忘录";
            // 
            // Form_Calendar
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(488, 222);
            this.Controls.Add(this.panel1);
            this.Name = "Form_Calendar";
            this.Text = "日历控件演示程序";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// 应用程序的主入口点。
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
			//用公历确定12月24日鼠标移过时显示的提示信息
			if(e1.Date.Month==12 && e1.Date.Day==24)
			{
				e1.Infomation ="祝大家圣诞节快乐";
                
			}
			else if(e1.ChinaMonth.Equals("八月") && e1.ChinaDay.EndsWith("初一"))//用农历指定8月初一的提示信息
			{
				e1.Infomation ="今天是戴公老爷生日！";
			}
		}

		private void chinaDateControl1_PaintDate(CDate.myArgs e1)
		{
			//用农历指定八月初一是个有额外信息的日子
			if(e1.ChinaMonth.Equals("八月") && e1.ChinaDay.EndsWith("初一"))
			{
                e1.IsSpecial = true;
                
			}
		}

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
	}
}
