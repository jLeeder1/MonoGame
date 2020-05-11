using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MonoGameProj.Entities.GameObjects.Guns;
using MonoGameProj.Enums;

namespace MonoGameProj.Entities
{
    public class Entity
    {
        public Entity(Vector2 position, Gun gun)
        {
            Position = position;
            CurrentGun = gun;
            EntityType = EntityType.NPC;
        }

        public Texture2D Sprite { get; set; }

        public Vector2 Position { get; set; }

        public Gun CurrentGun { get; set; }

        public EntityType EntityType { get; set; }
    }
}
