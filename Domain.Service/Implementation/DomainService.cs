using Domain.Aggregates;
using Domain.Dtos.Requests;
using Domain.Dtos.Responses;
using Domain.Service.Interfaces;
using Domain.Service.Interfaces.RepositoryInterfaces;

namespace Domain.Service.Implementation;

public class DomainService : IDomainService
{
    private readonly IMongoRepository _mongoRepository;
    public DomainService(IMongoRepository mongoRepository)
    {
        _mongoRepository = mongoRepository;
    }

    public async Task<CreateUrlRecordResponseDto> CreateUrlRecord(CreateUrlRecordRequestDto requestDto)
    {
        var urlRecord = await _mongoRepository.GetByLongLinkAsync(requestDto.LongLink);

        if (urlRecord != null)
        {
            return new CreateUrlRecordResponseDto()
            {
                ShortLink = urlRecord.ShortLink,
                IsExists = true,
                IsSuccess = true
            };
        }

        urlRecord = new UrlRecord(requestDto.LongLink, "asd", DateTime.Now);
            
        await _mongoRepository.CreateAsync(urlRecord);
        
        return new CreateUrlRecordResponseDto()
        {
            ShortLink = urlRecord.ShortLink,
            IsExists = false,
            IsSuccess = true
        };
    }
}