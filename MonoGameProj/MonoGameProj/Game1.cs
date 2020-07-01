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
using MonoGame.Extended.Tiled;
using MonoGame.Extended.Tiled.Renderers;
using MonoGame.Extended;
using MonoGame.Extended.ViewportAdapters;

namespace MonoGameProj
{
    /// <summary>
    /// Class <c>Game1</c> main game loop that manages game running, updating and rendering for the duration of it's life
    /// </summary>
    public class Game1 : Game
    {
        // Assets
        private readonly AssetLoader assetLoader;

        // Collections
        private readonly IGameCollection<Entity> entityList;
        private readonly IGameCollection<Player> playerList;
        private readonly IGameCollection<Bullet> bulletList;

        // Game
        private readonly GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;
        private readonly IDeltaTimeCalculator deltaTimeCalculator;
        private readonly IGameSetup gameSetup;

        // Managers
        private readonly IPlayerActionManager playerActionManager;
        private readonly IBulletMovementManger bulletMovementManger;

        // Rendering
        private readonly RenderingManager renderingManager;

        private TiledMap map;
        private TiledMapRenderer mapRenderer;
        private OrthographicCamera camera;

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

            map = Content.Load<TiledMap>("C:\\Users\\joshu\\Documents\\MonoGameProj\\MonoGame\\MonoGameProj\\Levels\\firstMap");
            mapRenderer = new TiledMapRenderer(GraphicsDevice);

            var viewportAdapter = new BoxingViewportAdapter(Window, GraphicsDevice, 800, 480);
            camera = new OrthographicCamera(viewportAdapter);

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

            mapRenderer.Update(gameTime); // doesn;t take 2 arguements apparently?

            deltaTimeCalculator.UpdateDeltaTime(gameTime);
            var deltaTime = deltaTimeCalculator.DeltaTime;

            foreach (Player player in playerList.GetEntityList())
            {
                playerActionManager.HandlePlayerActions(player, bulletList, deltaTime);
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
            spriteBatch.Begin(transformMatrix: camera.GetViewMatrix(), samplerState: SamplerState.PointClamp);

            renderingManager.DrawPlayers(playerList.GetEntityList(), spriteBatch);
            renderingManager.DrawBullets(bulletList.GetEntityList(), spriteBatch);
            mapRenderer.Draw();

            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
