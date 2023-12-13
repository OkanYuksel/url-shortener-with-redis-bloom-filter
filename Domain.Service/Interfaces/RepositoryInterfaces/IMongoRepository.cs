using Domain.Aggregates;

namespace Domain.Service.Interfaces.RepositoryInterfaces;

public interface IMongoRepository
{
    Task<List<UrlRecord>> GetAsync();

    Task<UrlRecord?> GetAsync(string id);

    Task CreateAsync(UrlRecord newUrlRecord);

    Task UpdateAsync(string id, UrlRecord updatedUrlRecord);

    Task RemoveAsync(string id);
}