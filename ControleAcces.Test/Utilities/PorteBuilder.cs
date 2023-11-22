namespace ControleAcces.Test.Utilities;

internal class PorteBuilder
{
    private ushort _mot = 0x00;
    private Lecteur? _lecteur;

    public static PorteSpy Default => new PorteBuilder().Build();

    public PorteSpy Build()
    {
        return new PorteSpy(_mot, _lecteur ?? LecteurBuilder.Default);
    }

    public PorteBuilder AyantUnMotSpécifique(ushort mot)
    {
        _mot = mot;
        return this;
    }

    public PorteBuilder ReliéeAuLecteur(Lecteur lecteur)
    {
        _lecteur = lecteur;
        return this;
    }
}