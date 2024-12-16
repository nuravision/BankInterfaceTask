using Service.Services.Implementations;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankInterfaceTask.Controllers
{
	public class WorkerController
	{
		private readonly IWorkerService _workerService;
		public WorkerController()
		{
			_workerService=new WorkerService();
		}
		public void Operations()
		{
			Console.WriteLine("Worker operations:");
		}
		public void AddOperation()
		{
			Console.WriteLine("Worker for Add Operations");
			_workerService.AddOperations();
		}
	}
}
