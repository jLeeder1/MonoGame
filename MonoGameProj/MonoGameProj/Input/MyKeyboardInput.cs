using Microsoft.Xna.Framework.Input;
using MonoGameProj.Constants;
using System.Collections.Generic;

namespace MonoGameProj.Logic.Input
{
    public class MyKeyboardInput
    {
        public List<DirectionConstants> RetrieveKeyPressActions(List<Keys> keys)
        {
            KeyboardState keyboardState = Keyboard.GetState();
            var listOfDirectionsToMove = new List<DirectionConstants>();

            if (keyboardState.IsKeyDown(Keys.W) &&
                keys.Contains(Keys.W))
            {
                listOfDirectionsToMove.Add(DirectionConstants.UP);
            }

            if (keyboardState.IsKeyDown(Keys.A) &&
                keys.Contains(Keys.A))
            {
                listOfDirectionsToMove.Add(DirectionConstants.LEFT);
            }

            if (keyboardState.IsKeyDown(Keys.S) &&
                keys.Contains(Keys.S))
            {
                listOfDirectionsToMove.Add(DirectionConstants.DOWN);
            }

            if (keyboardState.IsKeyDown(Keys.D) &&
                keys.Contains(Keys.D))
            {
                listOfDirectionsToMove.Add(DirectionConstants.RIGHT);
            }

            return listOfDirectionsToMove;
        }
    }
}