using System.Collections.Generic;

namespace CrudPlusPattern
{
    /// <summary>
    /// Standardized methods for creating entities in the repository pattern.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface ICreatePattern<T>
    {
        /// <summary>
        /// Creates the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns></returns>
        T Create(T entity);

        /// <summary>
        /// Bulk version of <c>Create</c>.
        /// </summary>
        /// <param name="entities">The entities.</param>
        /// <returns></returns>
        IEnumerable<T> CreateMany(IEnumerable<T> entities);
    }
}
