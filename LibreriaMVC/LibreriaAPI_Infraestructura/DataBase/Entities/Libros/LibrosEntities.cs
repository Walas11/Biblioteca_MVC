using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibreriaAPI_Infraestructura.DataBase.Entities.Libros
{
    [Table("Libros")]
    public class LibrosEntities
    {
        [Key]
        public string Codigo_libro { get; set; }
        public string Nombre_libro { get; set; }
        public int Existencias { get; set; }
        public decimal Precio { get; set; }
        public string Codigo_autor { get; set; }
        public string Codigo_editorial { get; set; }
        public int Id_genero { get; set; }
        public string Descripcion { get; set; } = string.Empty;
    }
}
