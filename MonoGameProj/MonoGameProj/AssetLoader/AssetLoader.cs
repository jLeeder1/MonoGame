using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using MonoGame.Extended.Tiled;
using System.Collections.Generic;

namespace MonoGameProj.Assets
{
    /// <summary>
    /// Class <c>AssetLoader</c> uses Monogames <c>ContentManager</c> to load game assets into <c>Dictionary<string, Texture2D></c> for shared use in game
    /// </summary>
    public class AssetLoader
    {
        private readonly ContentManager content;
        private readonly IDictionary<string, Texture2D> textureMap;
        private readonly IDictionary<string, TiledMap> tiledMaps;

        public AssetLoader(ContentManager content)
        {
            this.content = content;
            textureMap = new Dictionary<string, Texture2D>();
            tiledMaps = new Dictionary<string, TiledMap>();

        }

        /// <summary>
        /// Retrieives a sprite texture based on a give texture name. Stores loaded textures in a <c>Dictionary<string, Texture2D></c>
        /// </summary>
        /// <param name="textureName"></param>
        /// <returns><c>Texture2D</c> of game asset</returns>
        public Texture2D RetrieveSpiteTexture(string textureName)
        {
            if (textureMap.ContainsKey(textureName))
            {
                return textureMap[textureName];
            }
            
            Texture2D loadedTexture = content.Load<Texture2D>(textureName);
            textureMap.Add(textureName, loadedTexture);

            return loadedTexture;
        }

        /// <summary>
        /// Retrieives a TiledMap based on a given name. Stores loaded tildM maps in a <c>Dictionary<string, TiledMap></c>
        /// </summary>
        /// <param name="tiledMapName"></param>
        /// <returns><c>TiledMap</c> of game asset</returns>
        public TiledMap RetrieveTiledMap(string tiledMapName)
        {
            if (tiledMaps.ContainsKey(tiledMapName))
            {
                return tiledMaps[tiledMapName];
            }

            TiledMap loadedMap = content.Load<TiledMap>(tiledMapName);
            tiledMaps.Add(tiledMapName, loadedMap);

            return loadedMap;
        }
    }
}
