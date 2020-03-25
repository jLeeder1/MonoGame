﻿using Microsoft.Xna.Framework;

namespace MonoGameProj.Logic.Game
{
    public class DeltaTimeCalculator
    {
        public float DeltaTime { get; set; }

        public void UpdateDeltaTime(GameTime gameTime)
        {
            this.DeltaTime = (float)gameTime.ElapsedGameTime.TotalSeconds;
        }
    }
}