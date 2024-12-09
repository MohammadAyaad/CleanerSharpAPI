using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CleanerSharpAPI.Repository;

public class Repository<T, TSet> : IRepository<T>
    where TSet : IEnumerable<T>, ICollection<T>, IQueryable<T>
{
    protected TSet _entities;

    public Repository(TSet entities)
    {
        _entities = entities;
    }

    public int Count => _entities.Count;

    public bool IsReadOnly => _entities.IsReadOnly;

    public Type ElementType => _entities.ElementType;

    public Expression Expression => _entities.Expression;

    public IQueryProvider Provider => _entities.Provider;

    public void Add(T item)
    {
        _entities.Add(item);
    }

    public void Clear()
    {
        _entities.Clear();
    }

    public bool Contains(T item)
    {
        return _entities.Contains(item);
    }

    public void CopyTo(T[] array, int arrayIndex)
    {
        _entities.CopyTo(array, arrayIndex);
    }

    public IEnumerator<T> GetEnumerator()
    {
        return _entities.GetEnumerator();
    }

    public bool Remove(T item)
    {
        return _entities.Remove(item);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return _entities.GetEnumerator();
    }
}
