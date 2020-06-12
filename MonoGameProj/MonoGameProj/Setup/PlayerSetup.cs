using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using MonoGameProj.Assets;
using MonoGameProj.Constants;
using MonoGameProj.Entities.GameObjects.Guns;
using MonoGameProj.Entities.Players;
using MonoGameProj.Helpers;
using System.Collections.Generic;

namespace MonoGameProj.Managers
{
    public class PlayerSetup
    {
        private GunFactory gunFactory;

        public PlayerSetup()
        {
            gunFactory = new GunFactory();
        }

        public List<Player> SetupPlayers(int numOfPlayers)
        {
            List<Player> players = new List<Player>();

            // Set up each players gun, position and texture
            for(int index = 0; index < numOfPlayers; index++)
            {
                Gun startingGun = gunFactory.RetrieveGun(Enums.GunType.SMALL_HANDGUN);

                Player player = new Player(new Vector2(100, 100), startingGun);

                SetPlayerTexture(1, player);

                players.Add(player);
            }

            return players;
        }

        private void SetPlayerTexture(int playerNumber, Player player)
        {
            string textureName = string.Empty;

            switch (playerNumber)
            {
                case 1:
                    textureName = AssetNames.PlayerAssets.Player_One_Sprite;
                    break;
            }

            textureName = AssetNames.PlayerAssets.Default_Player_Sprite;

            player.Sprite = textureName;
        }
    }
}
