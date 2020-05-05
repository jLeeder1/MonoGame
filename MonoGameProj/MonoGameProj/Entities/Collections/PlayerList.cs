using MonoGameProj.Entities.Players;
using System.Collections.Generic;

namespace MonoGameProj.Entities.Collections
{
    public class PlayerList
    {
        private List<Player> players;

        public PlayerList()
        {
            players = new List<Player>();
        }

        public List<Player> GetEntityList()
        {
            return players;
        }

        public void RemoveEntity(Player player)
        {
            players.Remove(player);
        }
    }
}
