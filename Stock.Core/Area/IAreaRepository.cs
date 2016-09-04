using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Area
{
    public interface IAreaRepository : IRepository<Areas.Area, string>
    {
        Task<List<Areas.Area>> GetRootListAsync();
    }
}
