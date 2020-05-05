using Microsoft.Xna.Framework.Graphics;
using MonoGameProj.Entities.Collections;

namespace MonoGameProj.Managers
{
    public class GameManager
    {
        // Collections
        private EntityList entityList;
        private BulletList bulletList;

        // Managers
        private GameSetupManager gameSetupManager;

        // Rendering
        private RenderingManager renderingManager;

        public GameManager(SpriteBatch spritebatch, Texture2D spriteTex)
        {
            renderingManager = new RenderingManager(spritebatch);

            gameSetupManager = new GameSetupManager();
            var players = gameSetupManager.SetUpPlayers(spriteTex);

            playerMovementManager = gameSetupManager.PlayerMovementManager;
        }

        public void Update()
        {
            
        }

        public void Draw()
        {
            renderingManager.DrawGameObjects(entityList);
        }
    }
}
