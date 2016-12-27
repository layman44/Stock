using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;
using Stock.Industries;

namespace Stock.Stock
{
    [Table("TblStockBaseInfo")]
    public class StockBaseInfo : Entity<string>
    {
        public const int MaxCodeLength = 6;
        public const int MinCodeLength = 6;
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
        public virtual Areas.Area Area { get; set; }
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
