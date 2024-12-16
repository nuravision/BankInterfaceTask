using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services.Interfaces
{
	public interface IBankService
	{
		void ShowClientCredit(string fullname);
		void PayCredit(Client client, decimal money);
		void ShowAllCredit();
	}
}
