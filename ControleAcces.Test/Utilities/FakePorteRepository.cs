using ControleAcces.Domaine;
using ControleAcces.Port;

namespace ControleAcces.Test.Utilities;

public class FakePorteRepository : IPorteRepository
{
    /// <inheritdoc />
    public IEnumerable<Porte> Portes { get; init; }
}