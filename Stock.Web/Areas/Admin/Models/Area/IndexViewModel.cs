using Stock.Area.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Stock.Web.Areas.Admin.Models.Area
{
    public class IndexViewModel
    {
        public IReadOnlyList<AreaDto> Areas { get; }
        public IndexViewModel(IReadOnlyList<AreaDto> areas)
        {
            Areas = areas;
        }
    }
}