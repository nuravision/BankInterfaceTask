using Service.Services.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankInterfaceTask.Controllers
{
	public class ClientController
	{
		private readonly ClientService _clientService;
		public ClientController()
		{
			_clientService = new ClientService();
		}
		public void ShowClient()
		{
			_clientService.ShowClient();
		}
	}
}
