using MonoGameProj.Constants;
using MonoGameProj.Entities.Players;
using System.Collections.Generic;

namespace MonoGameProj.Managers
{
    /// <summary>
    /// Class <c>PlayerMovementController</c> updates player positions based on a <c>List<ActionConstants></c> passed in
    /// <seealso>Class <c>PlayerActionResolver</c></seealso>
    /// </summary>
    public class PlayerMovementController : IPlayerMovementController
    {
        public void UpdatePlayerPositions(Player player, List<ActionConstants> actions)
        {
            var currentPosition = player.Position;
            var newPosition = currentPosition;

            if (actions.Contains(ActionConstants.UP))
            {
                newPosition.Y = player.Position.Y + (PlayerConstants.PLAYER_SPEED * WorldConstants.NEGATIVE_NUMBER_MULTIPLIER);
            }

            if (actions.Contains(ActionConstants.LEFT))
            {
                newPosition.X = player.Position.X + PlayerConstants.PLAYER_SPEED * WorldConstants.NEGATIVE_NUMBER_MULTIPLIER;
                player.Direction = ActionConstants.LEFT;
            }

            if (actions.Contains(ActionConstants.DOWN))
            {
                newPosition.Y = player.Position.Y + PlayerConstants.PLAYER_SPEED;
            }

            if (actions.Contains(ActionConstants.RIGHT))
            {
                newPosition.X = player.Position.X + PlayerConstants.PLAYER_SPEED;
                player.Direction = ActionConstants.RIGHT;
            }

            player.Position = newPosition;
        }
    }
}
