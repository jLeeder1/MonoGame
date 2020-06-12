using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MonoGameProj.Assets;
using MonoGameProj.Entities;
using MonoGameProj.Entities.GameObjects;
using MonoGameProj.Entities.Players;
using System.Collections.Generic;

namespace MonoGameProj.Managers
{
    public class RenderingManager
    {
        private AssetLoader assetLoader;

        public RenderingManager(AssetLoader assetLoader)
        {
            this.assetLoader = assetLoader;
        }

        public void DrawBullets(List<Bullet> bullets, SpriteBatch spriteBatch)
        {
            foreach(Bullet bullet in bullets)
            {
                spriteBatch.Draw(assetLoader.RetrieveSpiteTexture(bullet.Sprite), bullet.Position, Color.White);
            }
        }

        public void DrawEntities(List<Entity> entities, SpriteBatch spriteBatch)
        {
            foreach (Entity entity in entities)
            {
                spriteBatch.Draw(assetLoader.RetrieveSpiteTexture(entity.Sprite), entity.Position, Color.White);
            }
        }

        public void DrawPlayers(List<Player> players, SpriteBatch spriteBatch)
        {
            foreach (Player player in players)
            {
                spriteBatch.Draw(assetLoader.RetrieveSpiteTexture(player.Sprite), player.Position, Color.White);
            }
        }
    }
}
