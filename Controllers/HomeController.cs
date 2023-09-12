using Microsoft.AspNetCore.Mvc;

namespace asp.net_practice.Controllers
{
	[Controller]
	public class HomeController : Controller
	{
		[NonAction] 
		public string Index()
		{
			
			return "Hello World";
		}

		public string URL(string name)=>$"your name:{name}";
	}
}
