using AutoMapper;
using LibreriaMVC.Models.Contracts.Autores;
using LibreriaMVC.Models.Contracts.Editoriales;
using LibreriaMVC.Models.Contracts.Generos;
using LibreriaMVC.Models.Contracts.Libros;
using LibreriaAPI_Infraestructura.DataBase.Entities.Autores;
using LibreriaAPI_Infraestructura.DataBase.Entities.Editoriales;
using LibreriaAPI_Infraestructura.DataBase.Entities.Generos;
using LibreriaAPI_Infraestructura.DataBase.Entities.Libros;

namespace LibreriaAPI_Configuracion.Configuracion
{
    public class AutoMapper : Profile
    {
        public AutoMapper()
        {
            CreateMap<AutoresEntities, AutoresContract>().ReverseMap();
            CreateMap<EditorialesEntities, EditorialesContract>().ReverseMap();
            CreateMap<GenerosEntities, GenerosContract>().ReverseMap();
            CreateMap<LibrosEntities, LibrosContract>().ReverseMap();
        }

    }
}
