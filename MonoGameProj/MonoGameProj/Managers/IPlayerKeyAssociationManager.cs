using System.Collections.Generic;
using MonoGameProj.Entities.Player;

namespace MonoGameProj.Managers
{
    public interface IPlayerKeyAssociationManager
    {
        void AssociateKeysWithPlayers(List<Player> players);
    }
}