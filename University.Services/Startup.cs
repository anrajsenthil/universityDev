using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using AutoMapper;
using University.Domain.DataAccess;
using University.Domain.DataAccess.Interface;
using University.Business.Interface;
using University.Business;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using System.Text;
using University.Services.Automapper;

namespace University.Services
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
           
            services.AddDbContext<UniversityContext>(

                option =>
                {
                    option.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
                });
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.AddIdentity<IdentityUser, IdentityRole>(

                option =>
                {
                    option.Password.RequireDigit = false;
                }
                ).AddEntityFrameworkStores<UniversityContext>().AddDefaultTokenProviders();


            services.AddAuthentication(option =>
            {
                option.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                option.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                option.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(options =>
            {
                options.SaveToken = true;
                options.RequireHttpsMetadata = true;
                options.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters()
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidIssuer = Configuration["Jwt:Site"],
                    ValidAudience = Configuration["Jwt:Site"],
                    IssuerSigningKey = new Microsoft.IdentityModel.Tokens.SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["Jwt:SigningKey"]))

                };

            });


            //  services.AddScoped(_ => new UniversityContext());
            services.AddTransient<IStudentRepository, StudentRepository>();
            // services.AddTransient<IStudentRetriever, StudentRetriever>();
            services.AddTransient<IUserRegistrationRepository, UserRegistrationRepository>();

            var config = new AutoMapper.MapperConfiguration(cfg =>
            { 
                  cfg.AddProfile(new AutoMapperProfile());

            // services.AddAutoMapper(typeof(Startup));
        });
            var mapper = config.CreateMapper();
            services.AddSingleton(mapper);
            services.AddMvc();
            
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
                app.UseHsts();
            }
            //app.UseCors(options => options.AllowAnyOrigin());
           //app.UseCors(options => options.WithOrigins("https://localhost:44392"));
            app.UseHttpsRedirection();
            app.UseAuthentication();
            app.UseMvc();
        }
    }
}
