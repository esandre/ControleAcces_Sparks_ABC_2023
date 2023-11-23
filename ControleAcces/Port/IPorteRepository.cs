using ControleAcces.Domaine;

namespace ControleAcces.Port;

public interface IPorteRepository
{
    IEnumerable<Porte> Portes { get; }
}