using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services.Implementations
{
	public class CeoService : ICeoService
	{
		public void Control()

		{
			Console.WriteLine("Ceo make control");
		}

		public void DecreasePercentage(int percent)
		{
			Console.WriteLine($"Percent:{percent}"); 
		}

		public void MakeMeeting()
		{
			Console.WriteLine("Ceo make meeting");
		}

		public void Organize()
		{
			Console.WriteLine("Ceo make organize");
		}
	}
}
