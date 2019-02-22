using System;
using System.Linq.Expressions;

namespace CrudPlusPattern
{
    public interface IRetrievePattern<T>
    {
        T RetrieveBy<U>(Expression<Func<T, U>> expression, U value);
        T RetrieveBy<U>(string fieldName, U value);
    }
}
