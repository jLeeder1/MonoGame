using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoGameProj.Entities.Collections;
using MonoGameProj.Entities.Players;
using MonoGameProj.Logic.Input;
using System;
using System.Collections.Generic;

namespace MonoGameProj.Managers
{
    public class GameManager
    {
        // Collections
        private EntityList entityList;
        private PlayerList playerList;
        private BulletList bulletList;

        // Managers
        private GameSetupManager gameSetupManager;
        private PlayerMovementManager playerMovementManager;
        private ContentManager content;

        // Rendering
        private RenderingManager renderingManager;

        // Input 
        private MyKeyboardInput myKeyboardInput;

        public GameManager(ContentManager content)
        {
            this.content = content;

            // Collections
            entityList = new EntityList();

            // Rendering
            renderingManager = new RenderingManager();

            // Input
            myKeyboardInput = new MyKeyboardInput();

            // Game setup
            gameSetupManager = new GameSetupManager(content);
            playerList = gameSetupManager.SetUpPlayers();
            playerMovementManager = gameSetupManager.PlayerMovementManager;
        }

        public void Update()
        {
            playerMovementManager.UpdatePlayerPositions(playerList.GetEntityList());
            Console.WriteLine("Game manager update");
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            renderingManager.DrawPlayers(playerList.GetEntityList(), spriteBatch);
        }
    }
}
