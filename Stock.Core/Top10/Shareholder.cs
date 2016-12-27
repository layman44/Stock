using System;
using System.ComponentModel.DataAnnotations;
using Abp.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace Stock.Top10
{
    [Table("TblShareholder")]
    public class Shareholder : Entity<string>
    {
        /// <summary>
        /// 股票代码
        /// </summary>
        [Key]
        public virtual String Code { get; set; }
        /// <summary>
        /// 披露时间
        /// </summary>
        public virtual DateTime DateOfPublish { get; set; }
        /// <summary>
        /// 股东名称
        /// </summary>
        public virtual String GDName { get; set; }
        /// <summary>
        /// 持股数量
        /// </summary>
        public virtual long CGAmount { get; set; }
        /// <summary>
        /// 持股占比
        /// </summary>
        public virtual long CGRate { get; set; }
        /// <summary>
        /// 股东类型：十大股东=1；十大流通股东=2
        /// </summary>
        public virtual StockConsts.ShareholderCategory GDCategory { get; set; }

        public virtual StockConsts.ShareholderType GDType { get; set; }
    }
}
