namespace LibreriaMVC.Models.Contracts.Editoriales
{
    public class EditorialesContract
    {
        public string Codigo_editorial { get; set; }
        public string Nombre_editorial { get; set; }
        public string Contacto { get; set; } = string.Empty;
        public string Telefono { get; set; } = string.Empty;
    }
}
