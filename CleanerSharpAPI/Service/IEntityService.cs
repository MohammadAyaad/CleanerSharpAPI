using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanerSharpAPI.Service;

public interface IEntityService<T> : IEnumerable<T>, ICollection<T>, IQueryable<T> { }
