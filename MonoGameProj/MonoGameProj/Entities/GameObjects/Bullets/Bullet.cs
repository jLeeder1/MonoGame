using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MonoGameProj.Constants;

namespace MonoGameProj.Entities.GameObjects
{
    public class Bullet
    {
        public Bullet(Vector2 newPostion)
        {
            Position = newPostion;
        }

        public int Weight { get; set; }
        public int BaseSpeed { get; set; }
        public int Speed { get; set; }
        public string Sprite { get; set; }
        public Vector2 Position { get; set; }
        public EntityDimensions Dimensions { get; set; }
        public BulletType BulletType { get; set; }
    }
}
