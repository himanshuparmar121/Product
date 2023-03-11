using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Product.API.Helpers;
using Product.Data;
using Product.Data.IRepository;
using Product.Data.Repository;
using Product.Service.IServices;
using Product.Service.Services;

namespace Product.API
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
            var connectionString = Configuration.GetConnectionString("DefaultConnection");

            services.Configure<KestrelServerOptions>(options =>
            {
                options.AllowSynchronousIO = true;
            });

            // If using IIS:
            services.Configure<IISServerOptions>(options =>
            {
                options.AllowSynchronousIO = true;
            });

            services.AddCors(options => options.AddPolicy("ApiCorsPolicy", builder =>
            {
                builder.AllowAnyMethod().AllowAnyHeader().AllowCredentials();
            }));

            services.AddDbContext <ApplicationDbContext> (options => options.UseSqlServer(connectionString), ServiceLifetime.Transient);

            Dependencies.Dependency(services);

            services.AddControllers();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerGeneratorOptions.IgnoreObsoleteActions = true;
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Product", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseCors("ApiCorsPolicy");

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.UseCors("AllowCors");

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseSwagger();

            app.UseSwaggerUI(c => c.SwaggerEndpoint("../swagger/v1/swagger.json", "API v1"));
        }
    }
}
