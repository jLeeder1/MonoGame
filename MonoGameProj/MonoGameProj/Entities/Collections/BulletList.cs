using MonoGameProj.Entities.GameObjects;
using System.Collections.Generic;

namespace MonoGameProj.Entities.Collections
{
    public class BulletList
    {
        private List<Bullet> bullets;

        public BulletList()
        {
            bullets = new List<Bullet>();
        }

        public List<Bullet> GetEntityList()
        {
            return bullets;
        }

        public void RemoveEntity(Bullet bullet)
        {
            bullets.Remove(bullet);
        }
    }
}
