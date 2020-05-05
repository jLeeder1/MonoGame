using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MonoGameProj.Entities;
using MonoGameProj.Entities.GameObjects;
using System;
using System.Collections.Generic;

namespace MonoGameProj.Managers
{
    public class RenderingManager
    {
        private SpriteBatch spriteBatch;

        public RenderingManager(SpriteBatch spriteBatch)
        {
            this.spriteBatch = spriteBatch;
        }

        public void DrawGameObjects(List<Entity> entities)
        {
            // DrawBullets(bullets);
            DrawEntities(entities);
        }

        private void DrawBullets(List<Bullet> bullets)
        {
            foreach(Bullet bullet in bullets)
            {
                spriteBatch.Draw(bullet.BulletSprite, bullet.Position, Color.White);
            }
        }

        private void DrawEntities(List<Entity> entities)
        {
            foreach (Entity entity in entities)
            {
                spriteBatch.Draw(entity.Sprite, entity.Position, Color.White);
            }
        }
    }
}
