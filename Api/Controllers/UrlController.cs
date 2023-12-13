using Application.Commands.CreateUrlRecord.Dtos;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using url_shortener_with_redis_bloom_filter.Dtos.Requests;

namespace url_shortener_with_redis_bloom_filter.Controllers;

[ApiController]
[Route("[controller]")]
public class UrlController : ControllerBase
{

    private readonly ILogger<UrlController> _logger;
    private readonly IMediator _mediator;

    public UrlController(IMediator mediator, ILogger<UrlController> logger)
    {
        _mediator = mediator;
        _logger = logger;
    }

    [HttpPost(Name = "Create")]
    public async Task<ActionResult> Create([FromBody] CreateShortLinkRequest request)
    {
        var response = await _mediator.Send(new CreateUrlRecordCommand()
        {
            LongLink = request.LongLink
        });
        return Ok(response);
    }
}