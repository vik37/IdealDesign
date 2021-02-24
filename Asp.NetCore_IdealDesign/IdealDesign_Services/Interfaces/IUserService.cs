using IdealDesign_Domain.Models;
using IdealDesign_WebModels.VewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace IdealDesign_Services.Interfaces
{
    public interface IUserService
    {
        void Login(LoginVM loginModel, out bool isAdmin);
        void Logout();

        UserVM GetuserByUsername(string username);
        
    }
}
