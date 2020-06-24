using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonoGameProj.Entities.Collections
{
    /// <summary>
    /// Interfacee <c>IGameCollection<T></c> describes generic behaviour of game collections used to store entities such as players and bullets. The methods manipulate these collections. Concete implementations store the collections
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IGameCollection<T>
    {
        List<T> GetEntityList();

        void AddEntity(T entity);

        void RemoveEntity(T entity);

        void AddListRange(List<T> entities);
    }
}
