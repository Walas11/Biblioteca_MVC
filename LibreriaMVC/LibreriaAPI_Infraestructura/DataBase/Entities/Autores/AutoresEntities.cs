using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibreriaAPI_Infraestructura.DataBase.Entities.Autores
{
    [Table("Autores")]
    public class AutoresEntities
    {
        [Key]
        public string Codigo_autor { get; set; }
        public string Nombre_autor { get; set; }
        public string Nacionalidad { get; set; }
    }
}
