using MonoGameProj.Constants;
using MonoGameProj.Logic.Game;

namespace MonoGameProj.Entities.GameObjects.Guns
{
    public class SmallHandgun : Gun
    {
        public SmallHandgun()
        {
            rateOfFire = EntityConstants.SmallHandgunConstants.Small_Handgun_Rate_Of_Fire;
            bulletType = BulletType.SMALL_HANDGUN;
        }
    }
}
