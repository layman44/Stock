using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace Stock.EntityFramework.Repositories
{
    public abstract class StockRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<StockDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected StockRepositoryBase(IDbContextProvider<StockDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class StockRepositoryBase<TEntity> : StockRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected StockRepositoryBase(IDbContextProvider<StockDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
