using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using NLog;
using NLog.Config;
using NLog.Targets;

namespace Common
{
    public class LogConfig	
    {
		private static Assembly GetMyEntryAssembly()
		{
			if ((System.Web.HttpContext.Current == null))
				return Assembly.GetEntryAssembly(); // Not a web application
			var type = System.Web.HttpContext.Current.ApplicationInstance.GetType();
			while (type != null && type.Namespace == "ASP")
			{
				type = type.BaseType;
			}

			return type == null ? null : type.Assembly;
		}

		public static void Perform() // FROM TEAM A
	    {
			var config = new LoggingConfiguration();

			// Step 2. Create targets and add them to the configuration 
			var consoleTarget = new ColoredConsoleTarget();
			config.AddTarget("console", consoleTarget);

			var fileTarget = new FileTarget();
			config.AddTarget("file", fileTarget);

			// Step 3. Set target properties 
			consoleTarget.Layout = @"${date:format=HH\:mm\:ss} ${logger} ${message}";
		    var an = GetMyEntryAssembly().GetName().Name;
		    var env = ConfigurationManager.AppSettings["Environment"] ?? "UNKNOWNENV";
			fileTarget.FileName = "${basedir}/" + an +"." + env + ".log";
			fileTarget.Layout = "${message}";
			
			// Step 5. Activate the configuration
			LogManager.Configuration = config;
		}
    }
}
