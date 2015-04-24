using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Debtors.Services
{
	public class UserInfo
	{
		private readonly DebtorsEntities _context;

		private static string _name;
		private static int _id;
		public static string Name
		{
			get { return _name; }
			set { _name = value; }
		}

		public static int Id
		{
			get { return _id; }
		}

		protected UserInfo()
		{
			_context = new DebtorsEntities();
		}

		private static readonly UserInfo _instance = new UserInfo();

		public static UserInfo Instance
		{
			get { return UserInfo._instance; }
		}

		public void Extract(string login)
		{
			_context.Users.Load();
			User currentUser = (from user in _context.Users
						 where user.Login == login
						 select user).Single<User>();

			_name = currentUser.Name;
			_id = currentUser.Id;
		}
	}
}
