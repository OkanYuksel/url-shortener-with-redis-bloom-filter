using Domain.Dtos.Requests;
using Domain.Dtos.Responses;
using Domain.Service.Interfaces;

namespace Domain.Service.Implementation;

public class DomainService : IDomainService
{
    public DomainService()
    {
    }

    public async Task<CreateUrlRecordResponseDto> CreateUrlRecord(CreateUrlRecordRequestDto requestDto)
    {
        
        
        return new CreateUrlRecordResponseDto();
    }
}