using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using MonoGameProj.Constants;
using MonoGameProj.Logic.Game.DeltaTime;
using System.Collections.Generic;

namespace MonoGameProj.Logic.Input
{
    public class MyKeyboardInput : IMyKeyboardInput
    {
        public List<DirectionConstants> RetrieveKeyPressActions(List<Keys> keys)
        {
            KeyboardState keyboardState = Keyboard.GetState();
            var listOfDirectionsToMove = new List<DirectionConstants>();

            if (keyboardState.IsKeyDown(Keys.W) &&
                keys.Contains(Keys.W))
            {
                listOfDirectionsToMove.Add(DirectionConstants.DIRECTION_UP);
            }

            if (keyboardState.IsKeyDown(Keys.A) &&
                keys.Contains(Keys.A))
            {
                listOfDirectionsToMove.Add(DirectionConstants.DIRECTION_LEFT);
            }

            if (keyboardState.IsKeyDown(Keys.S) &&
                keys.Contains(Keys.S))
            {
                listOfDirectionsToMove.Add(DirectionConstants.DIRECTION_DOWN);
            }

            if (keyboardState.IsKeyDown(Keys.D) &&
                keys.Contains(Keys.D))
            {
                listOfDirectionsToMove.Add(DirectionConstants.DIRECTION_RIGHT);
            }

            return listOfDirectionsToMove;
        }
    }
}