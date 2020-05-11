using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MonoGameProj.Entities;
using MonoGameProj.Entities.GameObjects;
using MonoGameProj.Entities.Players;
using System.Collections.Generic;

namespace MonoGameProj.Managers
{
    public class RenderingManager
    {
        public void DrawBullets(List<Bullet> bullets, SpriteBatch spriteBatch)
        {
            foreach(Bullet bullet in bullets)
            {
                spriteBatch.Draw(bullet.BulletSprite, bullet.Position, Color.White);
            }
        }

        public void DrawEntities(List<Entity> entities, SpriteBatch spriteBatch)
        {
            foreach (Entity entity in entities)
            {
                spriteBatch.Draw(entity.Sprite, entity.Position, Color.White);
            }
        }

        public void DrawPlayers(List<Player> players, SpriteBatch spriteBatch)
        {
            foreach (Player player in players)
            {
                spriteBatch.Draw(player.Sprite, player.Position, Color.White);
            }
        }
    }
}
