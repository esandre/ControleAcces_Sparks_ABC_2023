using ControleAcces.Application;
using ControleAcces.Domaine;

namespace ControleAcces.Test.Utilities;

internal class PorteBuilder
{
    private PorteFactory _factory = new ();

    public static PorteSpy Default => new PorteBuilder().Build();

    public PorteSpy Build()
    {
        var porte = _factory.Décorée(porte => new PorteSpy(porte)).Build();
        return (PorteSpy)porte; // Violation de polymorphisme acceptable uniquement dans le cadre de tests.
    }

    public PorteBuilder AyantUnMotSpécifique(ushort mot)
    {
        _factory = _factory.AyantPourMot(mot);
        return this;
    }

    public PorteBuilder LiéeAuLecteur(Lecteur lecteur)
    {
        _factory = _factory.LiéeAuLecteur(lecteur);
        return this;
    }
}