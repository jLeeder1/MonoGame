using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using MonoGameProj.Assets;
using MonoGameProj.Entities;
using MonoGameProj.Entities.Collections;
using MonoGameProj.Entities.GameObjects;
using MonoGameProj.Entities.Players;
using MonoGameProj.Managers.PlayerMangers;
using System;

namespace MonoGameProj.Managers
{
    public class GameManager
    {
        /*
        // Collections
        private IGameCollection<Entity> entityList;
        private IGameCollection<Player> playerList;
        private IGameCollection<Bullet> bulletList;

        // Managers
        private IGameSetup gameSetupManager;
        private PlayerActionManager playerActionManager;
        private BulletMovementManger bulletMovementManger;

        // Assets
        private AssetLoader assetLoader;

        // Rendering
        private RenderingManager renderingManager;

        public GameManager(
            ContentManager content, 
            IGameSetup gameSetupManager, 
            IGameCollection<Entity> entityList,
            IGameCollection<Player> playerList,
            IGameCollection<Bullet> bulletList)
        {
            // Assets
            assetLoader = new AssetLoader(content);

            // Collections
            this.entityList = entityList;
            this.playerList = playerList;
            this.bulletList = bulletList;

            // Rendering
            renderingManager = new RenderingManager(assetLoader);

            // Game setup
            this.gameSetupManager = gameSetupManager;
            playerList.AddListRange(gameSetupManager.SetUpPlayers());
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
        */
    }
}
