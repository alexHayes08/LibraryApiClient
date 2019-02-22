namespace CrudPlusPattern
{
    /// <summary>
    /// The basic methods for the repository pattern.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <seealso cref="CrudPlusPattern.ICreatePattern{T}" />
    /// <seealso cref="CrudPlusPattern.IRetrievePattern{T}" />
    /// <seealso cref="CrudPlusPattern.IUpdatePattern{T}" />
    /// <seealso cref="CrudPlusPattern.IDeletePattern{T}" />
    public interface ICrudPattern<T> : ICreatePattern<T>,
        IRetrievePattern<T>,
        IUpdatePattern<T>,
        IDeletePattern<T>
    { }
}
