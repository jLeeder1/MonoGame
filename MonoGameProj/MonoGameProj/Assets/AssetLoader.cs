using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace MonoGameProj.Assets
{
    public class AssetLoader
    {
        private ContentManager content;
        private IDictionary<string, Texture2D> textureMap;

        public AssetLoader(ContentManager content)
        {
            this.content = content;
            textureMap = new Dictionary<string, Texture2D>();
        }

        public Texture2D RetrieveSpiteTexture(string textureName)
        {
            if (textureMap.ContainsKey(textureName))
            {
                return textureMap["textuireName"];
            }
            
            // If texture is not in the Dictionary load it and add it
            Texture2D loadedTexture = content.Load<Texture2D>(textureName);
            textureMap.Add(textureName, loadedTexture);

            return loadedTexture;
        }
    }
}
