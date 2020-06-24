using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace MonoGameProj.Assets
{
    /// <summary>
    /// Class <c>AssetLoader</c> uses Monogames <c>ContentManager</c> to load game assets into <c>Dictionary<string, Texture2D></c> for shared use in game
    /// </summary>
    public class AssetLoader
    {
        private ContentManager content;
        private IDictionary<string, Texture2D> textureMap;

        public AssetLoader(ContentManager content)
        {
            this.content = content;
            textureMap = new Dictionary<string, Texture2D>();
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
    }
}
