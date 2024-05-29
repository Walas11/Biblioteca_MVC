using AutoMapper;

namespace LibreriaAPI_Configuracion.Configuracion
{
    internal class AutoMapper : Profile
    {
        CreateMap<AutoresEntities, AutoresContract>().ReverseMap();
        CreateMap<EditorialesEntities, EditorialesContract>().ReverseMap();
        CreateMap<GenerosEntities, GenerosContract>().ReverseMap();
        CreateMap<LibrosEntities, LibrosContract>().ReverseMap();
    }
}
