using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MonoGameProj.DependencyInjection
{
    public static class DependencyInjectionConfiguration
    {
        public static IContainer ConfigureContainer()
        {
            var builder = new ContainerBuilder();

            // MonoGameProj/Logic/Game/DeltaTime
            // ConfigureDependenciesForLogicNamespace.ConfigureDependencies(builder);

            // MonoGameProj/Input
            builder.RegisterAssemblyTypes(Assembly.Load(nameof(MonoGameProj)))
                .Where(t => t.Namespace.Contains("Input"))
                .As(t => t.GetInterfaces().FirstOrDefault(i => i.Name == "I" + t.Name));

            return builder.Build();
        }
    }
}
