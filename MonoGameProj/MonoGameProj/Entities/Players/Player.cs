using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoGameProj.Entities.GameObjects.Guns;
using System.Collections.Generic;

namespace MonoGameProj.Entities.Players
{
    public class Player : Entity
    {
        public Player(Vector2 position, Gun gun) : base(position, gun)
        {
            EntityType = Enums.EntityType.PLAYER;
        }

        public List<Keys> PlayerControlKeys { get; set; }
    }
}
