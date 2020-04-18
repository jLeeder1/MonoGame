using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MonoGameProj.Entities.GameObjects.Guns;

namespace MonoGameProj.Entities
{
    public class Entity
    {
        public Entity(Texture2D sprite, Vector2 position, Gun gun)
        {
            Sprite = sprite;
            Position = position;
            CurrentGun = gun;
        }

        public Texture2D Sprite { get; set; }

        public Vector2 Position { get; set; }

        public Gun CurrentGun { get; set; }
    }
}
