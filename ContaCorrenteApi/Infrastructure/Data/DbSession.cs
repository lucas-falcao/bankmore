using System.Data;
using Microsoft.Data.Sqlite;

namespace ContaCorrenteApi.Infrastructure.Data;

public class DbSession : IDisposable
{
    public IDbConnection Connection { get; }
    public DbSession(IConfiguration configuration)
    {
        Connection = new SqliteConnection(configuration.GetConnectionString("DefaultConnection"));
        Connection.Open();
    }
    public void Dispose()
    {
        Connection.Close();
    }
}