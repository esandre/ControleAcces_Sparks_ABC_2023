using ControleAcces.Port;

namespace ControleAcces.Test.Utilities;

internal class FakeDataStorage : IDataStorage
{
    private readonly HashSet<int> _badgesConnus = new();

    /// <inheritdoc />
    public void StoreBadge(int numéroSérie) => _badgesConnus.Add(numéroSérie);

    /// <inheritdoc />
    public bool BadgeExists(int numéroSérie) => _badgesConnus.Contains(numéroSérie);
}