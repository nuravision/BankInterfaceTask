using Domain.Models;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services.Implementations
{
	public class WorkerService : IWorkerService
	{
		public void AddOperations()
		{
			Console.WriteLine("Worker added operations"); ;
		}

		public Operation[] Operations()
		{
			throw new NotImplementedException();
		}
	}
}
