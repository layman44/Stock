using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Area.Dtos
{
    [AutoMapFrom(typeof(Areas.Area))]
    public class AreaDto: EntityDto
    {
        public string Name { get; set; }
    }
}
