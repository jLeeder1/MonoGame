﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonoGameProj.Entities.Collections
{
    public class EntityList : IGameCollection<Entity>
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

        public void AddListRange(List<Entity> listToConcat)
        {
            entities.AddRange(listToConcat);
        }

        public void AddEntity(Entity entity)
        {
            entities.Add(entity);
        }
    }
}
