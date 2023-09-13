using Microsoft.AspNetCore.Mvc;

namespace asp.net_practice.Controllers
{

	public class HomeController : Controller
	{

		public IActionResult Index()
		{
			return Content("Index");
		}
		public IActionResult About()
		{
			return Content("About");
		}
		public IActionResult Contact()
		{
			return Redirect("https://microsoft.com");
		}
	}
}
