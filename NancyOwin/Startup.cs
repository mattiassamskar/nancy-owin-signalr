﻿namespace NancyOwin
{
  using Owin;

  public class Startup
  {
    public void Configuration(IAppBuilder app)
    {
      app.MapSignalR();
      app.UseNancy();
    }
  }
}