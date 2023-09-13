using Microsoft.AspNetCore.Mvc;

namespace asp.net_practice
{
	public class HtmlResult : IActionResult
	{
		string html;
		public HtmlResult(string html) => this.html = html;

		public async Task ExecuteResultAsync(ActionContext context)
		{
			string fullHtmlCode = @$"<!DOCTYPE html>
            <html>
                <head>
                    <title>METANIT.COM</title>
                    <meta charset=utf-8 />
                </head>
                <body>{html}</body>
            </html>";
			await context.HttpContext.Response.WriteAsync(fullHtmlCode);
		}
	}
}
