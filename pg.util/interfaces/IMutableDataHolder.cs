﻿namespace pg.util.interfaces
{
    public interface IMutableDataHolder<in TKey,TData> : IDataHolder<TKey,TData>
    {
        void Add(TKey key, TData obj);
        void Update(TKey key, TData obj);
        void AddOrUpdate(TKey key, TData obj);
    }
}