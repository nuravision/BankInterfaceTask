using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services.Implementations
{
	public class ManagerService : IManagerService
	{
		public void CalculateSalaries()
		{
			Console.WriteLine("Manager Service worked"); ;
		}

		public void Organize()
		{
			Console.WriteLine("Manager organize worked");
		}
	}
}
