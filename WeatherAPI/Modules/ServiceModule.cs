using Autofac;
using WeatherAPI.Services;

namespace WeatherAPI.Modules
{
    public class ServiceModule : Module
    {
        protected override void Load(ContainerBuilder container)
        {
            container.RegisterType<WeatherService>()
                .As<IWeatherService>()
                .InstancePerLifetimeScope();
        }
    }
}
