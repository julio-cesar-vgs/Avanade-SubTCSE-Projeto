﻿using Avanade_SubTCSE_Projeto.Domain.Base.Repository.MongoDB;
using MongoDB.Driver;

namespace Avanade_SubTCSE_Projeto.Data.Repositories.Base.MongoDB
{
    public class MongoDBContext : IMongoDBContext
    {
        private readonly IMongoDatabase _mongoDatabase;
        public MongoDBContext()
        {
            MongoClientSettings mongoClientSettings = MongoClientSettings.FromUrl(new MongoUrl(""));

            mongoClientSettings.SslSettings = new SslSettings()
            {
                EnabledSslProtocols = System.Security.Authentication.SslProtocols.Tls12
            };

            var mongoClient = new MongoClient(settings: mongoClientSettings);

            _mongoDatabase = mongoClient.GetDatabase("");
        }

        public IMongoCollection<TEntity> GetCollection<TEntity>(string collection)
        {
            return _mongoDatabase.GetCollection<TEntity>(collection);
        }
    }
}
