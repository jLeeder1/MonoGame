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
            // Why not injkect the movementManager and have this class as more of a mapper
        }

        private void SetUpPlayerControls(List<Player> players)
        {
            this.playerKeyAssociationManager.AssociateKeysWithPlayers(players);
        }

        // think this is code smell too, so this class is supposed to set things up
        // maybe it should set things up and then return them from am ethod rather thasn keeping hold of them in properties?
        public PlayerMovementManager PlayerMovementManager { get; private set; }

    }
}
