using Microsoft.Xna.Framework.Input;
using MonoGameProj.Entities.Player;
using MonoGameProj.Logic.Input;
using System.Collections.Generic;

namespace MonoGameProj.Managers
{
    public class GameSetupManager
    {
        private PlayerKeyAssociationManager playerKeyAssociationManager;

        public GameSetupManager(List<Player> players)
        {
            // Dependencies
            playerKeyAssociationManager = new PlayerKeyAssociationManager();

            // Setup
            SetUpPlayerControls(players);
            PlayerMovementManager = new PlayerMovementManager(players, IMyKeyboardInput test);
        }

        private void SetUpPlayerControls(List<Player> players)
        {
            this.playerKeyAssociationManager.AssociateKeysWithPlayers(players);
        }

        public PlayerMovementManager PlayerMovementManager { get; private set; }

    }
}
