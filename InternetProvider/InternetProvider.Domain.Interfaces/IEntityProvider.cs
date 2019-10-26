using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace InternetProvider.Domain.Interfaces
{
    public interface IEntityProvider<TEntity> where TEntity: IEntity<int>
    {
        void Create(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        TType DeleteById<TType>(TType id) where TType : IEntity<int>;
        TEntity GetSingle(Expression<Func<TEntity, bool>> filter);
        IEnumerable<TEntity> GetManyFiltered(
            Expression<Func<TEntity, bool>> filter, 
            int skip = 0, 
            int take = 10);
    }
}
