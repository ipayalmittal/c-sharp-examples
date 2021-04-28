using System;
using System.Linq;
using System.Text;

namespace BankProject
{
	class Program
	{
		static void Main(string[] args)
		{
			var account = new BankAccount("User1",500);
			Console.WriteLine($"Account {account.Number} was created for owner {account.Owner} with {account.Balance} ");

			account.MakeDeposit(DateTime.Now, 1500, "First Deposit");
			//Console.WriteLine($"Account after deposit {account.Balance} ");
			account.MakeWithdrawal(DateTime.Now,100, "First Withdraw" );
			//Console.WriteLine($"Account after withdraw {account.Balance} ");
			Console.WriteLine(account.GetAccountHistory());

			//var account1 = new BankAccount("PQR", 500);
			//Console.WriteLine($"Account {account1.Number} was created for owner {account1.Owner} with {account1.Balance} ");

			//try
			//{
			//	var inavalidAccount = new BankAccount("invalid account", -55);
			//}
			//catch (ArgumentOutOfRangeException e)
			//{
			//	Console.WriteLine("Invalid account wiht negative balance");
			//	Console.WriteLine(e.ToString());
			//	throw;
			//}

			//try
			//{
			//	account.MakeWithdrawal(DateTime.Now, 750,"OverDraw");
			//}
			//catch (InvalidOperationException e)
			//{
			//	Console.WriteLine("Try to over draw");
			//	Console.WriteLine(e.ToString());
			//	throw;
			//}


		}
	}
}
