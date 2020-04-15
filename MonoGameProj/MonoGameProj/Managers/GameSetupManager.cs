using Microsoft.Xna.Framework.Input;
using MonoGameProj.Entities.Player;
using MonoGameProj.Logic.Input;
using System.Collections.Generic;

namespace MonoGameProj.Managers
{
    public class GameSetupManager
    {
        private readonly IPlayerKeyAssociationManager playerKeyAssociationManager;
        private readonly IPlayerMovementManager playerMovementManager;
        private readonly IMyKeyboardInput myKeyboardInput;

        public GameSetupManager(List<Player> players, IPlayerKeyAssociationManager playerKeyAssociationManager, IPlayerMovementManager playerMovementManager, IMyKeyboardInput myKeyboardInput)
        {
            // Dependencies
            this.playerKeyAssociationManager = playerKeyAssociationManager;
            this.playerMovementManager = playerMovementManager;
            this.myKeyboardInput = myKeyboardInput;

            // Setup
            SetUpPlayerControls(players);
            PlayerMovementManager = new PlayerMovementManager(players, myKeyboardInput);
        }

        private void SetUpPlayerControls(List<Player> players)
        {
            this.playerKeyAssociationManager.AssociateKeysWithPlayers(players);
        }

        // think this is code smell too, so this class is supposed to set things up
        // maybe it should set things up and then return them from a method rather than keeping hold of them in properties?
        public PlayerMovementManager PlayerMovementManager { get; private set; }

    }
}
