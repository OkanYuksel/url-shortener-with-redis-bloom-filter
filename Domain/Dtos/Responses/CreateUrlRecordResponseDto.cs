namespace Domain.Dtos.Responses;

public class CreateUrlRecordResponseDto
{
    public bool IsExists { get; set; }
    public string ShortLink { get; set; }
    public bool IsSuccess { get; set; }
}