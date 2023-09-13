using Microsoft.AspNetCore.Mvc;

namespace asp.net_practice.Controllers
{

	public class HomeController : Controller
	{
		readonly ITimeService timeService;

		public HomeController(ITimeService timeServ)
		{
			timeService = timeServ;
		}
		public string Index([FromServices] ITimeService timeService)
		{
			return timeService.Time;
		}
	}
}
