namespace Application.Commands.CreateUrlRecord.Dtos;

public class CreateUrlRecordCommandResult
{
    public bool IsExists { get; set; }
    public string ShortLink { get; set; }
    public bool IsSuccess { get; set; }
}