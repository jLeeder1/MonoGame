using System.Collections.Generic;
using MonoGameProj.Entities.Players;

namespace MonoGameProj.Managers
{
    public interface IPlayerKeyAssociation
    {
        void AssociateKeysWithPlayers(List<Player> players);
    }
}