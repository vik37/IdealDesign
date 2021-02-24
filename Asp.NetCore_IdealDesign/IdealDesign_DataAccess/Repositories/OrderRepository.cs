using IdealDesign_DataAccess.Interfaces;
using IdealDesign_Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace IdealDesign_DataAccess.Repositories
{
    public class OrderRepository : BaseRepository, IRepository<Order>
    {
        public OrderRepository(IdDesignDbContext context) : base(context) { }
        
        public IEnumerable<Order> GetAll()
        {
            throw new NotImplementedException();
        }

        public Order GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(Order entitie)
        {
            throw new NotImplementedException();
        }

        public int Update(Order entitie)
        {
            throw new NotImplementedException();
        }
        public int Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
