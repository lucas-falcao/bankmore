using MediatR;

namespace ContaCorrenteApi.Domain.Comands;

public class CriarContaCorrenteCommand : IRequest
{
    public string Numero { get; set; } = string.Empty;
    public string Nome { get; set; } = string.Empty;
    public string Senha { get; set; } = string.Empty;
}

