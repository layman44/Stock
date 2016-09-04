using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Stock.Area.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Area
{
    public interface IAreaService : IApplicationService
    {
        Task<ListResultOutput<AreaDto>> GetChildList(GetAreaListInput input);
        Task<GetRootsOutput> GetRoots();
        Task Insert(InsertAreaInput input);
        Task Update(UpdateAreaInput input);
    }
}
