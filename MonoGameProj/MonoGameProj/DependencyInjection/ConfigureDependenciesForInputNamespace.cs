using Autofac;
using System.Linq;
using System.Reflection;

namespace MonoGameProj.DependencyInjection
{
    public static class ConfigureDependenciesForInputNamespace
    {
        public static ContainerBuilder ConfigureDependencies(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(Assembly.Load(nameof(MonoGameProj)))
                .Where(t => t.Namespace.Contains("Input"))
                .As(t => t.GetInterfaces().FirstOrDefault(i => i.Name == "I" + t.Name));

            return builder;
        }
    }
}
