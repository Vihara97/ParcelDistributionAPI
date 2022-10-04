using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json.Serialization;
using ParcelDistributionAPI.Data;
using ParcelDistributionAPI.Data.Repositories;

namespace ParcelDistributionAPI
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
            //Enable CORS - to allow requests from different domains
            services.AddCors(x =>
            {
                x.AddPolicy("AllowOrigin", options => options.AllowAnyOrigin().AllowAnyMethod()
                .AllowAnyHeader());
            });

            //JSON serializer - to serializer class to keep JSON serializer as default
            services.AddControllersWithViews()
                .AddNewtonsoftJson(options =>
                {
                    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
                })
                .AddNewtonsoftJson(options =>
                {
                    options.SerializerSettings.ContractResolver = new DefaultContractResolver();
                });

            //Db connection
            services.AddDbContext<DataContext>(x =>
            {
                x.UseSqlServer(Configuration.GetConnectionString("DefaultConnectionString"));
            });

            //Register repositories as a service
            services.AddScoped<ICustomerRepository, CustomerRepository>();

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
