
using System.Runtime.ConstrainedExecution;

namespace Domain.Models
{
	public class Bank
	{
		public string Name { get; set; }
		public decimal Budget { get; set; }
		public decimal Profit { get; set; }
		public Ceo Ceo { get; set; }
		public Worker[] Workers { get; set; }
		public Manager[] Managers { get; set; }
		public Client[] Clients { get; set; }

		public Bank(string name, decimal budget, decimal profit, Ceo ceo, Worker[] workers, Manager[] managers, Client[] clients)
		{
			Name = name;
			Budget = budget;
			Profit = profit;
			Ceo = ceo;
			Workers = workers;
			Managers = managers;
			Clients = clients;
		}
	}
}
