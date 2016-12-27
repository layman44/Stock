using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Stock
{
    [Table("TblStockDetail")]
    public class StockDetail : Entity<string>
    {
        [Key]
        public virtual string Code { get; set; }
        /// <summary>
        /// 流通市值
        /// </summary>
        public virtual long LTSZ { get; set; }

        /// <summary>
        /// 总市值
        /// </summary>
        public virtual long ZSZ { get; set; }

        /// <summary>
        /// 流通股本
        /// </summary>
        public virtual long LTGB { get; set; }

        /// <summary>
        /// 总股本
        /// </summary>
        public virtual long ZGB { get; set; }
        
        /// <summary>
        /// 每股公积金
        /// </summary>
        public virtual long MGGJJ { get; set; }

        /// <summary>
        /// 每股净资产
        /// </summary>
        public virtual long MGJZC { get; set; }


    }
}
