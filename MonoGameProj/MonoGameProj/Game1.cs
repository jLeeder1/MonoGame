using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoGameProj.Entities.Player;
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

        // Game SetUp
        private PlayerSetupManager playerSetupManager;
        private GameSetupManager gameSetupManager;
        private PlayerMovementManager playerMovementManager;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";

            deltaTimeCalculator = new DeltaTimeCalculator();
            playerSetupManager = new PlayerSetupManager();
            players = playerSetupManager.SetupPlayers();
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
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
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

            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
