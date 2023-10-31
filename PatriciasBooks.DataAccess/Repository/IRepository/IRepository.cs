using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions; /*new add pt.2.2*/
using System.Text;
using System.Threading.Tasks;

namespace PatriciasBooks.DataAccess.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        T Get(int id); //retrieve a cat from the db by id
        //list of cat based on requirements

        IEnumerable<T> GetAll(
            Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            string includeProperties = null
            );

        T GetFirstOrDefault(
            Expression<Func<T, bool>> filter = null,
            string includeProperties = null
            );

        void Add(T entity); //to add an entity
        void Remove(int id); //to remove an object or cat
        void Remove(T entity); //another way to remove an object
        void RemoveRange(IEnumerable<T> entity); //removes a complete range of entities
    }
}
