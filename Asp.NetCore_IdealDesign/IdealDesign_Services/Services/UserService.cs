using IdealDesign_DataAccess.Interfaces;
using IdealDesign_Domain.Models;
using IdealDesign_Services.Interfaces;
using IdealDesign_WebModels.VewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace IdealDesign_Services.Services
{
    public class UserService : IUserService
    {
        protected readonly IUserRepository _userRepo;
        protected readonly SignInManager<User> _signinManager;
        protected readonly UserManager<User> _userManager;
        
        public UserService(IUserRepository userRepo, SignInManager<User> signinManager, UserManager<User> userManager)
        {
            _userRepo = userRepo;
            _signinManager = signinManager;
            _userManager = userManager;
        }

        public UserVM GetuserByUsername(string username)
        {
            try
            {
                User user = _userRepo.GetByUsername(username);
                return new UserVM
                {
                    Id = user.Id,
                    Username = user.UserName,
                    Fullname = user.FullName,
                    Photos = new List<IFormFile>()

                };
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }                        
        }

        public void Login(LoginVM loginModel, out bool isAdmin)
        {
            var result = _signinManager.PasswordSignInAsync(loginModel.Username, loginModel.Password, false, false).Result;
            User user = _userRepo.GetByUsername(loginModel.Username);
            isAdmin = false;
            if (result.Succeeded)
            {
                isAdmin = _userManager.IsInRoleAsync(user, "admin").Result;
            }
            if (result.IsNotAllowed)
            {
                throw new Exception("Username or Password is not correct!");
            }
        }

        public void Logout()
        {
            _signinManager.SignOutAsync();
        }
    }
}
