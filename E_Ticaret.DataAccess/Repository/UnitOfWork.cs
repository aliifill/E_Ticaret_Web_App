using E_Ticaret.DataAccess.Data;
using E_Ticaret.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Ticaret.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _unitOfWork;
        public ICategoryRepository Category { get;private set; }
        public IProductRepository Product { get; private set; }
        public UnitOfWork(ApplicationDbContext db) 
        {
            _unitOfWork = db;
            Category = new CategoryRepository(_unitOfWork);
            Product = new ProductRepoistory(_unitOfWork);
        }
        public void Save()
        {
            _unitOfWork.SaveChanges();
        }
    }
}
