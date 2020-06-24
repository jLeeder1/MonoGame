using MonoGameProj.Entities.Players;
using System.Collections.Generic;

namespace MonoGameProj.Managers
{
    public class GameSetup : IGameSetup
    {
        private readonly IPlayerSetup playerSetup;
        private readonly IPlayerKeyAssociation playerKeyAssociationManager;

        public GameSetup(IPlayerSetup playerSetup, IPlayerKeyAssociation playerKeyAssociation)
        {
            playerKeyAssociationManager = playerKeyAssociation;
            this.playerSetup = playerSetup;
        }

        public List<Player> SetUpPlayers()
        {
            var players = playerSetup.SetupPlayers(1);
            SetUpPlayerControls(players);

            return players;
        }

        private void SetUpPlayerControls(List<Player> players)
        {
            this.playerKeyAssociationManager.AssociateKeysWithPlayers(players);
        }
    }
}
