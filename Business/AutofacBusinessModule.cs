using Autofac;
using Autofac.Extras.DynamicProxy;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using System.Reflection;

namespace Business;

public class AutofacBusinessModule : Autofac.Module
{
    protected override void Load(ContainerBuilder builder)
    {
        var assembly = Assembly.GetExecutingAssembly();

        builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
            .EnableInterfaceInterceptors(new ProxyGenerationOptions()
            {
                Selector = new AspectInterceptorSelector()
            }).SingleInstance();
    }
}