using MonoGameProj.Entities.GameObjects.Guns;
using MonoGameProj.Enums;

namespace MonoGameProj.Helpers
{
    /// <summary>
    /// Class <c>GunFactory</c> is used to create gun objects to be used by player and npc entities in the game. Differnt gun types are returned based on input <c>GunType</c> gunType
    /// </summary>
    public class GunFactory : IGunFactory
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
