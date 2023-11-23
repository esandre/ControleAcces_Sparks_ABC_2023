using ControleAcces.Domaine;

namespace ControleAcces.Port;

public interface IPorteRepository
{
    IEnumerable<IPorte> Portes { get; }
}