using Microsoft.Xna.Framework;
using MonoGameProj.Constants;

namespace MonoGameProj.Entities.GameObjects
{
    /// <summary>
    /// Class <c>SmallHandgunBullet</c> is an extension of class <c>Bullet</c> and populates the generic properties with constant valuess associated with a small handgun projectile
    /// </summary>
    public class SmallHandgunBullet : Bullet
    {
        public SmallHandgunBullet(Vector2 newPostion, ActionConstants direction) : base(newPostion, direction)
        {
            Weight = EntityConstants.SmallHandgunConstants.Small_Handgun_Bullet_Weight;
            BaseSpeed = EntityConstants.SmallHandgunConstants.Small_Handgun_Base_Speed;
            Dimensions = new EntityDimensions
            {
                Width = EntityConstants.BulletDimensionConstants.Handgun_Bullet_Width_Value,
                Height = EntityConstants.BulletDimensionConstants.Handgun_Bullet_Height_Value
            };

            Sprite = EntityConstants.SmallHandgunConstants.Small_Handgun_Texture_Name;
            BulletType = BulletType.SMALL_HANDGUN;
        }
    }
}
