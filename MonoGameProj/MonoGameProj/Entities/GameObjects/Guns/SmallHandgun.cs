using MonoGameProj.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonoGameProj.Entities.GameObjects.Guns
{
    public class SmallHandgun : Gun
    {
        public SmallHandgun()
        {
            bulletType = BulletType.SMALL_HANDGUN;
        }
    }
}
