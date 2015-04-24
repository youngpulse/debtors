namespace Debtors.Forms
{
	partial class MainForm
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
			System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange1 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
			System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange2 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
			System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange3 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
			System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange4 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
			System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange5 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
			this.menuStrip2 = new System.Windows.Forms.MenuStrip();
			this.FileMI = new System.Windows.Forms.ToolStripMenuItem();
			this.SaveMI = new System.Windows.Forms.ToolStripMenuItem();
			this.miContragent = new System.Windows.Forms.ToolStripMenuItem();
			this.документыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.contextMenuCalendar = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.otherColorTagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.timescaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.miHour = new System.Windows.Forms.ToolStripMenuItem();
			this.miThirtyMin = new System.Windows.Forms.ToolStripMenuItem();
			this.miFiveteenMin = new System.Windows.Forms.ToolStripMenuItem();
			this.miTenMin = new System.Windows.Forms.ToolStripMenuItem();
			this.miFiveMin = new System.Windows.Forms.ToolStripMenuItem();
			this.panel1 = new System.Windows.Forms.Panel();
			this.monthView = new System.Windows.Forms.Calendar.MonthView();
			this.panel2 = new System.Windows.Forms.Panel();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.calendar = new System.Windows.Forms.Calendar.Calendar();
			this.menuStrip2.SuspendLayout();
			this.contextMenuCalendar.SuspendLayout();
			this.panel1.SuspendLayout();
			this.monthView.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip2
			// 
			this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMI,
            this.miContragent,
            this.документыToolStripMenuItem});
			this.menuStrip2.Location = new System.Drawing.Point(0, 0);
			this.menuStrip2.Name = "menuStrip2";
			this.menuStrip2.Size = new System.Drawing.Size(641, 24);
			this.menuStrip2.TabIndex = 4;
			this.menuStrip2.Text = "menuStrip2";
			// 
			// FileMI
			// 
			this.FileMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveMI});
			this.FileMI.Name = "FileMI";
			this.FileMI.Size = new System.Drawing.Size(48, 20);
			this.FileMI.Text = "Файл";
			// 
			// SaveMI
			// 
			this.SaveMI.Name = "SaveMI";
			this.SaveMI.Size = new System.Drawing.Size(132, 22);
			this.SaveMI.Text = "Сохранить";
			this.SaveMI.Click += new System.EventHandler(this.SaveMI_Click);
			// 
			// miContragent
			// 
			this.miContragent.Name = "miContragent";
			this.miContragent.Size = new System.Drawing.Size(90, 20);
			this.miContragent.Text = "Контрагенты";
			this.miContragent.Click += new System.EventHandler(this.miContragent_Click);
			// 
			// документыToolStripMenuItem
			// 
			this.документыToolStripMenuItem.Name = "документыToolStripMenuItem";
			this.документыToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
			this.документыToolStripMenuItem.Text = "Документы";
			// 
			// contextMenuCalendar
			// 
			this.contextMenuCalendar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.otherColorTagToolStripMenuItem,
            this.timescaleToolStripMenuItem});
			this.contextMenuCalendar.Name = "contextMenuStrip1";
			this.contextMenuCalendar.Size = new System.Drawing.Size(178, 48);
			this.contextMenuCalendar.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip_Opening);
			// 
			// otherColorTagToolStripMenuItem
			// 
			this.otherColorTagToolStripMenuItem.Name = "otherColorTagToolStripMenuItem";
			this.otherColorTagToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
			this.otherColorTagToolStripMenuItem.Text = "Выбрать цвет...";
			this.otherColorTagToolStripMenuItem.Click += new System.EventHandler(this.otherColorTagToolStripMenuItem_Click);
			// 
			// timescaleToolStripMenuItem
			// 
			this.timescaleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miHour,
            this.miThirtyMin,
            this.miFiveteenMin,
            this.miTenMin,
            this.miFiveMin});
			this.timescaleToolStripMenuItem.Name = "timescaleToolStripMenuItem";
			this.timescaleToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
			this.timescaleToolStripMenuItem.Text = "Масштаб времени";
			// 
			// miHour
			// 
			this.miHour.Name = "miHour";
			this.miHour.Size = new System.Drawing.Size(123, 22);
			this.miHour.Text = "1 час";
			this.miHour.Click += new System.EventHandler(this.hour_Click);
			// 
			// miThirtyMin
			// 
			this.miThirtyMin.Name = "miThirtyMin";
			this.miThirtyMin.Size = new System.Drawing.Size(123, 22);
			this.miThirtyMin.Text = "30 минут";
			this.miThirtyMin.Click += new System.EventHandler(this.miThirtyMin_Click);
			// 
			// miFiveteenMin
			// 
			this.miFiveteenMin.Name = "miFiveteenMin";
			this.miFiveteenMin.Size = new System.Drawing.Size(123, 22);
			this.miFiveteenMin.Text = "15 минут";
			this.miFiveteenMin.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
			// 
			// miTenMin
			// 
			this.miTenMin.Name = "miTenMin";
			this.miTenMin.Size = new System.Drawing.Size(123, 22);
			this.miTenMin.Text = "10 минут";
			this.miTenMin.Click += new System.EventHandler(this.minutesToolStripMenuItem1_Click);
			// 
			// miFiveMin
			// 
			this.miFiveMin.Name = "miFiveMin";
			this.miFiveMin.Size = new System.Drawing.Size(123, 22);
			this.miFiveMin.Text = "5 минут";
			this.miFiveMin.Click += new System.EventHandler(this.minutesToolStripMenuItem3_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.monthView);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 24);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(189, 361);
			this.panel1.TabIndex = 0;
			// 
			// monthView
			// 
			this.monthView.ArrowsColor = System.Drawing.SystemColors.Window;
			this.monthView.ArrowsSelectedColor = System.Drawing.Color.Gold;
			this.monthView.Controls.Add(this.panel2);
			this.monthView.DayBackgroundColor = System.Drawing.Color.Empty;
			this.monthView.DayGrayedText = System.Drawing.SystemColors.GrayText;
			this.monthView.DaySelectedBackgroundColor = System.Drawing.SystemColors.Highlight;
			this.monthView.DaySelectedColor = System.Drawing.SystemColors.WindowText;
			this.monthView.DaySelectedTextColor = System.Drawing.SystemColors.HighlightText;
			this.monthView.Dock = System.Windows.Forms.DockStyle.Left;
			this.monthView.ItemPadding = new System.Windows.Forms.Padding(2);
			this.monthView.Location = new System.Drawing.Point(0, 0);
			this.monthView.MonthTitleColor = System.Drawing.SystemColors.ActiveCaption;
			this.monthView.MonthTitleColorInactive = System.Drawing.SystemColors.InactiveCaption;
			this.monthView.MonthTitleTextColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.monthView.MonthTitleTextColorInactive = System.Drawing.SystemColors.InactiveCaptionText;
			this.monthView.Name = "monthView";
			this.monthView.Size = new System.Drawing.Size(189, 361);
			this.monthView.TabIndex = 5;
			this.monthView.Text = "monthView1";
			this.monthView.TodayBorderColor = System.Drawing.Color.Maroon;
			this.monthView.SelectionChanged += new System.EventHandler(this.monthView1_SelectionChanged);
			// 
			// panel2
			// 
			this.panel2.Location = new System.Drawing.Point(359, 85);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(408, 346);
			this.panel2.TabIndex = 0;
			// 
			// splitter1
			// 
			this.splitter1.Location = new System.Drawing.Point(189, 24);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(10, 361);
			this.splitter1.TabIndex = 5;
			this.splitter1.TabStop = false;
			// 
			// calendar
			// 
			this.calendar.ContextMenuStrip = this.contextMenuCalendar;
			this.calendar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.calendar.Font = new System.Drawing.Font("Segoe UI", 9F);
			calendarHighlightRange1.DayOfWeek = System.DayOfWeek.Monday;
			calendarHighlightRange1.EndTime = System.TimeSpan.Parse("17:00:00");
			calendarHighlightRange1.StartTime = System.TimeSpan.Parse("08:00:00");
			calendarHighlightRange2.DayOfWeek = System.DayOfWeek.Tuesday;
			calendarHighlightRange2.EndTime = System.TimeSpan.Parse("17:00:00");
			calendarHighlightRange2.StartTime = System.TimeSpan.Parse("08:00:00");
			calendarHighlightRange3.DayOfWeek = System.DayOfWeek.Wednesday;
			calendarHighlightRange3.EndTime = System.TimeSpan.Parse("17:00:00");
			calendarHighlightRange3.StartTime = System.TimeSpan.Parse("08:00:00");
			calendarHighlightRange4.DayOfWeek = System.DayOfWeek.Thursday;
			calendarHighlightRange4.EndTime = System.TimeSpan.Parse("17:00:00");
			calendarHighlightRange4.StartTime = System.TimeSpan.Parse("08:00:00");
			calendarHighlightRange5.DayOfWeek = System.DayOfWeek.Friday;
			calendarHighlightRange5.EndTime = System.TimeSpan.Parse("17:00:00");
			calendarHighlightRange5.StartTime = System.TimeSpan.Parse("08:00:00");
			this.calendar.HighlightRanges = new System.Windows.Forms.Calendar.CalendarHighlightRange[] {
        calendarHighlightRange1,
        calendarHighlightRange2,
        calendarHighlightRange3,
        calendarHighlightRange4,
        calendarHighlightRange5};
			this.calendar.Location = new System.Drawing.Point(199, 24);
			this.calendar.Name = "calendar";
			this.calendar.Size = new System.Drawing.Size(442, 361);
			this.calendar.TabIndex = 7;
			this.calendar.Text = "calendar";
			this.calendar.LoadItems += new System.Windows.Forms.Calendar.Calendar.CalendarLoadEventHandler(this.calendar1_LoadItems);
			this.calendar.DayHeaderClick += new System.Windows.Forms.Calendar.Calendar.CalendarDayEventHandler(this.calendar1_DayHeaderClick);
			this.calendar.ItemCreated += new System.Windows.Forms.Calendar.Calendar.CalendarItemCancelEventHandler(this.calendar1_ItemCreated);
			this.calendar.ItemDeleted += new System.Windows.Forms.Calendar.Calendar.CalendarItemEventHandler(this.calendar1_ItemDeleted);
			this.calendar.ItemTextEdited += new System.Windows.Forms.Calendar.Calendar.CalendarItemCancelEventHandler(this.calendar_ItemTextEdited);
			this.calendar.ItemDatesChanged += new System.Windows.Forms.Calendar.Calendar.CalendarItemEventHandler(this.calendar_ItemDatesChanged);
			this.calendar.ItemDoubleClick += new System.Windows.Forms.Calendar.Calendar.CalendarItemEventHandler(this.calendar1_ItemDoubleClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(641, 385);
			this.Controls.Add(this.calendar);
			this.Controls.Add(this.splitter1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.menuStrip2);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "lol";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.menuStrip2.ResumeLayout(false);
			this.menuStrip2.PerformLayout();
			this.contextMenuCalendar.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.monthView.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip2;
		private System.Windows.Forms.Calendar.MonthView monthView;
		private System.Windows.Forms.ContextMenuStrip contextMenuCalendar;
		private System.Windows.Forms.ToolStripMenuItem otherColorTagToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem timescaleToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem miHour;
		private System.Windows.Forms.ToolStripMenuItem miThirtyMin;
		private System.Windows.Forms.ToolStripMenuItem miFiveteenMin;
		private System.Windows.Forms.ToolStripMenuItem miTenMin;
		private System.Windows.Forms.ToolStripMenuItem miFiveMin;
		private System.Windows.Forms.ToolStripMenuItem FileMI;
		private System.Windows.Forms.ToolStripMenuItem SaveMI;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.ToolStripMenuItem miContragent;
		private System.Windows.Forms.ToolStripMenuItem документыToolStripMenuItem;
		private System.Windows.Forms.Calendar.Calendar calendar;




	}
}