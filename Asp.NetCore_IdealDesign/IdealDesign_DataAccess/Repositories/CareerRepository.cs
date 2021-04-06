using IdealDesign_DataAccess.Interfaces;
using IdealDesign_Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IdealDesign_DataAccess.Repositories
{
    public class CareerRepository : BaseRepository, IRepository<Career>
    {
        public CareerRepository(IdDesignDbContext context) : base(context) { }
               
        public IEnumerable<Career> GetAll()
        {
            return _db.Career;
        }

        public Career GetById(int id)
        {
            return _db.Career.SingleOrDefault(x => x.Id == id);
        }

        public int Insert(Career entitie)
        {
            _db.Career.Add(entitie);
            return _db.SaveChanges();
        }

        public int Update(Career entitie)
        {
            _db.Career.Update(entitie);
            return _db.SaveChanges();
        }
        public int Delete(int id)
        {
            var career = _db.Career.SingleOrDefault(x => x.Id == id);
            if (career == null)
                return -1;
            _db.Career.Remove(career);
            return _db.SaveChanges();
        }
    }
}
