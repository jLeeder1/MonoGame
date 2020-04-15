using Microsoft.Xna.Framework.Input;
using MonoGameProj.Constants;
using MonoGameProj.Entities.Player;
using MonoGameProj.Logic.Game.DeltaTime;
using MonoGameProj.Logic.Input;
using System.Collections.Generic;
using System.Linq;

namespace MonoGameProj.Managers
{
    public class PlayerMovementManager : IPlayerMovementManager
    {
        private IList<Player> playerList;
        private IMyKeyboardInput myKeyboardInput;

        public PlayerMovementManager(IList<Player> playerList, IMyKeyboardInput myKeyboardInput)
        {
            this.myKeyboardInput = myKeyboardInput;

            this.playerList = playerList;
        }

        public void UpdatePlayerPositions()
        {
            foreach (Player player in playerList)
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

            if (directions.Contains(DirectionConstants.DIRECTION_UP))
            {
                newPosition.Y = currentPosition.Y + (PlayerConstants.PLAYER_SPEED * WorldConstants.NEGATIVE_NUMBER_MULTIPLIER);
            }

            if (directions.Contains(DirectionConstants.DIRECTION_LEFT))
            {
                newPosition.X = currentPosition.X + PlayerConstants.PLAYER_SPEED * WorldConstants.NEGATIVE_NUMBER_MULTIPLIER;
            }

            if (directions.Contains(DirectionConstants.DIRECTION_DOWN))
            {
                newPosition.Y = currentPosition.Y + PlayerConstants.PLAYER_SPEED;
            }

            if (directions.Contains(DirectionConstants.DIRECTION_RIGHT))
            {
                newPosition.X = currentPosition.X + PlayerConstants.PLAYER_SPEED;
            }

            player.PlayerPosition = newPosition;
        }
    }
}
