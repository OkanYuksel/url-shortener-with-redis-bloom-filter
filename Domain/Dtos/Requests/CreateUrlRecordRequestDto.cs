namespace Domain.Dtos.Requests;

public class CreateUrlRecordRequestDto
{
    public CreateUrlRecordRequestDto(string longLink)
    {
        LongLink = longLink;
    }
    public string LongLink { get; set; }
}