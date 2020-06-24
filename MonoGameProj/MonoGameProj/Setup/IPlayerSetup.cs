using System.Collections.Generic;
using MonoGameProj.Entities.Players;

namespace MonoGameProj.Managers
{
    public interface IPlayerSetup
    {
        List<Player> SetupPlayers(int numOfPlayers);
    }
}