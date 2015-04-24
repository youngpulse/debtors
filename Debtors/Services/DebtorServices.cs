using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data;
using System.ComponentModel;

namespace Debtors.Services
{
	public class DebtorServices
	{
		private DebtorsEntities _context;

		public BindingList<Debtor> GetDebtors()
		{
			List<Debtor> debtors = new List<Debtor>();
			_context = CreateContext();
			_context.Debtors.Load();

			return _context.Debtors.Local.ToBindingList();
		}

		public List<TypesDebtor> GetTypeDebtor()
		{
			_context.TypesDebtors.Load();
			return _context.TypesDebtors.Local.ToList();
		}

		private DebtorsEntities CreateContext()
		{
			if (_context == null)
			{
				return new DebtorsEntities();
			}

			return _context;
		}
	}
}
