using Domain.Aggregates;
using Domain.Models;
using Domain.Service.Interfaces.RepositoryInterfaces;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace Infrastructure.Repositories;

public class MongoRepository : IMongoRepository
{
    private readonly IMongoCollection<UrlRecord> _urlCollection;

    public MongoRepository(
        IOptions<UrlStoreDatabaseSettings> urlStoreDatabaseSettings)
    {
        var mongoClient = new MongoClient(
            urlStoreDatabaseSettings.Value.ConnectionString);

        var mongoDatabase = mongoClient.GetDatabase(
            urlStoreDatabaseSettings.Value.DatabaseName);

        _urlCollection = mongoDatabase.GetCollection<UrlRecord>(
            urlStoreDatabaseSettings.Value.CollectionName);
    }

    public async Task<List<UrlRecord>> GetAsync() =>
        await _urlCollection.Find(_ => true).ToListAsync();

    public async Task<UrlRecord?> GetAsync(string id) =>
        await _urlCollection.Find(x => x.Id == id).FirstOrDefaultAsync();

    public async Task CreateAsync(UrlRecord newUrlRecord) =>
        await _urlCollection.InsertOneAsync(newUrlRecord);

    public async Task UpdateAsync(string id, UrlRecord updatedUrlRecord) =>
        await _urlCollection.ReplaceOneAsync(x => x.Id == id, updatedUrlRecord);

    public async Task RemoveAsync(string id) =>
        await _urlCollection.DeleteOneAsync(x => x.Id == id);
}