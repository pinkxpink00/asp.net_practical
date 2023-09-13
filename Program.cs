var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddTransient<ITimeService, SimpleTimeService>();

var app = builder.Build();



// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Home/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.MapControllerRoute(
	name: "defailt",
	pattern: "{controller=Home}/{action=Index}/{id?}");

app.UseAuthorization();


app.Run();
public interface ITimeService
{
	string Time { get; }
}
public class SimpleTimeService : ITimeService
{
	public string Time => DateTime.Now.ToString("hh:mm:ss");
}


