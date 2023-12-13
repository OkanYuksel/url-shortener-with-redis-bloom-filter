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

        await _mongoRepository.CreateAsync(new UrlRecord(requestDto.LongLink, "asd", DateTime.Now));
        
        return new CreateUrlRecordResponseDto()
        {
            ShortLink = "asd",
            IsExists = false,
            IsSuccess = true
        };
    }
}