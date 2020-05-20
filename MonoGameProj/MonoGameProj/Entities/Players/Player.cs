using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using MonoGameProj.Constants;
using MonoGameProj.Entities.GameObjects.Guns;
using System.Collections.Generic;

namespace MonoGameProj.Entities.Players
{
    public class Player : Entity
    {
        public Player(Vector2 position, Gun gun) : base(position, gun)
        {
            EntityType = Enums.EntityType.PLAYER;
            CurrentDirection = ActionConstants.RIGHT;
        }

        public Dictionary<Keys, ActionConstants> PlayerControlKeys { get; set; }
    }
}
