using Service.Services.Implementations;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankInterfaceTask.Controllers
{
	public class CeoController
	{
		private readonly ICeoService _ceoService;
		public CeoController()
		{
			_ceoService = new CeoService();
		}
		public void CeoControl()
		{
			_ceoService.Control();
		}
		public void CeoOrganize()
		{
			_ceoService.Organize();
		}
		public void CeoMakeMeeting()
		{
			_ceoService.MakeMeeting();
		}
		public void CeoDecreasePercentage()
		{
			_ceoService.DecreasePercentage(5);
		}
	}
}
