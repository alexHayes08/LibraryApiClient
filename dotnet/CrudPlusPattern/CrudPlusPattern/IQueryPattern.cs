using System.Linq;

namespace CrudPlusPattern
{
    public interface IQueryPattern<T>
    {
        IQueryable<T> Query();
    }
}
