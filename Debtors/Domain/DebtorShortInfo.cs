using System;
namespace Debtors.Domain
{
	public class DebtorShortInfo
	{
		public int Id { get; set; }
		public string Type { get; set; }
		public string Name { get; set; }
		public string Address { get; set; }
		public decimal Debt { get; set; }
	}
}
