using Autofac;
using MarketApi.Services;

namespace MarketApi.Modules
{
    public class ServiceModule : Module
    {
        protected override void Load(ContainerBuilder container)
        {
            container.RegisterType<MarketService>()
                .As<IMarketService>()
                .InstancePerLifetimeScope();
        }
    }
}
