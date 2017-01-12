using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Common;

namespace ExternalCommunicationsService.App_Code
{
	public class Init
	{
		public static void AppInitialize()
		{
			LogConfig.Perform();
		}
	}
}