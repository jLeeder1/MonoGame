using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using MonoGameProj.Constants;

namespace MonoGameProj.Assets
{
    public class AssetLoader
    {
        private ContentManager content;

        public AssetLoader(ContentManager content)
        {
            this.content = content;
        }

        public Texture2D RetrieveSpiteTexture(string textureName)
        {
           return content.Load<Texture2D>(textureName);
        }
    }
}
