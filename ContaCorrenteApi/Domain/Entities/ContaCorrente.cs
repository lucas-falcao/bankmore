

using System.ComponentModel.DataAnnotations;

namespace ContaCorrenteApi.Domain.Entities;

public class ContaCorrente
{
    [Key]
    public Guid IdContaCorrente { get; set; }
    public string Numero { get; set; } = string.Empty;
    public string Nome { get; set; } = string.Empty;
    public bool Ativo { get; set; }
    public string Senha { get; set; } = string.Empty;
    //public string salt { get; set; } = string.Empty;
}
