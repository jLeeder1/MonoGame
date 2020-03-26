using Microsoft.Xna.Framework;
using MonoGameProj.Logic.Game.DeltaTime;
using System;

namespace MonoGameProj.Logic.Game
{
    public class DeltaTimeCalculator : IDeltaTimeCalculator
    {
        public float DeltaTime { get; set; }

        public void UpdateDeltaTime(GameTime gameTime)
        {
            this.DeltaTime = (float)gameTime.ElapsedGameTime.TotalSeconds;
            Console.WriteLine("Calc is working");
        }
    }
}
