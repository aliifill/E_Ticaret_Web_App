using E_Ticaret.DataAccess.Data;
using E_Ticaret.DataAccess.Repository.IRepository;
using E_Ticaret.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Ticaret.DataAccess.Repository
{
    public class ProductRepoistory : Repository<Product>, IProductRepository
    {
        private ApplicationDbContext _unitOfWork;
        public ProductRepoistory(ApplicationDbContext db) : base (db)
        {
            _unitOfWork = db;
        }
        public void Update(Product obj)
        {
            _unitOfWork.Products.Update(obj);
        }
             
    }
}
