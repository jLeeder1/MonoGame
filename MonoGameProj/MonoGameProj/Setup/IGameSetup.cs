using MonoGameProj.Entities.Collections;
using MonoGameProj.Entities.Players;
using System.Collections.Generic;

namespace MonoGameProj.Managers
{
    public interface IGameSetup
    {
        List<Player> SetUpPlayers();
    }
}