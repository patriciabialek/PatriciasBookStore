using PatriciasBooks.Models;/*new using statement in pt .3.1*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatriciasBooks.DataAccess.Repository.IRepository
{
    /*Added : IRepository<Category> for right now copied from ICategoryRepository*/
    public interface ICoverTypeRepository : IRepository<CoverType>
    {
        /*Added below for right now*/
        void Update(CoverType covertype);
    }
}
