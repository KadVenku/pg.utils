using System.Collections.Generic;

namespace pg.util.interfaces
{
    public interface IDataHolder<in TKey, TData>
    {
        void Init();
        void Add(TKey key, TData obj);
        bool TryAdd(TKey key, TData obj);
        TData Get(TKey key);
        IEnumerable<TData> GetAll();
        void Clear();
    }
}