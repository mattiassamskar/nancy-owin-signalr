namespace NancyOwin
{
  using Nancy;

  public class MainModule : NancyModule
  {
    public MainModule()
    {
      this.Get["/"] = _ => this.Response.AsFile("Content/index.html", "text/html");
    }
  }
}