using Service.Services.Implementations;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankInterfaceTask.Controllers
{
	public class ManagerController
	{
		private readonly IManagerService _managerService;
		public ManagerController()
		{
			_managerService = new ManagerService();
		}
		public void Organize()
		{
			_managerService.Organize();
		}
		public void CalculateSalaries()
		{
			_managerService.CalculateSalaries();
		}

	}
}
