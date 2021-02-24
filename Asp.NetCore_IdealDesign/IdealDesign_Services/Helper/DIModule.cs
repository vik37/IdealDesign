using IdealDesign_DataAccess;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using IdealDesign_Domain.Models;
using Microsoft.AspNetCore.Identity;
using IdealDesign_DataAccess.Interfaces;
using IdealDesign_DataAccess.Repositories;

namespace IdealDesign_Services.Helper
{
    public class DIModule
    {
        public static IServiceCollection RegisterModule(IServiceCollection services, string connectionString)
        {
            services.AddDbContext<IdDesignDbContext>(options => options.UseSqlServer(connectionString));

            services.AddIdentity<User, IdentityRole>(options =>
            {
                options.User.RequireUniqueEmail = false;
                options.Password.RequireNonAlphanumeric = false;
            })
             .AddRoleManager<RoleManager<IdentityRole>>()
             .AddEntityFrameworkStores<IdDesignDbContext>()
             .AddDefaultTokenProviders();

            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IRepository<Product>, ProductRepository>();
            services.AddTransient<IRepository<Career>, CareerRepository>();

            return services;
        }
    }
}
