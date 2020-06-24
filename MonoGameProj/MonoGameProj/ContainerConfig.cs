using Autofac;
using MonoGameProj.Entities;
using MonoGameProj.Entities.Collections;
using MonoGameProj.Entities.GameObjects;
using MonoGameProj.Entities.Players;
using MonoGameProj.Helpers;
using MonoGameProj.Logic.Game;
using MonoGameProj.Managers;
using MonoGameProj.Managers.PlayerMangers;
using MonoGameProj.Shooting;

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

            builder.RegisterType<DeltaTimeCalculator>().As<IDeltaTimeCalculator>();

            // Entitylist
            builder.RegisterType<EntityList>().As<IGameCollection<Entity>>();
            builder.RegisterType<PlayerList>().As<IGameCollection<Player>>();
            builder.RegisterType<BulletList>().As<IGameCollection<Bullet>>();

            //Setup
            builder.RegisterType<PlayerKeyAssociation>().As<IPlayerKeyAssociation>();
            builder.RegisterType<GameSetup>().As<IGameSetup>();
            builder.RegisterType<PlayerSetup>().As<IPlayerSetup>();

            // Factories
            builder.RegisterType<GunFactory>().As<IGunFactory>();

            // Input
            builder.RegisterType<PlayerActionResolver>().As<IPlayerActionResolver>();

            // Managers
            builder.RegisterType<PlayerActionManager>().As<IPlayerActionManager>();
            builder.RegisterType<BulletMovementManger>().As<IBulletMovementManger>();

            // Movement
            builder.RegisterType<PlayerMovementController>().As<IPlayerMovementController>();

            // Shooting
            builder.RegisterType<PlayerShootingController>().As<IPlayerShootingController>();

            /*
            builder.RegisterAssemblyTypes(Assembly.Load(nameof(MonoGameProj)))
                .Where(t => t.Namespace.Contains("Factories/Interfaces"))
                .As(t => t.GetInterfaces().FirstOrDefault(i => i.Name == "I" + t.Name));
            */

            return builder.Build();
        }
    }
}
