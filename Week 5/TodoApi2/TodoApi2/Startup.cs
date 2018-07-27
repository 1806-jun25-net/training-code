using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.Swagger;
using TodoApi2.Models;

namespace TodoApi2
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
            services.AddDbContext<TodoContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("TodoApiDB")));

            services.AddDbContext<IdentityDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("TodoApiAuthDB"),
                    b => b.MigrationsAssembly("TodoApi2"))); // for "TodoApi2", put your data project.

            // Add-Migration <migration-name> -Context TodoContext
            // Update-Database -Context TodoContext

            // Add-Migration <diff-migration-name> -Context IdentityDbContext
            // Update-Database -Context IdentityDbContext

            services.AddIdentity<IdentityUser, IdentityRole>(options =>
                {
                    // Password settings (defaults - optional)
                    options.Password.RequireDigit = true;
                    options.Password.RequiredLength = 6;
                    options.Password.RequiredUniqueChars = 1;
                    options.Password.RequireLowercase = true;
                    options.Password.RequireNonAlphanumeric = true;
                    options.Password.RequireUppercase = true;

                    options.User.AllowedUserNameCharacters =
                        "abcdefghijklmnopqrstuvwxyz" +
                        "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                        "0123456789" +
                        "-._@+";
                })
                .AddEntityFrameworkStores<IdentityDbContext>();

            services.ConfigureApplicationCookie(options =>
            {
                options.Cookie.Name = "TodoApiAuth";
                options.ExpireTimeSpan = TimeSpan.FromMinutes(10);
                options.Events = new CookieAuthenticationEvents
                {
                    OnRedirectToLogin = ctx =>
                    {
                        ctx.Response.StatusCode = 401; // Unauthorized
                        return Task.FromResult(0);
                    },
                    OnRedirectToAccessDenied = ctx =>
                    {
                        ctx.Response.StatusCode = 403; // Forbidden
                        return Task.FromResult(0);
                    },
                };
            });

            services.AddAuthentication();

            services.AddMvc()
                .AddXmlSerializerFormatters()
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            // don't forget to add Swashbuckle.AspNetCore Nuget package

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "My API", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseAuthentication();

            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });

            app.UseMvc();
        }
    }
}
