using Domain.Dtos.Requests;
using Domain.Dtos.Responses;

namespace Domain.Service.Interfaces;

public interface IDomainService
{
    Task<CreateUrlRecordResponseDto> CreateUrlRecord(CreateUrlRecordRequestDto requestDto);
}