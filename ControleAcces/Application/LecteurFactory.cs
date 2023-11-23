using ControleAcces.Domaine;

namespace ControleAcces.Application;

/**
 * Autre Factory overkill
 */
public class LecteurFactory
{
    public static Lecteur AyantPourAdresse(ushort adresseSurLeBus)
    {
        return new Lecteur(adresseSurLeBus);
    }
}