using ControleAcces.Domaine;
using ControleAcces.Port;

namespace ControleAcces.Application;

public class BadgeRepository
{
    private readonly BadgeFactory _factory;
    private readonly IDataStorage _dataStorage;

    public BadgeRepository(BadgeFactory factory, IDataStorage dataStorage)
    {
        _factory = factory;
        _dataStorage = dataStorage;
    }

    public void Sauvegarder(Badge badgeCréé)
    {
        _dataStorage.StoreBadge(badgeCréé.NuméroDeSérie);
    }

    public Badge RécupérerLeNuméro(int numéroSérie)
    {
        if (!_dataStorage.BadgeExists(numéroSérie))
            throw new KeyNotFoundException($"Aucun badge ayant le numéro {numéroSérie}");

        return _factory.CréerPourLeNuméro(numéroSérie);
    }
}