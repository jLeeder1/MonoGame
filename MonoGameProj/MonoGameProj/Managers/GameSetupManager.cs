using Microsoft.Xna.Framework.Graphics;
using MonoGameProj.Entities.Players;
using System.Collections.Generic;

namespace MonoGameProj.Managers
{
    public class GameSetupManager
    {
        private PlayerSetupManager playerSetupManager;
        private PlayerKeyAssociationManager playerKeyAssociationManager;

        public GameSetupManager()
        {
            // Dependencies
            playerKeyAssociationManager = new PlayerKeyAssociationManager();

        }

        public List<Player> SetUpPlayers(Texture2D spriteTex)
        {
            var players = playerSetupManager.SetupPlayers(1, spriteTex);
            SetUpPlayerControls(players);

            return players;
        }

        private void SetUpPlayerControls(List<Player> players)
        {
            this.playerKeyAssociationManager.AssociateKeysWithPlayers(players);
        }

        public PlayerMovementManager PlayerMovementManager { get; private set; }

    }
}
