namespace LibreriaMVC.Models.Contracts.Generos
{
    public class GenerosContract
    {
        public int Id_genero { get; set; }
        public string Nombre_genero { get; set; }
        public string Descripcion { get; set; } = string.Empty;
    }
}
