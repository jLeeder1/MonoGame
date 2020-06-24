using Autofac;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using MonoGameProj.Managers;

namespace MonoGameProj
{
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            // Game1 instnace
            //builder.RegisterInstance(game).As<Game1>();
            builder.RegisterType<Game1>().AsSelf();

            builder.RegisterType<PlayerKeyAssociation>().As<IPlayerKeyAssociation>();
            builder.RegisterType<GameSetup>().As<IGameSetup>();

            /*
            builder.RegisterAssemblyTypes(Assembly.Load(nameof(MonoGameProj)))
                .Where(t => t.Namespace.Contains("Factories/Interfaces"))
                .As(t => t.GetInterfaces().FirstOrDefault(i => i.Name == "I" + t.Name));
            */

            return builder.Build();
        }
    }
}
