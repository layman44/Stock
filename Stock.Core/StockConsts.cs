namespace Stock
{
    public class StockConsts
    {
        public const string LocalizationSourceName = "Stock";
        
        /// <summary>
        ///股票状态 
        /// </summary>
        public  enum StockStatus
        {
            正常=1,
            停牌=-1,
            退市=-2
        }
    }
}