using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace MonoGameProj.Logic.Input
{
    public class MyKeyboardInput
    {
        private const int moveAmount = 5;

        public Vector2 HandlePlayerMovement(KeyboardState keyboardState, Vector2 currentPosition)
        {
            if (keyboardState.IsKeyDown(Keys.None))
            {
                return currentPosition;
            }

            if (keyboardState.IsKeyDown(Keys.W))
            {
                return new Vector2(currentPosition.X, currentPosition.Y += (moveAmount * -1));
            }

            if (keyboardState.IsKeyDown(Keys.A))
            {
                return new Vector2(currentPosition.X += (moveAmount * -1), currentPosition.Y);
            }

            if (keyboardState.IsKeyDown(Keys.S))
            {
                return new Vector2(currentPosition.X, currentPosition.Y += moveAmount);
            }

            if (keyboardState.IsKeyDown(Keys.D))
            {
                return new Vector2(currentPosition.X += moveAmount, currentPosition.Y);
            }

            return currentPosition;
        }
    }
}
