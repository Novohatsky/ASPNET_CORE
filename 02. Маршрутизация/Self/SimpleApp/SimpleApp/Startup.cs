using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace SimpleApp
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            // AddMvc - добавляет сервисы, необходимые для работы MVC, включая Razor-страницы
             services.AddMvc();
        }

        public void Configure(IApplicationBuilder app, IHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "Default",
                    pattern: "{controller=home}/{action=index}");

                endpoints.MapControllerRoute(
                        name: "ViewProduct",
                        pattern: "{controller=Product}/{action=List}/{id?}");
            });

            // {id?} - данный фрагмент шаблона описывает не обязательный сегмент в адресе запроса.
            // При этом в контроллерах по имени id можно будет получить информацию, которая пришла в запросе
            // Products/Details/10
            // {controller} = Products
            // {action} = Details
            // {id} = 10
        }
    }
}
