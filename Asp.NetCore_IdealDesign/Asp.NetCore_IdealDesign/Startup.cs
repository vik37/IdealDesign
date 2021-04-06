//using Asp.NetCore_IdealDesign.Resources;
using Asp.NetCore_IdealDesign.Resources;
using AutoMapper;
using IdealDesign_Services.Helper;
using IdealDesign_Services.Interfaces;
using IdealDesign_Services.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Options;
using NToastNotify;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Asp.NetCore_IdealDesign
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });
            

            string connectionString = Configuration.GetValue<string>("idealDesignConnectionString");
            DIModule.RegisterModule(services, connectionString);

            services.ConfigureApplicationCookie(option =>
            {
                option.Cookie.HttpOnly = true;
                option.ExpireTimeSpan = TimeSpan.FromMinutes(60);
                option.LoginPath = "/Home/Index";
                option.AccessDeniedPath = "/User/Login";
                option.SlidingExpiration = true;
            });

            services.AddAutoMapper();

            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IProductService, ProductService>();
            services.AddTransient<ICareerService, CareerService>();

            services.AddMvc().AddNToastNotifyToastr(new ToastrOptions()
            {
                ProgressBar = true,
                PositionClass = ToastPositions.TopRight,
                CloseButton = true
            });
            
            services.AddLocalization(option => { option.ResourcesPath = "Resources"; });
            
            services.AddMvc()               
                .AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix)
                //.AddModelBindingMessagesLocalizer(services)
                .AddDataAnnotationsLocalization(option =>
                {
                    var type = typeof(ViewResource);
                    var assemblyName = new AssemblyName(type.GetTypeInfo().Assembly.FullName);
                    var factory = services.BuildServiceProvider().GetService<IStringLocalizerFactory>();
                    var localizer = factory.Create("ViewResource", assemblyName.Name);
                    option.DataAnnotationLocalizerProvider = (t, f) => localizer;
                })                
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.Configure<RequestLocalizationOptions>(option =>
            {
                var supportedCultures = new List<CultureInfo>
                {
                    new CultureInfo("en"),
                    new CultureInfo("en-US"),
                    new CultureInfo("mk"),
                    new CultureInfo("sq")
                };
                option.DefaultRequestCulture = new RequestCulture("en");
                // formating numbers, data, etc...
                option.SupportedCultures = supportedCultures;
                // UI strings that we have localized.
                option.SupportedUICultures = supportedCultures;
            });
            //services.Configure<FormOptions>(x =>
            //{
            //    x.MultipartBodyLengthLimit = 3145728;
            //});
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            
            app.UseAuthentication();
            app.UseNToastNotify();

            var options = app.ApplicationServices.GetService<IOptions<RequestLocalizationOptions>>();
            app.UseRequestLocalization(options.Value);

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
