using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace OJava.EntityFramework.Repositories
{
    public abstract class OJavaRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<OJavaDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected OJavaRepositoryBase(IDbContextProvider<OJavaDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class OJavaRepositoryBase<TEntity> : OJavaRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected OJavaRepositoryBase(IDbContextProvider<OJavaDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
