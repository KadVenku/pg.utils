using System;
using pg.util.exceptions;

namespace pg.util.interfaces.impl
{
    public abstract class AMutableDataHolder<TKey,TData> : ADataHolder<TKey, TData>, IMutableDataHolder<TKey, TData>
    {
        public virtual void Update(TKey key, TData obj)
        {
            if (!IsInitialised) return;
            if(key == null) throw new ArgumentNullException($"A null argument has been provided for{nameof(key)}");
            if (_DATA.ContainsKey(key))
            {
                _DATA[key] = obj;
            }
            else
            {
                throw new UnknownKeyException($"An object with key '{key}' does not exist.");
            }
        }

        public virtual bool TryUpdate(TKey key, TData obj)
        {
            try
            {
                Update(key, obj);
                return true;
            }
            catch (UnknownKeyException)
            {
                return false;
            }
        }

        public virtual void AddOrUpdate(TKey key, TData obj)
        {
            try
            {
                Update(key, obj);
            }
            catch (UnknownKeyException)
            {
                Add(key, obj);
            }
        }

        public virtual bool TryAddOrUpdate(TKey key, TData obj)
        {
            try
            {
                AddOrUpdate(key, obj);
                return true;
            }
            catch (UnknownKeyException)
            {
                return false;
            }
            catch (DuplicateKeyException)
            {
                return false;
            }
        }

        public virtual void Remove(TKey key)
        {
            if (!IsInitialised) return;
            if(key == null) throw new ArgumentNullException($"A null argument has been provided for{nameof(key)}");
            if (_DATA.ContainsKey(key))
            {
                _DATA.Remove(key);
            }
        }
    }
}
