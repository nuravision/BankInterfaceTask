

namespace Domain.Models
{
	public class Worker:Person
	{
		public DateTime StartTime { get; set; }
		public DateTime EndTime { get; set; }
		public Worker(Guid id, string name, string surname, int age, string position, decimal salary, DateTime startTime, DateTime endTime) : base(id, name, surname, age, position, salary)
		{
			StartTime = startTime;
			EndTime = endTime;
		}
		public override string ToString()
		{
			return base.ToString()+$"Start time:{StartTime}\n End time:{EndTime}";
		}
	}
}
