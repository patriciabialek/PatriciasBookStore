using PatriciasBooks.DataAccess.Repository.IRepository;
using PatriciasBookStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatriciasBooks.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork //make the method public to access the class
    {
        private readonly ApplicationDbContext _db; //the using statement

        public UnitOfWork(ApplicationDbContext db) //constructor to use DI and inject in to the repos
        {
            _db = db;
            Category = new CategoryRepository(_db);
            SP_Call = new SP_Call(_db);
            CoverType = new CoverTypeRepository(_db); //new add for pt.3.1
        }

        public ICategoryRepository Category { get; private set; }
        public ISP_Call SP_Call { get; private set; }

        public ICoverTypeRepository CoverType { get; private set; } //new add for pt.3.1

        public void Dispose()
        {
            _db.Dispose();
        }

        public void Save() //all changes will be saved when the Save method is called at the 'parent' level
        {
            _db.SaveChanges();
        }
    }
}
