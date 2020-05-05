using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoGameProj.Entities.Players;
using MonoGameProj.Logic.Game;
using MonoGameProj.Managers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MonoGameProj
{
    public class Game1 : Game
    {
        // Game
        private GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;
        private DeltaTimeCalculator deltaTimeCalculator;
        private List<Player> players;

        // Textures
        private Texture2D firstPlayerSprite;
        private Texture2D bulletSprite;

        // Game SetUp
        private PlayerSetupManager playerSetupManager;
        private GameSetupManager gameSetupManager;
        private PlayerMovementManager playerMovementManager;
        private RenderingManager renderingManager;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";

            deltaTimeCalculator = new DeltaTimeCalculator();
            playerSetupManager = new PlayerSetupManager();
            players = playerSetupManager.SetupPlayers(1, firstPlayerSprite);
            gameSetupManager = new GameSetupManager(players);
            playerMovementManager = gameSetupManager.PlayerMovementManager;
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
            firstPlayerSprite = Content.Load<Texture2D>("target");
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

            playerMovementManager.UpdatePlayerPositions();

            KeyboardState keyboardState = Keyboard.GetState();

            if (keyboardState.IsKeyDown(Keys.P))
            {
                players.First().CurrentGun.Shoot(new Vector2(100, 100), 5, 5, Constants.DirectionConstants.RIGHT);
            }

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

            spriteBatch.Draw(firstPlayerSprite, players.First().PlayerPosition, Color.White);

            spriteBatch.Draw(bulletSprite, new Vector2(100, 100), Color.White);

            // renderingManager.DrawGameObjects(bullets, players, spriteBatch);

            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
