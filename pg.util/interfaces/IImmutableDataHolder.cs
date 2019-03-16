namespace pg.util.interfaces
{
    public interface IImmutableDataHolder<in TKey, out TData> : IDataHolder<TKey,TData>
    {
    }
}