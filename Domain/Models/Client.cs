

namespace Domain.Models
{
	public class Client:Person
	{
		public string LiveAddress { get; set; }
		public string WorkAddress { get; set; }
		public Client(Guid id, string name, string surname, int age, string position, decimal salary, string liveAddress, string workAddress) : base(id, name, surname, age, position, salary)
		{
			LiveAddress = liveAddress;
			WorkAddress = workAddress;
		}
	}
}
