namespace pg.util.interfaces
{
    public interface IImmutableDataHolder<in TKey, TData> : IDataHolder<TKey,TData>
    {
    }
}