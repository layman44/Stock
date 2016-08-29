using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;

namespace Stock.Industries
{
    [Table("TblIndustry")]
    public class Industry:Entity<int>
    {
        /// <summary>
        /// 行业名称
        /// </summary>
        public virtual string Name { get; set; }
        /// <summary>
        /// 行业描述
        /// </summary>
        public virtual string Desc { get; }
    }
}
