using System.Collections.Generic;

namespace pg.util.interfaces
{
    public interface IDataHolder<in TKey, out TData>
    {
        void Init();
        TData Get(TKey key);
        IEnumerable<TData> GetAll();
        void Clear();
    }
}