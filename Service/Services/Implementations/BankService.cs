using Domain.Models;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services.Implementations
{
	public class BankService : IBankService
	{
		public void PayCredit(Client client, decimal money)
		{
			Console.WriteLine("Pay credit worked");
		}

		public void ShowAllCredit()
		{
			Console.WriteLine("Show All Worked credit");
		}

		public void ShowClientCredit(string fullname)
		{
			Console.WriteLine("Show client worked");
		}
	}
}
