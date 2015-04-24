using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debtors.Services
{
	public class UserService
	{
		#region MaxLength

		private const int _loginMaxLength = 16;
		private const int _passwordMaxLength = 16;

		public int LoginMaxLength
		{
			get { return _loginMaxLength; }
		}

		public int PasswordMaxLength
		{
			get { return _passwordMaxLength; }
		}

		#endregion
		#region MinLength
		private const int _loginMinLength = 3;
		private const int _passwordMinLength = 3;


		public int LoginMinLength
		{
			get { return _loginMinLength; }
		}

		public int PasswordMinLength
		{
			get { return _passwordMinLength; }
		}
		#endregion

		private string _login;
		private string _password;
		private readonly DebtorsEntities _context;
		private UserInfo _userInfo;


		public UserService()
		{
			_context = new DebtorsEntities();
		}

		public static string Name
		{
			get
			{
				DebtorsEntities context = new DebtorsEntities();
				context.Users.Load();
				var result = from user in context.Users
							 select user.Name;
				return result.ToString();
			}
		}

		public bool Authorizate(string login, string password)
		{
			_login = login; _password = password;
			if (!IsNullOrEmpty(_login) & !IsNullOrEmpty(_password))
			{
				if (IsValidLogin(_login) & IsValidPassword(_password))
				{
					_context.Users.Load();
					User result = (from user in _context.Users
								   where user.Login == _login && user.Password == _password
								   select user).Single<User>();
					if (result == null)
					{
						string exMessage = string.Format("Пользователь не найден!");
						throw new UserException(exMessage);
					}

					CreateUserSession(_login);
					return true;
				}
			}

			return false;
		}

		private void CreateUserSession(string login)
		{
			_userInfo = UserInfo.Instance;
			_userInfo.Extract(_login);
		}


		private bool IsValidLogin(string login)
		{
			if (login.Length < LoginMinLength)
			{
				string exMessage = string.Format("Длина логина должна быть от {0} до {1} символов.",LoginMinLength, LoginMaxLength);
				throw new UserException(exMessage);
			}

			return true;
		}

		private bool IsValidPassword(string password)
		{
			if (password.Length < PasswordMinLength)
			{
				string exMessage = string.Format("Длина пароля должна быть от {0} до {1} символов.", PasswordMinLength, PasswordMaxLength);
				throw new UserException(exMessage);
			}

			return true;
		}

		private bool IsNullOrEmpty(string text)
		{
			if (string.IsNullOrEmpty(text))
			{
				string exMessage = string.Format("Необходимо заполнить все поля!");
				throw new UserException(exMessage);
			}

			return false;
		}
	}
}
