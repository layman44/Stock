using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stock.Industries;
using Stock.Areas;

namespace Stock.StockBaseInfo
{
    [Table("TblStockBaseInfo")]
    public class StockBaseInfo:Entity<string>
    {
        public const int MaxCodeLength = 6;
        /// <summary>
        /// 股票代码
        /// </summary>
        [Key]
        public virtual string Code { get; set; }
        /// <summary>
        /// 股票名称
        /// </summary>
        public virtual string Name { get; set; }
        /// <summary>
        /// 所属行业
        /// </summary>
        [ForeignKey("IndustryId")]
        public virtual Industry Industry { get; set; }
        /// <summary>
        /// 行业数据ID
        /// </summary>
        public virtual int IndustryId { get; set; }
        /// <summary>
        /// 地区
        /// </summary>
        [ForeignKey("AreaId")]
        public virtual Area Area { get; set; }
        /// <summary>
        /// 地区编码
        /// </summary>
        public virtual String AreaId { get; set; }

        /// <summary>
        /// 上市日期
        /// </summary>
        public virtual DateTime DateOfIPO { get; set; }

        public StockBaseInfo()
        {

        }
    }
}
