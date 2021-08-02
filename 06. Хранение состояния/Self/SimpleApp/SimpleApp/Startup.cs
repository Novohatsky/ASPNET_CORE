using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleApp
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMemoryCache(); // дл€ хранени€ сессии в пам€ти и дл€ использовани€ кэшировани€ (IMemoryCache)
            services.AddSession(); // дл€ использовани€ сессии
            services.AddControllersWithViews()
                .AddSessionStateTempDataProvider(); // TempData будет сохран€тс€ в сессии
        }

        public void Configure(IApplicationBuilder app, IHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();
            app.UseRouting();

            app.UseSession(); // дл€ использовани€ сессии

            app.UseEndpoints(routes =>
            {
                routes.MapControllerRoute(
                    name: "Default",
                    pattern: "{controller=home}/{action=index}/{id?}"
                );
            });
        }
    }
}
