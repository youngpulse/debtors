using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Calendar;
using Debtors.Domain;
using Debtors.Services;


namespace Debtors.Forms
{
	public partial class MainForm : Form
	{
		private readonly DebtorsEntities _context;
		private readonly CalendarService _calendarService;
		List<CalendarItem> _items = new List<CalendarItem>();
		CalendarItem _contextItem = null;

		public MainForm()
		{
			InitializeComponent();
			_context = new DebtorsEntities();
			_calendarService = new CalendarService();
			monthView.MonthTitleColor = monthView.MonthTitleColorInactive = CalendarColorTable.FromHex("#C2DAFC");
			monthView.ArrowsColor = CalendarColorTable.FromHex("#77A1D2");
			monthView.DaySelectedBackgroundColor = CalendarColorTable.FromHex("#F4CC52");
			monthView.DaySelectedTextColor = monthView.ForeColor;
		}

		private void monthView1_SelectionChanged(object sender, EventArgs e)
		{
			calendar.SetViewRange(monthView.SelectionStart, monthView.SelectionEnd);
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			List<ItemInfo> lst = _calendarService.GetEvents();
			foreach (ItemInfo item in lst)
			{
				CalendarItem cal = new CalendarItem(calendar, item.StartTime, item.EndTime, item.Text, item.Id);

				if (!(item.R == 0 && item.G == 0 && item.B == 0))
				{
					cal.ApplyColor(Color.FromArgb(item.A, item.R, item.G, item.B));
				}

				_items.Add(cal);
			}

			PlaceItems();
		}

		private void PlaceItemsTable()
		{
			foreach (CalendarItem item in _items)
			{
				if (calendar.ViewIntersects(item))
				{
					calendar.Items.Add(item);
				}
			}
		}


		private void PlaceItems()
		{
			foreach (CalendarItem item in _items)
			{
				if (calendar.ViewIntersects(item))
				{
					calendar.Items.Add(item);
				}
			}
		}

		private void calendar1_ItemCreated(object sender, CalendarItemCancelEventArgs e)
		{
			_items.Add(e.Item);
			e.Item.Id = _calendarService.AddItem(e.Item);
		}

		private void calendar1_ItemMouseHover(object sender, CalendarItemEventArgs e)
		{
			Text = e.Item.Text;
		}

		private void calendar1_ItemDoubleClick(object sender, CalendarItemEventArgs e)
		{
			calendar.ActivateEditMode();
		}

		private void calendar1_ItemDeleted(object sender, CalendarItemEventArgs e)
		{
			_calendarService.RemoveItem(e.Item.Id);
			_items.Remove(e.Item);
		}

		private void calendar1_DayHeaderClick(object sender, CalendarDayEventArgs e)
		{
			calendar.SetViewRange(e.CalendarDay.Date, e.CalendarDay.Date);
		}

		private void toolStripMenuItem4_Click(object sender, EventArgs e)
		{
			calendar.TimeScale = CalendarTimeScale.FifteenMinutes;
		}

		private void minutesToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			calendar.TimeScale = CalendarTimeScale.TenMinutes;
		}

		private void minutesToolStripMenuItem2_Click(object sender, EventArgs e)
		{
			calendar.TimeScale = CalendarTimeScale.SixMinutes;
		}

		private void minutesToolStripMenuItem3_Click(object sender, EventArgs e)
		{
			calendar.TimeScale = CalendarTimeScale.FiveMinutes;
		}

		private void calendar1_LoadItems(object sender, CalendarLoadEventArgs e)
		{
			PlaceItems();
		}

		private void SaveMI_Click(object sender, EventArgs e)
		{
			_calendarService.Save();
		}

		private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			
			Application.Exit();
		}

		private void otherColorTagToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (ColorDialog dlg = new ColorDialog())
			{
				if (dlg.ShowDialog() == DialogResult.OK)
				{
					foreach (CalendarItem item in calendar.GetSelectedItems())
					{
						item.ApplyColor(dlg.Color);
						_calendarService.Update(item);
						calendar.Invalidate(item);
					}
				}
			}
		}

		private void contextMenuStrip_Opening(object sender, System.ComponentModel.CancelEventArgs e)
		{
			_contextItem = calendar.ItemAt(contextMenuCalendar.Bounds.Location);
		}

		private void hour_Click(object sender, EventArgs e)
		{
			calendar.TimeScale = CalendarTimeScale.SixtyMinutes;
		}

		private void miThirtyMin_Click(object sender, EventArgs e)
		{
			calendar.TimeScale = CalendarTimeScale.ThirtyMinutes;
		}

		private void calendar_ItemTextEdited(object sender, CalendarItemCancelEventArgs e)
		{
			_calendarService.Update(e.Item);
		}

		private void calendar_ItemDatesChanged(object sender, CalendarItemEventArgs e)
		{
			_calendarService.Update(e.Item);
		}

		private void miContragent_Click(object sender, EventArgs e)
		{
			DebtsForm form = new DebtsForm();
			form.ShowDialog();
		}
	}
}
