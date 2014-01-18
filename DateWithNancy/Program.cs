using System;
using Nancy;
using Nancy.Hosting.Self;

namespace DateWithNancy
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			using (var host = new NancyHost(new Uri("http://localhost:3000")))
			{
				host.Start();
				Console.ReadLine();
			}
		}
	}
}
