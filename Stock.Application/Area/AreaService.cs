using Abp.Application.Services;
using System;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Stock.Area.Dtos;
using Abp.Domain.Repositories;
using AutoMapper;
using System.Collections.Generic;

namespace Stock.Area
{
    public class AreaService : ApplicationService, IAreaService
    {
        private readonly IRepository<Areas.Area, string> _areaRepository;

        public AreaService(IAreaRepository areaRepository)
        {
            _areaRepository = areaRepository;
        }

        public async Task<ListResultOutput<AreaDto>> GetChildList(GetAreaListInput input)
        {
            var startWith = input.ParentId.TrimEnd('0');
            var childs = await _areaRepository.GetAllListAsync(area => area.Id.StartsWith(startWith));
            return Mapper.Map<ListResultOutput<AreaDto>>(childs);
        }

        public async Task<GetRootsOutput> GetRoots()
        {
            var endWith = "0000";
            var roots = await _areaRepository.GetAllListAsync(area => area.Id.EndsWith(endWith));
            return new GetRootsOutput
            {
                Roots = Mapper.Map<List<AreaDto>>(roots)
            };
        }

        public async Task Insert(InsertAreaInput input)
        {
            Areas.Area area = new Areas.Area();
            area.Id = input.Id;
            area.Name = input.Name;
            await _areaRepository.InsertAsync(area);
        }

        public async Task Update(UpdateAreaInput input)
        {
            Areas.Area area = await _areaRepository.GetAsync(input.Id);
            area.Name = input.Name;
            await _areaRepository.UpdateAsync(area);
        }
    }
}
