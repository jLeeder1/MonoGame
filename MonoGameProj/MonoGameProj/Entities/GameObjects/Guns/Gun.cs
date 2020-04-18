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

        public Gun()
        {
            bulletFactory = new BulletFactory();
        }

        public Bullet Shoot(Vector2 entityCurrentPos, int entityWidth, int entityHeight, DirectionConstants direction)
        {
            Vector2 position;
            var yPos = entityCurrentPos.Y + (entityHeight / 2);

            if (direction == DirectionConstants.RIGHT)
            {
                var xPos = entityCurrentPos.X + entityWidth;
                position = new Vector2(xPos, yPos);
                
            }
            else
            {
                var xPos = entityCurrentPos.X;
                position = new Vector2(xPos, yPos);
            }

            // FOR DEBUGGING WHILE BULLET DRAW AND MOVEMENT LOGIC NOT IMPLEMENTED
            Console.WriteLine("Bang");

            return bulletFactory.CreateBullet(bulletType, position);
        }
    }
}
