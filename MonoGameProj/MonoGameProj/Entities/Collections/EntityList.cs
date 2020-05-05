using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonoGameProj.Entities.Collections
{
    public class EntityList
    {
        private List<Entity> entities;

        public EntityList()
        {
            entities = new List<Entity>();
        }

        public List<Entity> GetEntityList()
        {
            return entities;
        }

        public void RemoveEntity(Entity entity)
        {
            entities.Remove(entity);
        }
    }
}
