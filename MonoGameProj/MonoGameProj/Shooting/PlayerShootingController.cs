using MonoGameProj.Constants;
using MonoGameProj.Entities.Collections;
using MonoGameProj.Entities.Players;
using System.Collections.Generic;

namespace MonoGameProj.Shooting
{
    public class PlayerShootingController
    {
        public void HandlePlayerShooting(List<ActionConstants> actions, Player player, BulletList bulletList)
        {
            if (actions.Contains(ActionConstants.SHOOT))
            {
                var bullet = player.CurrentGun.Shoot(player.Position, player.Dimensions, player.Direction);
                bulletList.AddEntity(bullet);
            }
        }
    }
}
