namespace LibreriaMVC.Models.Contracts.Libros
{
    public class LibrosContract
    {
        public string Codigo_libro { get; set; }
        public string Nombre_libro { get; set; }
        public int Existencias { get; set; }
        public double Precio { get; set; }
        public string Codigo_autor { get; set; }
        public string Codigo_editorial { get; set; }
        public string Id_genero { get; set; }
        public string Descripcion { get; set; } = string.Empty;
    }
}
