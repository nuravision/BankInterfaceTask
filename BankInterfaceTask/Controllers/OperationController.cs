using Service.Services.Implementations;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankInterfaceTask.Controllers
{
	public class OperationController
	{
		private readonly IOperationService _operationService;
		public OperationController()
		{
			_operationService = new OperationService();
		}
		public void Show()
		{
			_operationService.Show();
		}
	}
}
