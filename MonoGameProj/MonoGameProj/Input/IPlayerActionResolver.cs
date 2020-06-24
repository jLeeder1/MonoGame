using System.Collections.Generic;
using MonoGameProj.Constants;
using MonoGameProj.Entities.Players;

namespace MonoGameProj.Managers.PlayerMangers
{
    public interface IPlayerActionResolver
    {
        List<ActionConstants> ResolvePlayerActions(Player player);
    }
}