using Microsoft.Xna.Framework.Input;
using MonoGameProj.Constants;
using System.Collections.Generic;

namespace MonoGameProj.Logic.Input
{
    public interface IMyKeyboardInput
    {
        List<DirectionConstants> RetrieveKeyPressActions(List<Keys> keys);
    }
}