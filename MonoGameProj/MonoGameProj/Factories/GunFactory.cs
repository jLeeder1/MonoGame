using MonoGameProj.Entities.GameObjects.Guns;
using MonoGameProj.Enums;

namespace MonoGameProj.Helpers
{
    public class GunFactory
    {
        public Gun RetrieveGun(GunType gunType)
        {
            Gun gunToReturn = null;

            switch (gunType)
            {
                default:
                    gunToReturn = CreateSmallHandgun();
                    break;
            }

            return gunToReturn;
        }

        private Gun CreateSmallHandgun()
        {
            return new SmallHandgun();
        }
    }
}
