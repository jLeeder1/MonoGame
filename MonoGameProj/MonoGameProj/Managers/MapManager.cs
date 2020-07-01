using MonoGame.Extended.Tiled;

namespace MonoGameProj.Managers
{
    public class MapManager
    {
        public TiledMap CurrentMap { get; set; }

        public void SetTileMap(TiledMap newMap)
        {
            CurrentMap = newMap;
        }
    }
}
