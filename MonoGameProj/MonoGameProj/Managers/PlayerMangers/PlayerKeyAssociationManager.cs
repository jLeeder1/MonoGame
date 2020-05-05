using Microsoft.Xna.Framework.Input;
using MonoGameProj.Entities.Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonoGameProj.Managers
{
    public class PlayerKeyAssociationManager
    {
        public void AssociateKeysWithPlayers(List<Player> players)
        {
            // Dirty way to get it to work for Now, need to change
            for(int playersIndex = 0; playersIndex < players.Count; playersIndex++)
            {
                if(playersIndex == 0)
                {
                    players.ElementAt(playersIndex).PlayerControlKeys = GetPlayerOneKeys();
                }
                else if(playersIndex == 1)
                {
                    players.ElementAt(playersIndex).PlayerControlKeys = GetPlayerTwoKeys();
                }
            }
        }

        private List<Keys> GetPlayerOneKeys()
        {
            return new List<Keys>
            {
                Keys.W, // Up
                Keys.A, // Down
                Keys.S, // Left
                Keys.D, // Right
                Keys.T  // Shoot
            };
        }

        private List<Keys> GetPlayerTwoKeys()
        {
            return new List<Keys>
            {
                Keys.Up,
                Keys.Left,
                Keys.Down,
                Keys.Right,
                Keys.OemOpenBrackets
            };
        }
    }
}
