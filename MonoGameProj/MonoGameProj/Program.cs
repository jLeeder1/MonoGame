using MonoGameProj.DependencyInjection;
using MonoGameProj.Logic.Game.DeltaTime;
using System;

namespace MonoGameProj
{
#if WINDOWS || LINUX
    /// <summary>
    /// The main class.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var container = DependencyInjectionConfiguration.ConfigureContainer();

            using (var scope = container.BeginLifetimeScope())
            {
                using (var game = new Game1())
                    game.Run();
            }
            
        }
    }
#endif
}
