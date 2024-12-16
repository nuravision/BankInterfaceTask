using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
	public class Ceo:Person
	{
		public Ceo(Guid id, string name, string surname, int age, string position, decimal salary) : base(id, name, surname, age, position, salary)
		{}
		public override string ToString()
		{
			return base.ToString();
		}

	}
}
