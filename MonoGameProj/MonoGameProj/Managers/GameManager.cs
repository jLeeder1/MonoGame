using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using MonoGameProj.Entities.Collections;
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
        private GameSetup gameSetupManager;
        private PlayerActionManager playerActionManager;

        // Rendering
        private RenderingManager renderingManager;

        public GameManager(ContentManager content)
        {
            // Collections
            entityList = new EntityList();
            bulletList = new BulletList();

            // Rendering
            renderingManager = new RenderingManager();

            // Game setup
            gameSetupManager = new GameSetup(content);
            playerList = gameSetupManager.SetUpPlayers();
            playerActionManager = new PlayerActionManager();
        }

        public void Update()
        {
            foreach(Player player in playerList.GetEntityList())
            {
                playerActionManager.HandlePlayerActions(player, bulletList);
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
