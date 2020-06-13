using Microsoft.Xna.Framework;
using MonoGameProj.Constants;

namespace MonoGameProj.Entities.GameObjects
{
    public class Bullet
    {
        public Bullet(Vector2 newPostion, ActionConstants direction)
        {
            Position = newPostion;
            Direction = direction;
        }

        public int Weight { get; set; }
        public int BaseSpeed { get; set; }
        public string Sprite { get; set; }
        public Vector2 Position { get; set; }
        public EntityDimensions Dimensions { get; set; }
        public BulletType BulletType { get; set; }
        
        // Should this have validation on to only allow certain directions?
        public ActionConstants Direction { get; set; }
    }
}
