using MediatR;

namespace Application.Commands.CreateUrlRecord.Dtos;

public class CreateUrlRecordCommand : IRequest<CreateUrlRecordCommandResult>
{
    public string LongLink { get; set; }
}