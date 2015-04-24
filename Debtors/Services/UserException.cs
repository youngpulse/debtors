using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debtors.Services
{
	public class UserException:Exception
	{
		public UserException()
			:base()
		{}

		public UserException(string message)
			: base(message)
		{
		}

		public UserException(string message, Exception inner)
			: base(message, inner)
		{
		}
	}
}
