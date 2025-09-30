
using ContaCorrenteApi.Domain.Entities;
using ContaCorrenteApi.Infrastructure.Data;

namespace ContaCorrenteApi.Infrastructure.Repositories;

public class ContaCorrenteRepository : IContaCorrenteRepository
{
    // private DbSession _dbSession;
    private readonly AppDbContext _context;
    // public ContaCorrenteRepository(DbSession dbSession)
    // {
    //     _dbSession = dbSession;
    // }
    public ContaCorrenteRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task CriarContaCorrente(ContaCorrente conta)
    {
        await _context.AddAsync(conta);
        await _context.SaveChangesAsync();
    }

}
