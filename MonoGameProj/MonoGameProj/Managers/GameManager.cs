using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using MonoGameProj.Assets;
using MonoGameProj.Entities.Collections;
using MonoGameProj.Entities.GameObjects;
using MonoGameProj.Entities.Players;
using MonoGameProj.Managers.PlayerMangers;
using System;

namespace MonoGameProj.Managers
{
    public class GameManager
    {
        // Collections
        private EntityList entityList;
        private PlayerList playerList;
        private BulletList bulletList;

        // Managers
        private IGameSetup gameSetupManager;
        private PlayerActionManager playerActionManager;
        private BulletMovementManger bulletMovementManger;

        // Assets
        private AssetLoader assetLoader;

        // Rendering
        private RenderingManager renderingManager;

        public GameManager(ContentManager content, IGameSetup gameSetupManager)
        {
            // Assets
            assetLoader = new AssetLoader(content);

            // Collections
            entityList = new EntityList();
            bulletList = new BulletList();

            // Rendering
            renderingManager = new RenderingManager(assetLoader);

            // Game setup
            this.gameSetupManager = gameSetupManager;
            playerList = gameSetupManager.SetUpPlayers();
            playerActionManager = new PlayerActionManager();
            bulletMovementManger = new BulletMovementManger();
        }

        public void Update()
        {
            foreach(Player player in playerList.GetEntityList())
            {
                playerActionManager.HandlePlayerActions(player, bulletList);
            }

            foreach(Bullet bullet in bulletList.GetEntityList())
            {
                bulletMovementManger.Update(bullet);
            }

            Console.WriteLine(bulletList.GetEntityList().Count);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            renderingManager.DrawPlayers(playerList.GetEntityList(), spriteBatch);
            renderingManager.DrawBullets(bulletList.GetEntityList(), spriteBatch);
        }
    }
}
