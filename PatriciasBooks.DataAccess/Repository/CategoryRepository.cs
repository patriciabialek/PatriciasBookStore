using PatriciasBooks.DataAccess.Repository.IRepository;
using PatriciasBooks.Models;
using PatriciasBookStore.DataAccess.Data; /*new add 3 using statements pt.2.2*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PatriciasBooks.DataAccess.Repository
{
    public class CategoryRepository : Repository<CategoryRepository>, ICategoryRepository
    {
        private readonly ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Category category)
        {
            //use .NET LINQ to retrieve the first or default category object,
            //then pass the id as a generic entity which matches the category ID
            var objFromDb = _db.Categories.FirstOrDefault(s => s.Id == category.Id);
            if (objFromDb != null) //save chnages if not null
            {
                objFromDb.Name = category.Name;
                /*_db.SaveChanges();*/
            }
            //throw new NotImplementedException();
        }
        //Adding for now because line 13 will have an error
        void IRepository<Category>.Add(Category entity)
        {
            throw new NotImplementedException();
        }

        Category IRepository<Category>.Get(int id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Category> IRepository<Category>.GetAll(Expression<Func<Category, bool>> filter, Func<IQueryable<Category>, IOrderedQueryable<Category>> orderBy, string includeProperties)
        {
            throw new NotImplementedException();
        }

        Category IRepository<Category>.GetFirstOrDefault(Expression<Func<Category, bool>> filter, string includeProperties)
        {
            throw new NotImplementedException();
        }

        void IRepository<Category>.Remove(Category entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Category>.RemoveRange(IEnumerable<Category> entity)
        {
            throw new NotImplementedException();
        }
    }
}
