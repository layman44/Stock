using Abp.Application.Services.Dto;
using AutoMapper;
using Stock.Area.Dtos;
using System.Collections.Generic;

namespace Stock
{
    internal static class DtoMappings
    {
        public static void Map()
        {
            Mapper.CreateMap<Areas.Area, AreaDto>();
            Mapper.CreateMap<List<Areas.Area>, ListResultOutput<AreaDto>>();
        }
    }
}
