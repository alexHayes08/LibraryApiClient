namespace CrudPlusPattern
{
    /// <summary>
    /// An for a full set of CRUD+ methods which form a complete repository
    /// pattern.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <seealso cref="CrudPlusPattern.ICrudPattern{T}" />
    /// <seealso cref="CrudPlusPattern.IQueryPattern{T}" />
    /// <seealso cref="CrudPlusPattern.IPaginatePattern{T}" />
    public interface ICrudPlusPattern<T> : ICrudPattern<T>,
        IQueryPattern<T>,
        IPaginatePattern<T>
    { }
}
