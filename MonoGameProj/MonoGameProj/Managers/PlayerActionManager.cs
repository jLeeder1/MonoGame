using MonoGameProj.Constants;
using MonoGameProj.Entities.Collections;
using MonoGameProj.Entities.Players;
using MonoGameProj.Shooting;
using System.Collections.Generic;

namespace MonoGameProj.Managers.PlayerMangers
{
    public class PlayerActionManager
    {
        private PlayerActionResolver actionResolver;
        private PlayerMovementController playerMovementController;
        private PlayerShootingController playerShootingController;

        public PlayerActionManager()
        {
            actionResolver = new PlayerActionResolver();
            playerMovementController = new PlayerMovementController();
            playerShootingController = new PlayerShootingController();
        }

        public void HandlePlayerActions(Player player, BulletList bulletList)
        {
            var actions = this.GetPlayerActions(player);

            this.playerShootingController.HandlePlayerShooting(actions, player, bulletList);

            this.playerMovementController.UpdatePlayerPositions(player, actions);
        }

        private List<ActionConstants> GetPlayerActions(Player player)
        {
            return actionResolver.ResolvePlayerActions(player);
        }
    }
}
