using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using MonoGameProj.Entities.Collections;
using MonoGameProj.Entities.Players;
using System.Collections.Generic;

namespace MonoGameProj.Managers
{
    public class GameSetupManager
    {
        private readonly PlayerSetupManager playerSetupManager;
        private PlayerKeyAssociationManager playerKeyAssociationManager;
        private ContentManager content;

        public GameSetupManager(ContentManager content)
        {
            this.content = content;
            playerKeyAssociationManager = new PlayerKeyAssociationManager();
            playerSetupManager = new PlayerSetupManager(content);
        }

        public PlayerList SetUpPlayers()
        {
            var players = playerSetupManager.SetupPlayers(1);
            SetUpPlayerControls(players);

            return new PlayerList(players);
        }

        private void SetUpPlayerControls(List<Player> players)
        {
            this.playerKeyAssociationManager.AssociateKeysWithPlayers(players);
        }

        // Need to change this
        public PlayerMovementManager PlayerMovementManager { get; private set; }

    }
}
