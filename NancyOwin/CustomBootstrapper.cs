namespace NancyOwin
{
  using Nancy;
  using Nancy.Conventions;

  public class CustomBootstrapper : DefaultNancyBootstrapper
  {
    protected override void ConfigureConventions(NancyConventions nancyConventions)
    {
      nancyConventions.StaticContentsConventions.Add(StaticContentConventionBuilder.AddDirectory("/", "Content"));
      base.ConfigureConventions(nancyConventions);
    }
  }
}