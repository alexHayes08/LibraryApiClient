using System.Collections.Generic;

namespace CrudPlusPattern
{
    /// <summary>
    /// Represents the results of a pagination operation.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IPaginationResults<T>
    {
        /// <summary>
        /// Gets the next <c>Paginate</c> object which if not null can be used
        /// to retrieve the next pagination results.
        /// </summary>
        IPaginate Next { get; }

        /// <summary>
        /// Gets the previous <c>Paginate</c> object which if not null can be
        /// used to retrieve the previous pagination results.
        /// </summary>
        IPaginate Previous { get; }

        /// <summary>
        /// Gets the entities returned from the pagination operation.
        /// </summary>
        IReadOnlyList<T> Results { get; }

        /// <summary>
        /// The total count of all entities from the operation.
        /// </summary>
        long TotalCount { get; }
    }
}
