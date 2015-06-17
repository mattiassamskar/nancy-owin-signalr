using Microsoft.AspNet.SignalR;
using Microsoft.Owin.Hosting;

using System;

namespace NancyOwin
{
  class Program
  {
    static void Main()
    {
      const string url = "http://+:3000";

      using (WebApp.Start<Startup>(url))
      {
        Console.WriteLine("Running on " + url);

        var hubContext = GlobalHost.ConnectionManager.GetHubContext<SignalHub>();

        while (true)
        {
          Console.Write("Message: ");
          var text = Console.ReadLine();
          hubContext.Clients.All.send(text);
        }
      }
    }
  }
}
