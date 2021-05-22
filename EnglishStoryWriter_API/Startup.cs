using EnglishStoryWriter_API.DTO;
using EnglishStoryWriter_API.DTO.Validators;
using EnglishStoryWriter_API.Entities;
using EnglishStoryWriter_API.Middleware;
using EnglishStoryWriter_API.Repositories;
using EnglishStoryWriter_API.Services;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishStoryWriter_API
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

            var authenticationSetting = new AuthenticationSettings();
            Configuration.GetSection("Authentication").Bind(authenticationSetting);
            services.AddSingleton(authenticationSetting);
            services.AddAuthentication(option =>
            {
                option.DefaultAuthenticateScheme = "Bearer";
                option.DefaultScheme = "Bearer";
                option.DefaultChallengeScheme = "Bearer";
            }).AddJwtBearer(cfg =>
            {
                cfg.RequireHttpsMetadata = false;
                cfg.SaveToken = true;
                cfg.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidIssuer = authenticationSetting.JwtIssuer,
                    ValidAudience = authenticationSetting.JwtIssuer,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(authenticationSetting.JwtKey)),
                };
            });

            services.AddTransient<IStoryStatusRepository, StoryStatusRepository>();
            services.AddTransient<IStoryStatusService, StoryStatusService>();

            services.AddTransient<ICategoryOfKeywordRepository, CategoryOfKeywordRepository>();
            services.AddTransient<ICategoryOfKeywordService, CategoryOfKeywordService>();
            
            services.AddTransient<ICriterionRepository, CriterionRepository>();
            services.AddTransient<ICriterionService, CriterionService>();

            services.AddTransient<ILevelRepository, LevelRepository>();
            services.AddTransient<ILevelService, LevelService>();

            services.AddTransient<IRoleRepository, RoleRepository>();
            services.AddTransient<IRoleService, RoleService>();

            services.AddTransient<IUserStatusRepository, UserStatusRepository>();
            services.AddTransient<IUserStatusService, UserStatusService>();

            services.AddTransient<IAccountRepository, AccountRepository>();
            services.AddTransient<IAccountService, AccountService>();

            services.AddControllers().AddFluentValidation();
            services.AddDbContext<EnglishDbContext>();
            services.AddScoped<EnglishDbSeeder>();
            services.AddAutoMapper(this.GetType().Assembly);
            services.AddControllers();
            services.AddScoped<ErrorHandlingMiddleware>();
            services.AddScoped<IPasswordHasher<User>, PasswordHasher<User>>();
            services.AddScoped<IValidator<RegisterUserDTO>, RegisterUserDTOValidator>();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "EnglishStoryWriter_API", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, EnglishDbSeeder englishDbSeeder)
        {
            englishDbSeeder.Seed();
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "EnglishStoryWriter_API v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
