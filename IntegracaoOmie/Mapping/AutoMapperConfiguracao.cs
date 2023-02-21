using AutoMapper;
namespace IntegracaoOmie.Mapping;

public class AutoMapperConfiguracao : Profile
{
    public AutoMapperConfiguracao()
    {
        CreateMap(typeof(Models.ResponseGenerico<>), typeof(Models.ResponseGenerico<>));
      //  CreateMap<Models.Cliente.ClientesCadastroResumido, >
    }
}
