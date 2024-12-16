using Domain.Models;
using Service.Services.Implementations;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankInterfaceTask.Controllers
{
	public class BankController
	{
		private readonly IBankService _bankService;
		public BankController()
		{
			_bankService = new BankService();
		}
		public void PayCredit()
		{
			_bankService.PayCredit(new Client(Guid.NewGuid(), "nur", "isi", 22, "programmer",
				2500, "no", "no"),200);
		}

		public void ShowAllCredit()
		{
			_bankService.ShowAllCredit();
		}

		public void ShowClientCredit()
		{
			_bankService.ShowClientCredit("nurana");
		}
	}
}
