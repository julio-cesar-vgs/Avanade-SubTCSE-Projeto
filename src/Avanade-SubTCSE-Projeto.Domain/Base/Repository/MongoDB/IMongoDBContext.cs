using MongoDB.Driver;

namespace Avanade_SubTCSE_Projeto.Domain.Base.Repository.MongoDB
{
    public interface IMongoDBContext
    {
        IMongoCollection<TEntity>  GetCollection<TEntity>(string collection);
    }
}
