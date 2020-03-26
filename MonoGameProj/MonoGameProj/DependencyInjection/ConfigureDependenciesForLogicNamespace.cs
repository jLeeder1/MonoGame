using Autofac;
using System.Linq;
using System.Reflection;

namespace MonoGameProj.DependencyInjection
{
    public static class ConfigureDependenciesForLogicNamespace
    {
        public static ContainerBuilder ConfigureDependencies(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(Assembly.Load(nameof(MonoGameProj)))
                .Where(t => t.Namespace.Contains("Logic/Game/DeltaTime"))
                .As(t => t.GetInterfaces().FirstOrDefault(i => i.Name == "I" + t.Name));

            return builder;
        }
    }
}
