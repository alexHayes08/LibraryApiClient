using System.Collections.Generic;

namespace CrudPlusPattern
{
    public interface IUpdatePattern<T>
    {
        T Update(T entity);
        IEnumerable<T> UpdateMany(IEnumerable<T> entities);
    }
}
