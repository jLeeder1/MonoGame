using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            else if (keyboardState.IsKeyDown(Keys.W))
            {
                return new Vector2(currentPosition.X, currentPosition.Y += (moveAmount * -1));
            }

            else if (keyboardState.IsKeyDown(Keys.A))
            {
                return new Vector2(currentPosition.X += (moveAmount * -1), currentPosition.Y);
            }

            else if (keyboardState.IsKeyDown(Keys.S))
            {
                return new Vector2(currentPosition.X, currentPosition.Y += moveAmount);
            }

            else if (keyboardState.IsKeyDown(Keys.D))
            {
                return new Vector2(currentPosition.X += moveAmount, currentPosition.Y);
            }

            return currentPosition;
        }
    }
}
