﻿using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services.Implementations
{
	public class CreditService : ICreditService
	{
		public void Show()
		{
			Console.WriteLine("Credit show worked"); ;
		}
	}
}
