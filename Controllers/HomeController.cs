using Microsoft.AspNetCore.Mvc;

namespace asp.net_practice.Controllers
{

	public class HomeController : Controller
	{
		public IActionResult GetFile()
		{
			string file_path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Files/TextFile.txt");
			string file_type = "text/plain";

			return PhysicalFile(file_path,file_type);
		}
	}
}
