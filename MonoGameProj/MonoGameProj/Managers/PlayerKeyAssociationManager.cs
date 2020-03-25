using Microsoft.Xna.Framework.Input;
using MonoGameProj.Entities.Player;
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
            }
        }

        private List<Keys> GetPlayerOneKeys()
        {
            return new List<Keys>
            {
                Keys.W,
                Keys.A,
                Keys.S,
                Keys.D
            };
        }
    }
}
