using ContaCorrenteApi.Domain.Comands;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ContaCorrenteApi.Application.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ContaCorrenteController : ControllerBase
{
    private readonly IMediator _mediator;

    public ContaCorrenteController(IMediator mediator)
    {
        _mediator = mediator;
    }
    [HttpPost]
    public async Task<IActionResult> CriarContaCorrente([FromBody] CriarContaCorrenteCommand command)
    {
        await _mediator.Send(command);
        return Ok();
    }
}
