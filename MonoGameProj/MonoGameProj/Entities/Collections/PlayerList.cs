using MonoGameProj.Entities.Players;
using System.Collections.Generic;

namespace MonoGameProj.Entities.Collections
{
    public class PlayerList : IGameCollection<Player>
    {
        private List<Player> players;

        public PlayerList()
        {
            players = new List<Player>();
        }

        public PlayerList(List<Player> players)
        {
            this.players = players;
        }

        public List<Player> GetEntityList()
        {
            return players;
        }

        public void AddEntity(Player player)
        {
            players.Add(player);
        }

        public void RemoveEntity(Player player)
        {
            players.Remove(player);
        }

        public void AddListRange(List<Player> entities)
        {
            players.AddRange(entities);
        }
    }
}
