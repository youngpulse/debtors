using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using Debtors.Domain;
using System.Drawing;
using System.Windows.Forms.Calendar;

namespace Debtors.Services
{
	public class CalendarService
	{
		private DebtorsEntities _context;

		public CalendarService()
		{}

		/// <summary>
		/// Возвращает список событий пользователя.
		/// </summary>
		/// <returns>События пользователя.</returns>
		public List<ItemInfo> GetEvents()
		{
			List<Event> lstEvent = new List<Event>();
			using (_context = new DebtorsEntities())
			{
				_context.Events.Load();
				lstEvent = LoadUserEvent(UserInfo.Id);
			}

			return ConvertToItemInfo(lstEvent);
		}

		/// <summary>
		/// Обновляет измененную запись.
		/// </summary>
		/// <param name="calendarItem">Запись календаря.</param>
		public void Update(CalendarItem calendarItem)
		{
			Event currentEvent = ConvertToEvent(calendarItem);

			using (DebtorsEntities context = new DebtorsEntities())
			{
				context.Entry(currentEvent).State = EntityState.Modified;
				context.SaveChanges();
			}
		}

		/// <summary>
		/// Удаляет выбранную запись из базы.
		/// </summary>
		/// <param name="id">Id выбранной записи.</param>
		public void RemoveItem(int id)
		{
			using (_context = new DebtorsEntities())
			{
				Event currentEvent = _context.Events.SingleOrDefault(x => x.Id == id);
				_context.Events.Remove(currentEvent);
				_context.SaveChanges();
			}
		}

		/// <summary>
		/// Добавляет новую запись в базу.
		/// </summary>
		/// <param name="calendarItem">Запись из календаря.</param>
		/// <returns>Id добавленной записи.</returns>
		public int AddItem(CalendarItem calendarItem)
		{
			Event newEvent = ConvertToEvent(calendarItem);

			using (_context = new DebtorsEntities())
			{
				_context.Entry(newEvent).State = EntityState.Added;
				_context.SaveChanges();
			}

			return newEvent.Id;
		}


		/// <summary>
		/// Не знаю надо или нет.
		/// </summary>
		public void Save()
		{
			using (_context = new DebtorsEntities())
			{
				int num = _context.SaveChanges();
			}
		}

		private List<Event> LoadUserEvent(int idUser)
		{
			return (from userEvent in _context.Events
			 where userEvent.UserId == idUser
			 select userEvent).ToList<Event>();
		}
		private List<ItemInfo> ConvertToItemInfo(List<Event> lstEvent)
		{
			List<ItemInfo> lst = new List<ItemInfo>();
			foreach (Event row in lstEvent)
			{
				ItemInfo item = CreateItemInfo(row);
				lst.Add(item);
			}

			return lst;
		}
		private Event ConvertToEvent(CalendarItem item)
		{
			Event newEvent = new Event();
			if (item.Id != null)
			{ newEvent.Id = item.Id; }
			newEvent.Text = item.Text;
			newEvent.DateTimeStart = item.StartDate;
			newEvent.DateTimeEnd = item.EndDate;
			newEvent.Color = item.BackgroundColor.Name;
			newEvent.UserId = UserInfo.Id;
			return newEvent;
		}
		private ItemInfo CreateItemInfo(Event currentEvent)
		{
			string colorCode = currentEvent.Color.ToString();
			int argb = Int32.Parse(colorCode.Replace("#", ""), System.Globalization.NumberStyles.HexNumber);
			Color clr = Color.FromArgb(argb);
			DateTime start = DateTimeParse(currentEvent.DateTimeStart);
			DateTime end = DateTimeParse(currentEvent.DateTimeEnd);

			return new ItemInfo(start, end, currentEvent.Text, clr, currentEvent.Id);
		}
		private DateTime DateTimeParse(object date)
		{
			return DateTime.Parse(date.ToString());
		}
	}
}