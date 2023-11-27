using PatriciasBooks.DataAccess.Repository.IRepository;
using PatriciasBooks.Models;
using PatriciasBookStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PatriciasBooks.DataAccess.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly ApplicationDbContext _db;
        public ProductRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Product product)
        {
            var objFromDb = _db.Products.FirstOrDefault(s => s.Id == product.Id);
            if (objFromDb != null) //save changes if not null
            {
                if (product.ImageUrl != null)
                {
                    objFromDb.ImageUrl = product.ImageUrl; //add the check for image url
                }
                objFromDb.Title = product.Title;
                objFromDb.Description = product.Description;
                objFromDb.ISBN = product.ISBN;
                objFromDb.Author = product.Author;
                objFromDb.ListPrice = product.ListPrice;
                objFromDb.Price = product.Price;
                objFromDb.CategoryId = product.CategoryId;
                objFromDb.CoverTypeId = product.CoverTypeId;
                //allproperties of product object
            }
        }
    }
}
