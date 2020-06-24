using Microsoft.Xna.Framework;
using MonoGameProj.Constants;
using MonoGameProj.Entities.GameObjects;

namespace MonoGameProj.Factories
{
    public interface IBulletFactory
    {
        Bullet CreateBullet(BulletType bulletType, Vector2 position, ActionConstants direction);
    }
}