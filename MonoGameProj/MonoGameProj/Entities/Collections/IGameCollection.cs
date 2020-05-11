using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonoGameProj.Entities.Collections
{
    public interface IGameCollection<T>
    {
        List<T> GetEntityList();

        void AddEntity(T entity);

        void RemoveEntity(T entity);

        void AddListRange(List<T> entities);
    }
}
