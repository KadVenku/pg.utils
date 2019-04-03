namespace pg.util.interfaces
{
    public interface IMutableDataHolder<in TKey,TData> : IDataHolder<TKey,TData>
    {
        void Update(TKey key, TData obj);
        bool TryUpdate(TKey key, TData obj);
        void AddOrUpdate(TKey key, TData obj);
        bool TryAddOrUpdate(TKey key, TData obj);
    }
}
