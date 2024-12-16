
namespace Domain.Models
{
	public class Person
	{
		public Guid Id { get; set; }
		public string Name { get; set; }
		public string Surname { get; set; }
		public int Age { get; set; }
		public string Position { get; set; }
		public decimal Salary { get; set; }
		public Person(Guid id, string name, string surname, int age, string position, decimal salary)
		{
			Id = id;
			Name = name;
			Surname = surname;
			Age = age;
			Position = position;
			Salary = salary;
		}
		public override string ToString()
		{
			return $"Id: {Id}\n" +
				   $"Name: {Name}\n" +
				   $"Surname: {Surname}\n" +
				   $"Age: {Age}\n" +
				   $"Position: {Position}\n" +
				   $"Salary: {Salary}";
		}
	}
}
