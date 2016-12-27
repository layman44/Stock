using Abp.EntityFramework;
using System.Data.Entity;

namespace Stock.EntityFramework
{
    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    public class StockDbContext : AbpDbContext
    {
        //TODO: Define an IDbSet for each Entity...
        public virtual IDbSet<Areas.Area> Areas { get; set; }

        public virtual IDbSet<Industries.Industry> Industries { get; set; }

        public virtual IDbSet<Stock.StockBaseInfo> StockBaseInfos { get; set; }

        //Example:
        //public virtual IDbSet<User> Users { get; set; }

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public StockDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in StockDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of StockDbContext since ABP automatically handles it.
         */
        public StockDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }
    }
}
