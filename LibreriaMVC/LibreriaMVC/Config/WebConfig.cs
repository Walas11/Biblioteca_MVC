using AutoMapper;
using Microsoft.EntityFrameworkCore;
using NetCore.AutoRegisterDi;
using System.Reflection;
using LibreriaAPI_Infraestructura.DataBase.Context;

namespace LibreriaMVC.Config
{
    public class WebConfig
    {
        public static void Register(IServiceCollection services, IConfiguration configuration)
        {
            //#region [Configuración Perfil AutoMapper]
            //var configMapper = new MapperConfiguration(cfg => cfg.AddProfile(new AutoMapper()));
            //var mapper = configMapper.CreateMapper();
            //services.AddSingleton(mapper);
            //#endregion

            #region [Inicializar Conexion con Base de Datos]
            services.AddTransient<ApplicationContext, ApplicationContext>();
            services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")), ServiceLifetime.Transient);
            services.AddSingleton(configuration);

            #endregion

            #region [Registro Inyección de Dependencias]
            var assembliesToScan = new[]
            {
                Assembly.GetExecutingAssembly(),
                Assembly.Load("LibreriaMVC"),
                Assembly.Load("LibreriaAPI_Infraestructura"),
            };
            services.RegisterAssemblyPublicNonGenericClasses(assembliesToScan)
                .Where(c => c.Name.EndsWith("Repository") ||
                       c.Name.EndsWith("Service") ||
                       c.Name.EndsWith("Resource"))
                .AsPublicImplementedInterfaces();
            #endregion
        }
    }
}
