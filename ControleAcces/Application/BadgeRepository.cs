using ControleAcces.Domaine;

namespace ControleAcces.Application;

public class BadgeRepository
{
    private readonly BadgeFactory _factory;
    private readonly HashSet<int> _storage = new ();

    public BadgeRepository(BadgeFactory factory)
    {
        _factory = factory;
    }

    public void Sauvegarder(Badge badgeCréé)
    {
        lock (_storage)
        {
            _storage.Add(badgeCréé.NuméroDeSérie);
        }
    }

    public Badge RécupérerLeNuméro(int numéroSérie)
    {
        lock (_storage)
        {
            if (!_storage.Contains(numéroSérie))
                throw new KeyNotFoundException($"Aucun badge ayant le numéro {numéroSérie}");
        }

        return _factory.CréerPourLeNuméro(numéroSérie);
    }
}