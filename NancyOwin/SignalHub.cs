namespace NancyOwin
{
  using Microsoft.AspNet.SignalR;

  public class SignalHub : Hub
  {
    public void Send(string text)
    {
      this.Clients.All.send(text);
    }
  }
}