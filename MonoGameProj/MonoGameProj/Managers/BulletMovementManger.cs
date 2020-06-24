using Microsoft.Xna.Framework;
using MonoGameProj.Entities.GameObjects;

namespace MonoGameProj.Managers
{
    public class BulletMovementManger : IBulletMovementManger
    {
        public void Update(Bullet bullet)
        {
            if (bullet.Direction == Constants.ActionConstants.RIGHT)
            {
                // This eems messy, there must be a better way than creating a new position?
                // this is the only way can i call Disposable on the old positon object?
                var updatedXPosition = bullet.Position.X + bullet.BaseSpeed;

                var updatedPosition = new Vector2(updatedXPosition, bullet.Position.Y);

                bullet.Position = updatedPosition;

            }
            else
            {
                var updatedXPosition = bullet.Position.X - bullet.BaseSpeed;

                var updatedPosition = new Vector2(updatedXPosition, bullet.Position.Y);

                bullet.Position = updatedPosition;
            }
        }
    }
}
