using Autofac;
using MonoGameProj.Logic.Input;
using MonoGameProj.Managers;
using System.Linq;
using System.Reflection;

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

            // MonoGameProj/Managers
            builder.RegisterAssemblyTypes(Assembly.Load(nameof(MonoGameProj)))
                .Where(t => t.Namespace.Contains("Managers"))
                .As(t => t.GetInterfaces().FirstOrDefault(i => i.Name == "I" + t.Name));

            var container = builder.Build();

            using (var scope = container.BeginLifetimeScope())
            {
                //Input
                var keyboardInput = scope.Resolve<IMyKeyboardInput>();

                //Managers
                var playerKeyAssociationManger = scope.Resolve<IPlayerKeyAssociationManager>();
                var playerMovementManger = scope.Resolve<IPlayerMovementManager>();
            }

            return container;
        }
    }
}
