using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using CleanerSharpAPI.Repository;

namespace CleanerSharpAPI.Service
{
    public class EntityService<T, TRepository> : IEntityService<T>
        where TRepository : IRepository<T>
    {
        private readonly TRepository _repository;

        public EntityService(TRepository repository)
        {
            _repository = repository;
        }

        public int Count => _repository.Count;

        public bool IsReadOnly => _repository.IsReadOnly;

        public Type ElementType => _repository.ElementType;

        public Expression Expression => _repository.Expression;

        public IQueryProvider Provider => _repository.Provider;

        public void Add(T item)
        {
            _repository.Add(item);
        }

        public void Clear()
        {
            _repository.Clear();
        }

        public bool Contains(T item)
        {
            return _repository.Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            _repository.CopyTo(array, arrayIndex);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _repository.GetEnumerator();
        }

        public bool Remove(T item)
        {
            return _repository.Remove(item);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _repository.GetEnumerator();
        }
    }
}
