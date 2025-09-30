using ContaCorrenteApi.Domain.Entities;

namespace ContaCorrenteApi.Infrastructure.Repositories;

public interface IContaCorrenteRepository
{
    Task CriarContaCorrente(ContaCorrente conta);
}
