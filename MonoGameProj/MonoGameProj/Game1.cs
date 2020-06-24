using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoGameProj.Assets;
using MonoGameProj.Entities;
using MonoGameProj.Entities.Collections;
using MonoGameProj.Entities.GameObjects;
using MonoGameProj.Entities.Players;
using MonoGameProj.Logic.Game;
using MonoGameProj.Managers;
using MonoGameProj.Managers.PlayerMangers;
using System;

namespace MonoGameProj
{
    public class Game1 : Game
    {
        // Game
        private GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;
        private IDeltaTimeCalculator deltaTimeCalculator;

        // Textures
        private Texture2D bulletSprite;

        // Game manager
        private IGameSetup gameSetup;

        // Collections
        private IGameCollection<Entity> entityList;
        private IGameCollection<Player> playerList;
        private IGameCollection<Bullet> bulletList;

        // Managers
        private IPlayerActionManager playerActionManager;
        private IBulletMovementManger bulletMovementManger;

        // Assets
        private AssetLoader assetLoader;

        // Rendering
        private RenderingManager renderingManager;

        public Game1(
            IGameSetup gameSetup, 
            IDeltaTimeCalculator deltaTimeCalculator,
            IGameCollection<Entity> entityList,
            IGameCollection<Player> playerList,
            IGameCollection<Bullet> bulletList,
            IPlayerActionManager playerActionManager,
            IBulletMovementManger bulletMovementManger)
        {
            this.gameSetup = gameSetup;
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            this.deltaTimeCalculator = deltaTimeCalculator;

            // Assets
            assetLoader = new AssetLoader(Content);

            // Collections
            this.entityList = entityList;
            this.playerList = playerList;
            this.bulletList = bulletList;

            // Rendering
            renderingManager = new RenderingManager(assetLoader);

            // Game setup
            playerList.AddListRange(this.gameSetup.SetUpPlayers());
            this.playerActionManager = playerActionManager;
            this.bulletMovementManger = bulletMovementManger;
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            bulletSprite = Content.Load<Texture2D>("bullet");
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
            spriteBatch.Dispose();
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            deltaTimeCalculator.UpdateDeltaTime(gameTime);
            var deltaTime = deltaTimeCalculator.DeltaTime;

            foreach (Player player in playerList.GetEntityList())
            {
                playerActionManager.HandlePlayerActions(player, bulletList);
            }

            foreach (Bullet bullet in bulletList.GetEntityList())
            {
                bulletMovementManger.Update(bullet);
            }

            Console.WriteLine(playerList.GetEntityList().Count);

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            spriteBatch.Begin();

            renderingManager.DrawPlayers(playerList.GetEntityList(), spriteBatch);
            renderingManager.DrawBullets(bulletList.GetEntityList(), spriteBatch);

            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
