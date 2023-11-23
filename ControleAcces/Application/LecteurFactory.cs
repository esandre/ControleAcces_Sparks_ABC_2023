using ControleAcces.Domaine;

namespace ControleAcces.Application;

/**
 * Autre Factory overkill
 */
public static class LecteurFactory
{
    public static Lecteur AyantPourAdresse(ushort adresseSurLeBus)
    {
        return new Lecteur(adresseSurLeBus);
    }
}