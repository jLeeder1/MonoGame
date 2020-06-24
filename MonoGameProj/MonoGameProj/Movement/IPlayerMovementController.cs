using System.Collections.Generic;
using MonoGameProj.Constants;
using MonoGameProj.Entities.Players;

namespace MonoGameProj.Managers
{
    public interface IPlayerMovementController
    {
        void UpdatePlayerPositions(Player player, List<ActionConstants> actions);
    }
}