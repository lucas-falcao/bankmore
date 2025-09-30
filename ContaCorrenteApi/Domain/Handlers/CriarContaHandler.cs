using ContaCorrenteApi.Domain.Comands;
using ContaCorrenteApi.Domain.Entities;
using ContaCorrenteApi.Infrastructure.Repositories;
using MediatR;

namespace ContaCorrenteApi.Domain.Handlers;

public class CriarContaHandler : IRequestHandler<CriarContaCorrenteCommand>
{
    private readonly IContaCorrenteRepository _contaRepository;
    public CriarContaHandler(IContaCorrenteRepository contaRepository)
    {
        _contaRepository = contaRepository;
    }
    public async Task Handle(CriarContaCorrenteCommand request, CancellationToken cancellationToken)
    {
        var conta = new ContaCorrente
        {
            IdContaCorrente = Guid.NewGuid(),
            Ativo = true,
            Numero = request.Numero,
            Nome = request.Nome,
            Senha = request.Senha,
        };
        
        await _contaRepository.CriarContaCorrente(conta);
    }
}

