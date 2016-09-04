using Stock.Area;
using System;
using System.Collections.Generic;
using Abp.EntityFramework;
using System.Linq;
using Stock.Areas;
using System.Threading.Tasks;

namespace Stock.EntityFramework.Repositories.Area
{
    public class AreaRepository : StockRepositoryBase<Areas.Area, string>, IAreaRepository
    {
        public AreaRepository(IDbContextProvider<StockDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }

        public async Task<List<Areas.Area>> GetRootListAsync()
        {
            var endWith = "0000";
            var query = await GetAllListAsync();
            return query.Where(area => area.Id.EndsWith(endWith)).ToList();
        }
    }
}
