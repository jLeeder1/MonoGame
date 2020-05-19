using MonoGameProj.Entities.GameObjects;
using System.Collections.Generic;

namespace MonoGameProj.Entities.Collections
{
    public class BulletList : IGameCollection<Bullet>
    {
        private List<Bullet> bullets;

        public BulletList()
        {
            bullets = new List<Bullet>();
        }

        public void AddEntity(Bullet entity)
        {
            bullets.Add(entity);
        }

        public void AddListRange(List<Bullet> entities)
        {
            bullets.AddRange(entities);
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
