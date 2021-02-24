using IdealDesign_DataAccess.Interfaces;
using IdealDesign_Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IdealDesign_DataAccess.Repositories
{
    public class ProductRepository : BaseRepository, IRepository<Product>
    {
        public ProductRepository(IdDesignDbContext context) : base(context) { }            

        public IEnumerable<Product> GetAll()
        {
            return _db.Product;
        }

        public Product GetById(int id)
        {
            return _db.Product.SingleOrDefault(x => x.Id == id);
        }

        public int Insert(Product entitie)
        {
            _db.Product.Add(entitie);
            return _db.SaveChanges();
        }

        public int Update(Product entitie)
        {
            _db.Product.Update(entitie);
            return _db.SaveChanges();
        }
        public int Delete(int id)
        {
            Product product = _db.Product.SingleOrDefault(x => x.Id == id);
            if(product == null)
            {
                return -1;
            }
            _db.Product.Remove(product);
            return _db.SaveChanges();
        }
    }
}
