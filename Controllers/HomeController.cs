using Microsoft.AspNetCore.Mvc;

namespace asp.net_practice.Controllers
{

	public class HomeController : Controller
	{

		public IActionResult Index()
		{
			
			Person person = new Person("Tom", 224);
			return Json(person);
		}
	}
}
