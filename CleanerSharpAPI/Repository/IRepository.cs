using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanerSharpAPI.Repository;

/*
 CRUD
Create
Read
Update
Delete
 */
public interface IRepository<T> : IEnumerable<T>, ICollection<T>, IQueryable<T> { }
