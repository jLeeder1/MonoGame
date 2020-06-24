using Microsoft.Xna.Framework.Input;
using MonoGameProj.Constants;
using MonoGameProj.Entities.Players;
using System.Collections.Generic;
using System.Linq;

namespace MonoGameProj.Managers
{
    /// <summary>
    /// Class <c>PlayerKeyAssociation</c> used to associate keys with <c>ActionConstants</c> to player in form of <c>Dictionary<Keys, ActionConstants></c> to be used to determine actions
    /// <seealso>Class <c>Player</c></seealso>
    /// <seealso>Class <c>PlayerMovementManager</c></seealso>
    /// </summary>
    public class PlayerKeyAssociation : IPlayerKeyAssociation
    {
        public void AssociateKeysWithPlayers(List<Player> players)
        {
            // Dirty way to get it to work for now, need to change
            for (int playersIndex = 0; playersIndex < players.Count; playersIndex++)
            {
                if (playersIndex == 0)
                {
                    players.ElementAt(playersIndex).PlayerControlKeys = GetPlayerOneKeys();
                }
                else if (playersIndex == 1)
                {
                    players.ElementAt(playersIndex).PlayerControlKeys = GetPlayerTwoKeys();
                }
            }
        }

        private Dictionary<Keys, ActionConstants> GetPlayerOneKeys()
        {
            return new Dictionary<Keys, ActionConstants>()
            {
                {Keys.W, ActionConstants.UP},
                {Keys.A, ActionConstants.LEFT},
                {Keys.S, ActionConstants.DOWN},
                {Keys.D, ActionConstants.RIGHT},
                {Keys.T, ActionConstants.SHOOT},
            };
        }

        private Dictionary<Keys, ActionConstants> GetPlayerTwoKeys()
        {
            return new Dictionary<Keys, ActionConstants>()
            {
                {Keys.Up, ActionConstants.UP},
                {Keys.Left, ActionConstants.LEFT},
                {Keys.Down, ActionConstants.DOWN},
                {Keys.Right, ActionConstants.RIGHT},
                {Keys.OemOpenBrackets, ActionConstants.SHOOT},
            };
        }
    }
}
