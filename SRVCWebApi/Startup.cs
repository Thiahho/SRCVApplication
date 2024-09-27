using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using SRVCWebApi.Repositorios;

public class Startup
{
    public IConfiguration Configuration { get; }

    // Constructor
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    // Este método se llama en tiempo de ejecución. Usa este método para agregar servicios al contenedor.
    public void ConfigureServices(IServiceCollection services)
    {
        // Aquí puedes agregar los servicios que necesites, como Entity Framework, MVC, etc.
        services.AddControllers(); // Agrega soporte para controladores
                                   //services.AddDbContext<DbContext>(options =>
                                   //    options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"))); // Descomenta y configura tu contexto

        //SE DECLARA CADA REPOSITORIO
        services.AddScoped<HistoryRepository>();
        services.AddScoped<UsuarioRepositorio>();

        services.AddCors(options =>
        {
            options.AddPolicy("AllowAll",
                builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
        });

        services.AddSwaggerGen();

    }

    // Este método se llama en tiempo de ejecución. Usa este método para configurar la tubería de solicitud HTTP.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "API-V1");
            });
        }
        else
        {
            app.UseExceptionHandler("/Home/Error");
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();

        app.UseAuthorization();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });
    }
}
