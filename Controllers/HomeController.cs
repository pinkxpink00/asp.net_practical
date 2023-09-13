using Microsoft.AspNetCore.Mvc;

namespace asp.net_practice.Controllers
{

	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return new HtmlResult("Hello Kitty");
		}
	}
}
