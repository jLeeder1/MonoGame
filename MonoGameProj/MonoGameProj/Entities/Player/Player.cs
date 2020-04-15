using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoGameProj.Entities.GameObjects.Guns;
using System.Collections.Generic;

namespace MonoGameProj.Entities.Player
{
    public class Player
    {
        private Texture2D playerSprite;

        public Player()
        {
            PlayerPosition = new Vector2(100, 100);
            CurrentGun = new SmallHandgun();
        }

        public List<Keys> PlayerControlKeys { get; set; }

        public Vector2 PlayerPosition { get; set; }

        public Gun CurrentGun { get; set; }
    }
}
