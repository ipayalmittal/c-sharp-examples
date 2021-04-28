using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace BankProject
{
	public class Transaction
	{
		
		public decimal Amount { get; }
		public string Notes { get; }
		public DateTime Date { get; }

		public Transaction(DateTime date,decimal amount,string notes)
		{
			Amount = amount;
			Notes = notes;
			Date = date;
		}

	}
}
