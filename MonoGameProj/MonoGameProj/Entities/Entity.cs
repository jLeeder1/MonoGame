using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MonoGameProj.Constants;
using MonoGameProj.Entities.GameObjects;
using MonoGameProj.Entities.GameObjects.Guns;
using MonoGameProj.Enums;

namespace MonoGameProj.Entities
{
    public abstract class Entity
    {
        public Entity(Vector2 position, Gun gun)
        {
            Position = position;
            CurrentGun = gun;
            EntityType = EntityType.NPC;
            Dimensions = new EntityDimensions
            {
                Width = EntityConstants.DimensionConstants.Base_Width_Value,
                Height = EntityConstants.DimensionConstants.Base_Height_Value
            };
        }

        public string Sprite { get; set; }

        public EntityDimensions Dimensions { get; set; }

        public Vector2 Position { get; set; }

        public Gun CurrentGun { get; set; }

        public EntityType EntityType { get; set; }

        public ActionConstants CurrentDirection { get; set; }

        public virtual Bullet Shoot() 
        {
            return CurrentGun.Shoot(Position, Dimensions, CurrentDirection);
        }
    }
}
