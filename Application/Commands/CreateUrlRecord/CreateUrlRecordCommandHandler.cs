using Application.Commands.CreateUrlRecord.Dtos;
using Domain.Service.Interfaces;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Application.Commands.CreateUrlRecord;

public class CreateUrlRecordCommandHandler : IRequestHandler<CreateUrlRecordCommand, CreateUrlRecordCommandResult>
{
    private readonly IDomainService _domainService;
    private readonly ILogger<CreateUrlRecordCommandHandler> _logger;

    public CreateUrlRecordCommandHandler(
        IDomainService domainService,
        ILogger<CreateUrlRecordCommandHandler> logger)
    {
        _domainService = domainService;
        _logger = logger;
    }

    public async Task<CreateUrlRecordCommandResult> Handle(CreateUrlRecordCommand request,
        CancellationToken cancellationToken)
    {
        _logger.LogInformation("CreateUrlCommand handled.");

        // var result = _domainService.CreateUrlRecord();
        CreateUrlRecordCommandResult response = new CreateUrlRecordCommandResult();
        

        return response;
    }
}