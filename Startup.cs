using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ProjetoKanban.Dados;
using ProjetoKanban.Filtro;

namespace ProjetoKanban
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            var demoMode = Configuration.GetValue<bool>("DemoMode");

            services.AddDbContext<Context>(options =>
            {
                if (demoMode)
                {
                    options.UseLazyLoadingProxies().UseInMemoryDatabase("ProjetoKanbanDemo");
                }
                else
                {
                    options.UseLazyLoadingProxies().UseSqlServer(
                        Configuration.GetConnectionString("DefaultConnection"));
                }
            });

            services.AddControllersWithViews();
            services.AddSession();
            services.AddScoped<Autenticacao>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseSession();

            if (!Configuration.GetValue<bool>("DemoMode"))
                app.UseHttpsRedirection();

            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Login}/{action=Index}/{id?}");
            });
        }
    }
}
