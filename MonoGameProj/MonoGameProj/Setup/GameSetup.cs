using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using MonoGameProj.Entities.Collections;
using MonoGameProj.Entities.Players;
using System.Collections.Generic;

namespace MonoGameProj.Managers
{
    public class GameSetup
    {
        private readonly PlayerSetup playerSetupManager;
        private PlayerKeyAssociation playerKeyAssociationManager;
        private ContentManager content;

        public GameSetup(ContentManager content)
        {
            this.content = content;
            playerKeyAssociationManager = new PlayerKeyAssociation();
            playerSetupManager = new PlayerSetup(content);
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
    }
}
