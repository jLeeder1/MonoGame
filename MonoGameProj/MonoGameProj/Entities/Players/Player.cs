using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoGameProj.Entities.GameObjects.Guns;
using System.Collections.Generic;

namespace MonoGameProj.Entities.Players
{
    public class Player : Entity
    {
        public Player(Texture2D sprite, Vector2 position, Gun gun) : base(sprite, position, gun)
        {
        }

        public List<Keys> PlayerControlKeys { get; set; }

        public Vector2 PlayerPosition { get; set; }
    }
}
