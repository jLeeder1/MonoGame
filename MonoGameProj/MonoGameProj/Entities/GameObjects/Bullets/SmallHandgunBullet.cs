using Microsoft.Xna.Framework;
using MonoGameProj.Constants;

namespace MonoGameProj.Entities.GameObjects
{
    public class SmallHandgunBullet : Bullet
    {
        public SmallHandgunBullet(Vector2 newPostion, ActionConstants direction) : base(newPostion, direction)
        {
            Weight = EntityConstants.SmallHandgunConstants.Small_Handgun_Bullet_Weight;
            BaseSpeed = EntityConstants.SmallHandgunConstants.Small_Handgun_Base_Speed;
            Dimensions = new EntityDimensions
            {
                Width = EntityConstants.BulletDimensionConstants.Handgun_Width_Value,
                Height = EntityConstants.BulletDimensionConstants.Handgun_Height_Value
            };

            Sprite = EntityConstants.SmallHandgunConstants.Small_Handgun_Texture_Name;
            BulletType = BulletType.SMALL_HANDGUN;
        }
    }
}
