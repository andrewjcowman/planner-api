using Autofac;
using WaterApi.Services;

namespace WaterApi.Modules
{
    public class ServiceModule : Module
    {
        protected override void Load(ContainerBuilder container)
        {
            container.RegisterType<WaterService>()
                .As<IWaterService>()
                .InstancePerLifetimeScope();
        }
    }
}
