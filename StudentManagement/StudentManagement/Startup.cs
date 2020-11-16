using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using StudentManagement.Model;

namespace StudentManagement
{
    public class Startup
    {
        private readonly IConfiguration _configuration;


        /// <summary>
        /// ���캯�� ����ע��
        /// </summary>
        /// <param name="iconfiguration"></param>
        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }


        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(options => { options.EnableEndpointRouting = false; });
            services.AddSingleton<IStudentRepossitory, MockStudentRepossitory>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILogger<Startup> ilogger)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            
            app.UseRouting();
            app.UseFileServer();
            app.UseMvcWithDefaultRoute();

            app.UseEndpoints(endpoints =>
            {
                //throw new Exception("�����쳣");
                app.Use(async (context, next) =>
                {
                            context.Response.ContentType = "text/plain;charset=utf-8";
                            ilogger.LogInformation("���ʵ�һ���м��");
                            await context.Response.WriteAsync("���1!" + env.EnvironmentName);
                            await next();
                 });

                app.Use(async (context, next) =>
                {
                    ilogger.LogInformation("���ʵ�2���м��");
                    await context.Response.WriteAsync("���2!");
                    await next();
                });

                endpoints.MapGet("/", async (context) =>
                {
                    //var configval = _configuration["mykey"];
                    //await context.Response.WriteAsync(configval);
                    

                    await context.Response.WriteAsync("���3!");
                });
            });


        }
    }
}
