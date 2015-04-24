using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using Debtors.Domain;
using System.IO;

namespace Debtors.Services
{
	public class DebtorService
	{
		private DebtorsEntities _context;

		public DebtorService()
		{
		}

		/// <summary>
		/// Возвращает все должников.
		/// </summary>
		/// <returns>Список должников.</returns>
		public List<DebtorShortInfo> GetDebtors()
		{
			List<DebtorShortInfo> debtors = new List<DebtorShortInfo>();
			using (DebtorsEntities context = new DebtorsEntities())
			{
				context.Debtors.Load();
				debtors = (from debtor in context.Debtors
						   join type in context.TypesDebtors on debtor.TypeId equals type.Id
							 select new DebtorShortInfo { Id = debtor.Id, Name = debtor.Name, Address = debtor.Address, Debt = debtor.Debt, Type = type.name }).ToList<DebtorShortInfo>();
			}

			return debtors;
		}

		public Debtor GetCurrentDebtor(int id)
		{
			Debtor debtor;
			using (_context = new DebtorsEntities())
			{
				debtor = (from x in _context.Debtors
						  where x.Id == id
						  select x).SingleOrDefault();
				//debtor = _context.Debtors
				//	.Where(db => db.Id == id)
				//	.Include(record => record.Journals)
				//	.SingleOrDefault();
			}

			return debtor;
		}

		public List<TypesDebtor> GetTypeDebtor()
		{
			using (_context = new DebtorsEntities())
			{
				_context.TypesDebtors.Load();
			}
			return _context.TypesDebtors.Local.ToList();
		}

		public List<Record> GetRecordJournal(int idDebtor)
		{
			List<Record> records = new List<Record>();
			using (_context = new DebtorsEntities())
			{
				_context.Journals.Load();
				records = (from x in _context.Journals
						   where x.DebtorId == idDebtor
						   select new Record {Id = x.Id, Date = x.Date, Text = x.Text}).ToList<Record>();
			}

			return records;
		}
		public void AttachScan(Debtor debtor)
		{
			using (_context = new DebtorsEntities())
			{
				_context.Debtors.Attach(debtor);
				_context.Entry(debtor).Property(x => x.ScanContract).IsModified = true;
				_context.SaveChanges();
			}
		}

		public bool HandleUpload(Debtor debtor, string fileName)
		{
			bool handled = false;
			

			try
			{
				FileStream fileStream = File.OpenRead(fileName);
				byte[] documentBytes = new byte[fileStream.Length];
				fileStream.Read(documentBytes, 0, documentBytes.Length);

				debtor.ScanContract = documentBytes;
				debtor.FileExtension = Path.GetExtension(fileName);

				using (_context = new DebtorsEntities())
				{
					_context.Debtors.Attach(debtor);
					_context.Entry(debtor).Property(x => x.ScanContract).IsModified = true;
					_context.Entry(debtor).Property(x => x.FileExtension).IsModified = true;
					
					handled = (_context.SaveChanges() > 0);
				}
			}
			catch (Exception ex)
			{
				// Oops, something went wrong, handle the exception
			}

			return handled;
		}

		public bool IsScan(int idContract)
		{
			bool isScan = false;
			using (_context = new DebtorsEntities())
			{
				var result = from debtor in _context.Debtors
							 where debtor.Id == idContract
							 select debtor.ScanContract;
				if (result != null)
				{
					return true;
				}
			}

			return isScan;
		}

		public void OpenFile(int idDebtor)
		{
			using (_context = new DebtorsEntities())
			{
				byte[] binaryData = (from debtor in _context.Debtors
							 where debtor.Id == idDebtor
							 select debtor.ScanContract).SingleOrDefault();

				string extension = (from debtor in _context.Debtors
								   where debtor.Id == idDebtor
								   select debtor.FileExtension).SingleOrDefault();

				if (extension != null && binaryData != null)
				{
					string path = Path.GetTempFileName() + extension;
					using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.Create)))
					{
						writer.Write(binaryData);
					}
					System.Diagnostics.Process.Start(path);
				}

			}
		}

		public void SaveCurrentDebtor(Debtor changedDebtor)
		{
			using (_context = new DebtorsEntities())
			{
				_context.Entry(changedDebtor).State = System.Data.Entity.EntityState.Modified;
				_context.SaveChanges();
			}
		}

		public void SaveColletionDebt(List<Record> records, int debtorId)
		{
			
			using (_context = new DebtorsEntities())
			{
				foreach (Record record in records)
				{
					Journal journal = new Journal();
					journal.Date = record.Date;
				
					journal.Text = record.Text;
					journal.DebtorId = debtorId;
					var isExist = (from x in _context.Journals
								   where x.Id == record.Id
								   select x).SingleOrDefault();

					if (isExist == null)
					{
						_context.Entry(journal).State = EntityState.Added;
					}

					else
					{
						journal.Id = record.Id;
						_context.Entry(journal).State = EntityState.Modified;
					}
					
				}
				_context.SaveChanges();
			}

		}

		private bool IsEqualString(string oldStr, string newStr)
		{
			int result = String.Compare(oldStr, newStr);
			if(result == 0) 
			{
				return true;
			}

			return false;
		}

		private bool IsEqualDecimal(decimal oldDecimal, decimal newDecimal)
		{
			int result = Decimal.Compare(oldDecimal, newDecimal);
			if (result == 0)
			{
				return true;
			}

			return false;
		}

		#region Sort
		public List<DebtorShortInfo> SortByName(bool isAscending)
		{
			if (isAscending)
			{
				return SortByNameAsc();
			}

			return SortByNameDesc();
		}

		private List<DebtorShortInfo> SortByNameAsc()
		{
			List<DebtorShortInfo> debtors = new List<DebtorShortInfo>();
			using (DebtorsEntities context = new DebtorsEntities())
			{
				debtors = (from debtor in context.Debtors
						   join type in context.TypesDebtors on debtor.TypeId equals type.Id
						  orderby debtor.Name ascending
						  select new DebtorShortInfo{Id = debtor.Id, Address = debtor.Address, Debt = debtor.Debt, Name = debtor.Name, Type = type.name}).ToList<DebtorShortInfo>();
			}

			return debtors;
		}

		private List<DebtorShortInfo> SortByNameDesc()
		{
			List<DebtorShortInfo> debtors = new List<DebtorShortInfo>();
			using (DebtorsEntities context = new DebtorsEntities())
			{
				debtors = (from debtor in context.Debtors
						   join type in context.TypesDebtors on debtor.TypeId equals type.Id
						   orderby debtor.Name descending
						   select new DebtorShortInfo { Id = debtor.Id, Address = debtor.Address, Debt = debtor.Debt, Name = debtor.Name, Type = type.name }).ToList<DebtorShortInfo>();
			}

			return debtors;
		}
		#endregion
	}
}
