using MonoGameProj.Constants;
using MonoGameProj.Entities.Collections;
using MonoGameProj.Entities.GameObjects;
using MonoGameProj.Entities.Players;
using System.Collections.Generic;

namespace MonoGameProj.Shooting
{
    /// <summary>
    /// Class <c>PlayerShootingController</c> spawns a bullet from the player in the direction they are facing and adds it to collection of bullets
    /// </summary>
    public class PlayerShootingController : IPlayerShootingController
    {
        public void HandlePlayerShooting(List<ActionConstants> actions, Player player, IGameCollection<Bullet> bulletList, float deltaTime)
        {
            if (!player.CurrentGun.GunCanShoot(deltaTime))
            {
                return;
            }

            if (actions.Contains(ActionConstants.SHOOT))
            {
                var bullet = player.CurrentGun.Shoot(player.Position, player.Dimensions, player.Direction);
                bulletList.AddEntity(bullet);
            }
        }
    }
}
