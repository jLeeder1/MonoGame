using MonoGameProj.Entities.Collections;
using MonoGameProj.Entities.GameObjects;
using MonoGameProj.Entities.Players;

namespace MonoGameProj.Managers.PlayerMangers
{
    public interface IPlayerActionManager
    {
        void HandlePlayerActions(Player player, IGameCollection<Bullet> bulletList);
    }
}