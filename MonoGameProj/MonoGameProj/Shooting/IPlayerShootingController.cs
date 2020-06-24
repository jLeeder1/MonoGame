using System.Collections.Generic;
using MonoGameProj.Constants;
using MonoGameProj.Entities.Collections;
using MonoGameProj.Entities.GameObjects;
using MonoGameProj.Entities.Players;

namespace MonoGameProj.Shooting
{
    public interface IPlayerShootingController
    {
        void HandlePlayerShooting(List<ActionConstants> actions, Player player, IGameCollection<Bullet> bulletList);
    }
}