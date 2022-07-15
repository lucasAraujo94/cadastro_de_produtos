using AutoMapper;
using Cadastro_De_Produtos.Api.Dtos;
using Cadastro_De_Produtos.Business.Models;

namespace Cadastro_De_Produtos.Api.Configuration
{
    public class AutoMapper : Profile
    {
        public AutoMapper()
        {
            CreateMap<Example, ExampleDto>().ReverseMap();
        }
    }
}
