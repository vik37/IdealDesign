using IdealDesign_Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace IdealDesign_DataAccess.Interfaces
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAll();
        User GetByUsername(string username);
        User GetById(string id);
        int Insert(User entitie);
        int Update(User entitie);
        int Delete(string id);
    }
}
