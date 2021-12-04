using AutoMapper;
using Poetry.Poetry;

namespace Poetry
{
    public class PoetryApplicationAutoMapperProfile : Profile
    {
        public PoetryApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */
            CreateMap<PoetryData, PoetryDataDto>();
            CreateMap<PoetryDataDto, PoetryData>();
        }
    }
}
