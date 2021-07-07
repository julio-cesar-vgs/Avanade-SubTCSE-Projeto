using Avanade_SubTCSE_Projeto.Domain.Base.Repository.MongoDB;
using MongoDB.Driver;

namespace Avanade_SubTCSE_Projeto.Data.Repositories.Base.MongoDB
{
    public class MongoDBContext : IMongoDBContext
    {
        public MongoDBContext()
        {
            MongoClientSettings mongoClientSettings = MongoClientSettings.FromUrl(new MongoUrl(""));

            mongoClientSettings.SslSettings = new SslSettings()
            {
                EnabledSslProtocols = System.Security.Authentication.SslProtocols.Tls12
            };

            var mongoClient = new MongoClient(settings: mongoClientSettings);
        }

        public IMongoCollection<TEntity> GetCollection<TEntity>(string collection)
        {
            throw new System.NotImplementedException();
        }
    }
}
