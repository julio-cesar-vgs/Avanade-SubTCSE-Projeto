using Avanade_SubTCSE_Projeto.Domain.Base.Repository;
using Avanade_SubTCSE_Projeto.Domain.Aggregates;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace Avanade_SubTCSE_Projeto.Data.Repositories.Base
{
    //public abstract class BaseRepository<TEntity, Tid> where TEntity : BaseEntities<Tid>, IBaseRepository<TEntity, Tid>
    public abstract class BaseRepository<TEntity, Tid> : IBaseRepository<TEntity, Tid> where TEntity : BaseEntities<Tid>
    {
        private readonly IMongoCollection<TEntity> _collection;

        public virtual async Task<TEntity> Add(TEntity entity)
        {
            await _collection.InsertOneAsync(entity);
            return entity;
        }

        public virtual async Task<TEntity> FindById(Tid tid)
        {
            throw new System.NotImplementedException();
        }
    }
}
