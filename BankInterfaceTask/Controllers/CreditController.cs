using Service.Services.Implementations;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankInterfaceTask.Controllers
{
	public class CreditController
	{
		private readonly ICreditService _creditService;
		public CreditController()
		{
			_creditService = new CreditService();
		}
		public void CreditShow()
		{
			_creditService.Show();
		}
	}
}
