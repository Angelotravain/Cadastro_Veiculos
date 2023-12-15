using AutoMapper;
using ListaVeiculos.Models.Dto;

namespace ListaVeiculos.Services.Negocios.Container
{
    public class MapeamentoContainer : Profile
    {
        public MapeamentoContainer()
        {
            CreateMap<Veiculo, VeiculoDto>();
            CreateMap<VeiculoDto, Veiculo>();
        }
    }
}
