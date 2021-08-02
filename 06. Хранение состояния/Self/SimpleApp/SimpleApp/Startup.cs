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
            services.AddMemoryCache(); // ��� �������� ������ � ������ � ��� ������������� ����������� (IMemoryCache)
            services.AddSession(); // ��� ������������� ������
            services.AddControllersWithViews()
                .AddSessionStateTempDataProvider(); // TempData ����� ���������� � ������
        }

        public void Configure(IApplicationBuilder app, IHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();
            app.UseRouting();

            app.UseSession(); // ��� ������������� ������

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
