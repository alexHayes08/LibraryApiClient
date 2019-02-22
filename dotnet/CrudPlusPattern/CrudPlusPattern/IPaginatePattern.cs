namespace CrudPlusPattern
{
    public interface IPaginatePattern<T>
    {
        IPaginationResults<T> Paginate(IPaginate paginate);
    }
}
