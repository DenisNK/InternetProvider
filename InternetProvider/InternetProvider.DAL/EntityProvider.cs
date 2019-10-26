using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using InternetProvider.Domain;
using InternetProvider.Domain.Interfaces;

namespace InternetProvider.DAL
{
    public class EntityProvider<TEntity> : IEntityProvider<TEntity> where TEntity : IEntity<int>
    {
        private readonly InternetProviderContext _context;
        public EntityProvider(InternetProviderContext context)
        {
            _context = context;
        }
        public void Create(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public TType DeleteById<TType>(TType id) where TType : IEntity<int>
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetManyFiltered(Expression<Func<TEntity, bool>> filter, int skip = 0, int take = 10)
        {
            throw new NotImplementedException();
        }

        public TEntity GetSingle(Expression<Func<TEntity, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
