using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MonoGameProj.Entities;
using MonoGameProj.Entities.GameObjects.Guns;
using MonoGameProj.Entities.Player;
using MonoGameProj.Helpers;
using System.Collections.Generic;

namespace MonoGameProj.Managers
{
    public class PlayerSetupManager
    {
        private GunFactory gunFactory;

        public PlayerSetupManager()
        {
            gunFactory = new GunFactory();
        }

        public List<Player> SetupPlayers(int numOfPlayers, Texture2D spriteTex)
        {
            List<Player> players = new List<Player>();

            for(int index = 0; index < numOfPlayers; index++)
            {
                Gun startingGun = gunFactory.RetrieveGun(Enums.GunType.SMALL_HANDGUN);

                Player player = new Player(spriteTex, new Vector2(100, 100), startingGun);

                players.Add(player);
            }

            return players;
        }
    }
}
