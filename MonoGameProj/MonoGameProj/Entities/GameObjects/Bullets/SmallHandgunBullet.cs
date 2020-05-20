using Microsoft.Xna.Framework;
using MonoGameProj.Constants;

namespace MonoGameProj.Entities.GameObjects
{
    public class SmallHandgunBullet : Bullet
    {
        public SmallHandgunBullet(Vector2 newPostion) : base(newPostion)
        {
            Weight = EntityConstants.SmallHandgunConstants.Small_Handgun_Bullet_Weight;
            BaseSpeed = EntityConstants.SmallHandgunConstants.Small_Handgun_Base_Speed;
            Dimensions = new EntityDimensions
            {
                Width = EntityConstants.BulletDimensionConstants.Handgun_Width_Value,
                Height = EntityConstants.BulletDimensionConstants.Handgun_Height_Value
            };

            BulletType = BulletType.SMALL_HANDGUN;
        }
    }
}
