using System;
using Microsoft.AspNetCore.Hosting;

namespace aspnetcoreapp
{
    public class Program
    {
        public static void Main(string[] args)
        {
	
	    var port = Environment.GetEnvironmentVariable("PORT") != null ? Environment.GetEnvironmentVariable("PORT") : "5000";
            var host = new WebHostBuilder()
		.UseKestrel()
		.UseStartup<Startup>()
		.UseUrls("http://0.0.0.0:" + port) 
		.Build();

	    host.Run();
        }
    }
}
