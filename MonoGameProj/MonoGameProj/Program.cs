using Autofac;
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
            var container = ContainerConfig.Configure();

            using (var scope = container.BeginLifetimeScope())
            {
                var myGame = scope.Resolve<Game1>();
                myGame.Run();
            }
                
        }
    }
#endif
}
