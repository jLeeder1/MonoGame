using MonoGameProj.Entities.GameObjects;
using System.Collections.Generic;

namespace MonoGameProj.Managers
{
    public class BulletManager
    {
        private List<Bullet> bullets;

        public BulletManager()
        {
            bullets = new List<Bullet>();
        }
    }
}
