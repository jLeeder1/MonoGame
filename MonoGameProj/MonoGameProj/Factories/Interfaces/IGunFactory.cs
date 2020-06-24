using MonoGameProj.Entities.GameObjects.Guns;
using MonoGameProj.Enums;

namespace MonoGameProj.Helpers
{
    public interface IGunFactory
    {
        Gun RetrieveGun(GunType gunType);
    }
}