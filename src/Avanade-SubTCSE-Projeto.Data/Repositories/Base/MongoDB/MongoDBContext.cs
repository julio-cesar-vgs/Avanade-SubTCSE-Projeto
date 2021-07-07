using Avanade_SubTCSE_Projeto.Domain.Base.Repository.MongoDB;
using MongoDB.Driver;

namespace Avanade_SubTCSE_Projeto.Data.Repositories.Base.MongoDB
{
    public class MongoDBContext : IMongoDBContext
    {
        public IMongoCollection<TEntity> GetCollection<TEntity>(string collection)
        {
            throw new System.NotImplementedException();
        }
    }
}
