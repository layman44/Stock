namespace Stock
{
    public class StockConsts
    {
        public const string LocalizationSourceName = "Stock";

        /// <summary>
        ///股票状态 
        /// </summary>
        public enum StockStatus
        {
            正常 = 1,
            停牌 = -1,
            退市 = -2
        }

        public enum ShareholderCategory
        {
            十大股东 = 1,
            十大流通股东 = 2
        }

        public enum StockStage
        {
            吸筹 = 1,
            洗盘 = 2,
            拉升 = 3,
            出货 = 4
        }

        public enum ShareholderType
        {
            公募基金 = 1,
            私募基金 = 2,
            信托 = 3,
            资管计划 = 4,
            自然人 = 5
        }
    }
}