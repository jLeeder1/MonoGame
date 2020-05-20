using Microsoft.Xna.Framework;
using MonoGameProj.Constants;
using MonoGameProj.Factories;
using System;

namespace MonoGameProj.Entities.GameObjects.Guns
{
    public class Gun
    {
        private BulletFactory bulletFactory;
        protected BulletType bulletType;
        protected EntityDimensions dimensions;

        public Gun()
        {
            bulletFactory = new BulletFactory();
        }

        public Bullet Shoot(Vector2 entityCurrentPos, EntityDimensions dimensions, ActionConstants direction)
        {
            Vector2 position;
            var yPos = entityCurrentPos.Y + (dimensions.Height / 2);

            if (direction == ActionConstants.RIGHT)
            {
                var xPos = entityCurrentPos.X + dimensions.Width;
                position = new Vector2(xPos, yPos);
                
            }
            else
            {
                var xPos = entityCurrentPos.X;
                position = new Vector2(xPos, yPos);
            }

            return bulletFactory.CreateBullet(bulletType, position);
        }
    }
}
