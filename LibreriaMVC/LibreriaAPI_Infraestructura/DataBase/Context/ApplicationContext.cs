using LibreriaAPI_Infraestructura.DataBase.Entities.Autores;
using LibreriaAPI_Infraestructura.DataBase.Entities.Editoriales;
using LibreriaAPI_Infraestructura.DataBase.Entities.Generos;
using LibreriaAPI_Infraestructura.DataBase.Entities.Libros;
using Microsoft.EntityFrameworkCore;

namespace LibreriaAPI_Infraestructura.DataBase.Context
{
    public class ApplicationContext : DbContext
    {
        #region [DBSets]
        public virtual DbSet<AutoresEntities> Autores { get; set; }
        public virtual DbSet<EditorialesEntities> Editoriales { get; set; }
        public virtual DbSet<GenerosEntities> Generos { get; set; }
        public virtual DbSet<LibrosEntities> Libros { get; set; }
        #endregion
        public ApplicationContext()
        {

        }
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
