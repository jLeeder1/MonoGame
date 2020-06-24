using Microsoft.Xna.Framework;

namespace MonoGameProj.Logic.Game
{
    /// <summary>
    /// Class <c>DeltaTimeCalculator</c> tracks DeltaTime in game based on GameTime <para>gameTime</para> from Monogames <c>Game1</c>
    /// </summary>
    public class DeltaTimeCalculator : IDeltaTimeCalculator
    {
        public float DeltaTime { get; set; }

        public void UpdateDeltaTime(GameTime gameTime)
        {
            this.DeltaTime = (float)gameTime.ElapsedGameTime.TotalSeconds;
        }
    }
}
