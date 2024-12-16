using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services.Interfaces
{
	public interface ICeoService
	{
		void Control();
		void Organize();
		void MakeMeeting();
		void DecreasePercentage(int percent);
	}
}
