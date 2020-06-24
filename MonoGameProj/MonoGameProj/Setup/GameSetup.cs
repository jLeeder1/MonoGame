using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using MonoGameProj.Assets;
using MonoGameProj.Entities.Collections;
using MonoGameProj.Entities.Players;
using System.Collections.Generic;

namespace MonoGameProj.Managers
{
    public class GameSetup : IGameSetup
    {
        private readonly PlayerSetup playerSetup;
        private IPlayerKeyAssociation playerKeyAssociationManager;

        public GameSetup(IPlayerKeyAssociation playerKeyAssociation)
        {
            playerKeyAssociationManager = playerKeyAssociation;
            playerSetup = new PlayerSetup();
        }

        public PlayerList SetUpPlayers()
        {
            var players = playerSetup.SetupPlayers(1);
            SetUpPlayerControls(players);

            return new PlayerList(players);
        }

        private void SetUpPlayerControls(List<Player> players)
        {
            this.playerKeyAssociationManager.AssociateKeysWithPlayers(players);
        }
    }
}
