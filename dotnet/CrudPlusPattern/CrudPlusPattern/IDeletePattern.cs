using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace CrudPlusPattern
{
    /// <summary>
    /// Standard methods for deleting entities.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IDeletePattern<T>
    {
        /// <summary>
        /// Deletes the specified entity. If entity isn't found return false.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns></returns>
        bool Delete(T entity);

        /// <summary>
        /// Deletes the first entity matching expression and value. If the
        /// entity isn't found return false.
        /// </summary>
        /// <typeparam name="V"></typeparam>
        /// <param name="expression">The expression.</param>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        bool DeleteBy<V>(Expression<Func<T, V>> expression, V value);

        /// <summary>
        /// Bulk version of <c>Delete</c>.
        /// </summary>
        /// <param name="entities">The entities.</param>
        /// <returns></returns>
        bool DeleteMany(IEnumerable<T> entities);
    }
}
