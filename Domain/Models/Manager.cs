
namespace Domain.Models
{
	public class Manager:Person
	{
		public Manager(Guid id, string name, string surname, int age, string position, decimal salary) : base(id, name, surname, age, position, salary)
		{
		}
		public override string ToString()
		{
			return base.ToString();
		}
	}
}
