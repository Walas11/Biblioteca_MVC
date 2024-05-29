using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibreriaAPI_Infraestructura.DataBase.Entities.Generos
{
    [Table("Generos")]
    public class GenerosEntities
    {
        [Key]
        public int Id_genero { get; set; }
        public string Nombre_genero { get; set; }
        public string Descripcion { get; set; } = string.Empty;
    }
}
