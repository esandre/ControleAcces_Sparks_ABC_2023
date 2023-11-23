using ControleAcces.Application;
using ControleAcces.Domaine;

namespace ControleAcces.Test.Utilities;

internal class LecteurBuilder
{
    private ushort _adresseSurLeBus = 0x1;

    public static Lecteur Default => new LecteurBuilder().Build();

    public LecteurBuilder AyantUneAdresseSpécifique(ushort adresseSurLeBus)
    {
        _adresseSurLeBus = adresseSurLeBus;
        return this;
    }

    public Lecteur Build()
    {
        return LecteurFactory.AyantPourAdresse(_adresseSurLeBus);
    }
}