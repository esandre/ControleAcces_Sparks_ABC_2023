using ControleAcces.Domaine;

namespace ControleAcces.Application;

public static class BadgeRepository
{
    private static readonly HashSet<int> Storage = new ();

    public static void Sauvegarder(Badge badgeCréé)
    {
        lock (Storage)
        {
            Storage.Add(badgeCréé.NuméroDeSérie);
        }
    }

    public static Badge RécupérerLeNuméro(int numéroSérie)
    {
        lock (Storage)
        {
            if (!Storage.Contains(numéroSérie))
                throw new KeyNotFoundException($"Aucun badge ayant le numéro {numéroSérie}");
        }

        return BadgeFactory.CréerPourLeNuméro(numéroSérie);
    }
}