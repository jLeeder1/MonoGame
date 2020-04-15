using Microsoft.Xna.Framework;
using MonoGameProj.Constants;
using MonoGameProj.Entities.GameObjects;

namespace MonoGameProj.Factories
{
    public class BulletFactory
    {
        public Bullet CreateBullet(BulletType bulletType, Vector2 position)
        {
            switch (bulletType)
            {
                case BulletType.SMALL_HANDGUN:
                    return new SmallHandgunBullet(position);

                default:
                    return new SmallHandgunBullet(position);
            }
        }
    }
}
