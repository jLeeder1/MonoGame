using Microsoft.Xna.Framework;

namespace MonoGameProj.Logic.Game
{
    public interface IDeltaTimeCalculator
    {
        float DeltaTime { get; set; }

        void UpdateDeltaTime(GameTime gameTime);

        float GetDeltaTime(GameTime gameTime);
    }
}