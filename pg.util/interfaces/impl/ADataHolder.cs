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
        
        public virtual void Add(TKey key, TData obj)
        {
            if (!IsInitialised) return;
            if(key == null) throw new ArgumentNullException($"A null argument has been provided for{nameof(key)}");
            if (_DATA.ContainsKey(key))
            {
                throw new DuplicateKeyException($"An object with key '{key}' already exists.");
            }
            _DATA.Add(key, obj);
        }

        public virtual bool TryAdd(TKey key, TData obj)
        {
            try
            {
                Add(key, obj);
                return true;
            }
            catch (DuplicateKeyException)
            {
                return false;
            }
        }

        public virtual TData Get(TKey key)
        {
            if(key == null) throw new ArgumentNullException($"A null argument has been provided for{nameof(key)}");
            if (IsInitialised && _DATA.ContainsKey(key))
            {
                return _DATA[key];
            }
            throw new UnsatisfiedReferenceException($"The object with key '{key}' does not exist.");
        }

        public virtual bool Contains(TKey key)
        {
            if (!IsInitialised) return false;
            if(key == null) throw new ArgumentNullException($"A null argument has been provided for{nameof(key)}");
            return _DATA.ContainsKey(key);
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
