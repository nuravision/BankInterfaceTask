using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services.Implementations
{
	public class ClientService : IClientService
	{
		public void ShowClient()
		{
			Console.WriteLine("Client Service worked"); ;
		}
	}
}
