

namespace Domain.Models
{
	public class Operation
	{

		Guid Id { get; set; }
		public string ProcessName { get; set; }
		public DateTime DateTime { get; set; }

		public Operation(string processName, DateTime dateTime)
		{
			Id=Guid.NewGuid();
			ProcessName = processName;
			DateTime = dateTime;
		}
		public override string ToString()
		{
			return $"Id:{Id}\nProcessName:{ProcessName}\nDateTime:{DateTime}";
		}
	}
}
