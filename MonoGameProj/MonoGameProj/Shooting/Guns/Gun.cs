﻿using Microsoft.Xna.Framework;
using MonoGameProj.Constants;
using MonoGameProj.Factories;

/// <summary>
/// Class <c>Gun</c> models the shared properties of a gun and provides logic to shoot bullets
/// </summary>
namespace MonoGameProj.Entities.GameObjects.Guns
{
    public class Gun
    {
        private readonly BulletFactory bulletFactory;
        protected BulletType bulletType;
        protected EntityDimensions dimensions;
        protected float rateOfFire;
        
        public Gun() 
        { 
            this.bulletFactory = new BulletFactory();
        }

        public Bullet Shoot(Vector2 entityCurrentPos, EntityDimensions dimensions, ActionConstants direction)
        {
            Vector2 position;
            var yPos = entityCurrentPos.Y + (dimensions.Height / 2) + 50;

            if (direction == ActionConstants.RIGHT)
            {
                var xPos = entityCurrentPos.X + dimensions.Width;
                position = new Vector2(xPos, yPos);
            }
            else
            {
                var xPos = entityCurrentPos.X - dimensions.Width;
                position = new Vector2(xPos, yPos);
            }

            return bulletFactory.CreateBullet(bulletType, position, direction);
        }

        public bool GunCanShoot(float deltaTime)
        {
            rateOfFire -= deltaTime;

            if(rateOfFire <= 0)
            {
                rateOfFire = EntityConstants.SmallHandgunConstants.Small_Handgun_Rate_Of_Fire;
                return true;
            }

            return false;
        }
    }
}
