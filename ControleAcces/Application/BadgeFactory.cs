using ControleAcces.Domaine;

namespace ControleAcces.Application;

/**
 * Complètement overkill vu la complexité de la création du badge, c'est pour l'exemple
 */
public static class BadgeFactory
{
    public static Badge CréerPourLeNuméro(int numéroSérie)
    {
        return new Badge(numéroSérie);
    }
}