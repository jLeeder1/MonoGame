using Microsoft.Xna.Framework.Input;
using MonoGameProj.Constants;
using MonoGameProj.Entities.Players;
using MonoGameProj.Logic.Input;
using System.Collections.Generic;
using System.Linq;

namespace MonoGameProj.Managers
{
    public class PlayerMovementManager
    {
        private MyKeyboardInput myKeyboardInput;

        public PlayerMovementManager()
        {
            myKeyboardInput = new MyKeyboardInput();
        }

        public void UpdatePlayerPositions(List<Player> players)
        {
            foreach(Player player in players)
            {
                var actions = DetermineKeyPressAction(player.PlayerControlKeys);

                if (actions.Any() == true)
                {
                    UpdatePlayerPostion(player, actions);
                }
            }
        }

        private List<DirectionConstants> DetermineKeyPressAction(List<Keys> keys)
        {
            return myKeyboardInput.RetrieveKeyPressActions(keys);
        }

        private void UpdatePlayerPostion(Player player, List<DirectionConstants> directions)
        {
            var currentPosition = player.PlayerPosition;
            var newPosition = currentPosition;

            if (directions.Contains(DirectionConstants.UP))
            {
                newPosition.Y = currentPosition.Y + (PlayerConstants.PLAYER_SPEED * WorldConstants.NEGATIVE_NUMBER_MULTIPLIER);
            }

            if (directions.Contains(DirectionConstants.LEFT))
            {
                newPosition.X = currentPosition.X + PlayerConstants.PLAYER_SPEED * WorldConstants.NEGATIVE_NUMBER_MULTIPLIER;
            }

            if (directions.Contains(DirectionConstants.DOWN))
            {
                newPosition.Y = currentPosition.Y + PlayerConstants.PLAYER_SPEED;
            }

            if (directions.Contains(DirectionConstants.RIGHT))
            {
                newPosition.X = currentPosition.X + PlayerConstants.PLAYER_SPEED;
            }

            player.PlayerPosition = newPosition;
        }
    }
}
