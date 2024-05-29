using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibreriaAPI_Infraestructura.DataBase.Entities.Editoriales
{
    [Table("Editoriales")]
    public class EditorialesEntities
    {
        [Key]
        public string Codigo_editorial { get; set; }
        public string Nombre_editorial { get; set; }
        public string Contacto { get; set; } = string.Empty;
        public string Telefono { get; set; } = string.Empty;
    }
}
