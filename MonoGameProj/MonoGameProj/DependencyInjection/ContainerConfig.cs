using Autofac;
using Microsoft.Xna.Framework;
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

            // Better to do this the assemly way as seen in tutorial
            // OR would it be possible to dynamically collect all assemlies in proj
            // Then iteraate over each, matching each sype with the interface that matches it's prefixed with 'I'
            // Found in asubfolder of that assembly with the name 'Interfaces'
            //
            // This way will do for now, need to keep messing around with it

            // Game1 instnace
            builder.RegisterType<Game1>().AsSelf();

            // GameTime
            builder.RegisterType<GameTime>().AsSelf();

            // Delta time
            builder.RegisterType<DeltaTimeCalculator>().As<IDeltaTimeCalculator>();

            // Entitylist
            builder.RegisterType<EntityList>().As<IGameCollection<Entity>>();
            builder.RegisterType<PlayerList>().As<IGameCollection<Player>>();
            builder.RegisterType<BulletList>().As<IGameCollection<Bullet>>();

            // Setup
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

            // Delta time
            builder.RegisterType<DeltaTimeCalculator>().As<IDeltaTimeCalculator>();

            return builder.Build();
        }
    }
}
