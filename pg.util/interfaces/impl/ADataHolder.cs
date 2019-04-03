using System;
using System.Collections.Generic;
using System.Linq;
using pg.util.exceptions;

namespace pg.util.interfaces.impl
{
    public abstract class ADataHolder<TKey, TData> : IDataHolder<TKey, TData>
    {
        protected bool IsInitialised = false;
        protected Dictionary<TKey, TData> _DATA = new Dictionary<TKey, TData>();
        public virtual void Init()
        {
            IsInitialised = true;
        }

        public virtual TData Get(TKey key)
        {
            if (IsInitialised && _DATA.ContainsKey(key))
            {
                return _DATA[key];
            }
            throw new UnsatisfiedReferenceException($"The object with key '{key}' does not exist.");
        }

        public virtual IEnumerable<TData> GetAll()
        {
            return IsInitialised ? _DATA.Values.ToList() : new List<TData>();
        }

        public virtual void Clear()
        {
            _DATA.Clear();
        }
    }
}
