using MonoGameProj.Constants;
using MonoGameProj.Entities.Collections;
using MonoGameProj.Entities.GameObjects;
using MonoGameProj.Entities.Players;
using MonoGameProj.Shooting;
using System.Collections.Generic;

namespace MonoGameProj.Managers.PlayerMangers
{
    /// <summary>
    /// Class <c>PlayerActionManager</c> controls player movment and shooting
    /// </summary>
    public class PlayerActionManager : IPlayerActionManager
    {
        private readonly IPlayerActionResolver actionResolver;
        private readonly IPlayerMovementController playerMovementController;
        private readonly IPlayerShootingController playerShootingController;

        public PlayerActionManager(
            IPlayerActionResolver playerActionResolver,
            IPlayerMovementController playerMovementController,
            IPlayerShootingController playerShootingController)
        {
            this.actionResolver = playerActionResolver;
            this.playerMovementController = playerMovementController;
            this.playerShootingController = playerShootingController;
        }

        public void HandlePlayerActions(Player player, IGameCollection<Bullet> bulletList)
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
