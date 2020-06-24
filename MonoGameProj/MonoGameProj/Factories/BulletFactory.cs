using Microsoft.Xna.Framework;
using MonoGameProj.Constants;
using MonoGameProj.Entities.GameObjects;

namespace MonoGameProj.Factories
{
    public class BulletFactory : IBulletFactory
    {
        public Bullet CreateBullet(BulletType bulletType, Vector2 position, ActionConstants direction)
        {
            switch (bulletType)
            {
                case BulletType.SMALL_HANDGUN:
                    return new SmallHandgunBullet(position, direction);

                default:
                    return new SmallHandgunBullet(position, direction);
            }
        }
    }
}
