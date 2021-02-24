using IdealDesign_DataAccess.Interfaces;
using IdealDesign_Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IdealDesign_DataAccess.Repositories
{
    public class UserRepository : BaseRepository, IUserRepository
    {
        public UserRepository(IdDesignDbContext context) : base(context) { }

        public IEnumerable<User> GetAll()
        {
            return _db.Users;
        }

        public User GetById(string id)
        {
            return _db.Users.SingleOrDefault(x => x.Id == id);
        }

        public User GetByUsername(string username)
        {
            return _db.Users.SingleOrDefault(x => x.UserName == username);
        }

        public int Insert(User entitie)
        {
            _db.Users.Add(entitie);
            return _db.SaveChanges();
        }

        public int Update(User entitie)
        {
            _db.Update(entitie);
            return _db.SaveChanges();
        }
        public int Delete(string id)
        {
            User user = _db.Users.SingleOrDefault(x => x.Id == id);
            if (user == null)
                return -1;

            _db.Users.Remove(user);
            return _db.SaveChanges();
        }

       
    }
}
