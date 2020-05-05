﻿using MonoGameProj.Entities.GameObjects;
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

        public void AddBulletToList(Bullet bullet)
        {
            bullets.Add(bullet);
        }

        public void RemoveBulletFromList(Bullet bullet)
        {
            bullets.Remove(bullet);
        }
    }
}
