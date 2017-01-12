using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NLog;

namespace EndUserSite.Controllers
{
	public class HomeController : Controller
	{
		private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

		public ActionResult Index()
		{
			//Alala Stable
			//FromB
			Logger.Info("Open index in Home controller");
			return View();
		}

		public ActionResult About()
		{

			Logger.Info("Open About in Home controller");
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact()
		{
			Logger.Info("Open Contact in Home controller");
			ViewBag.Message = "Your contact page.";

			return View();
		}
	}
}