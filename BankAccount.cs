using System;
using System.Collections.Generic;
using System.Text;

namespace BankProject
{
	public class BankAccount
	{

		private static int accountNumberSeed = 1234567890;
		private List<Transaction> allTransactions = new List<Transaction>();
		public BankAccount(string name, decimal initialAmount)
		{
			Owner = name;
			
			Number = accountNumberSeed;
			accountNumberSeed++;

			MakeDeposit(DateTime.Now, initialAmount, "Deposit");
		}
		public string Owner { get; set; }
		public int Number { get; }

		public decimal Balance
		{
			get
			{
				decimal balance = 0;
				foreach (var item in allTransactions)
				{
					balance = balance + item.Amount;
				}
				return balance;
			}
		}

		public void MakeDeposit( DateTime date, decimal amount, string note)
		{
			if (amount <= 0)
			{
				throw new ArgumentOutOfRangeException("amount should not be negative");
			}

			var deposit = new Transaction(date,amount, note);
			allTransactions.Add(deposit);
		}


		public void MakeWithdrawal(DateTime date, decimal amount, string note)
		{
			if (amount <= 0)
			{
				throw new ArgumentOutOfRangeException("amount should not be negative");
			}

			if (Balance - amount <= 0)
			{
				throw new InvalidOperationException("Not sufficient amount");
			}
			var withdraw = new Transaction(date,-amount,note);
			allTransactions.Add(withdraw);

		}

		public string GetAccountHistory()
		{
			var report = new System.Text.StringBuilder();

			decimal balance = 0;
			report.AppendLine("Date\t\tAmount\tBalance\tNote");
			foreach (var item in allTransactions)
			{
				balance += item.Amount;
				report.AppendLine($"{item.Date.ToShortDateString()}\t{item.Amount}\t{item.Notes}");
			}

			return report.ToString();
		}
	}
}
