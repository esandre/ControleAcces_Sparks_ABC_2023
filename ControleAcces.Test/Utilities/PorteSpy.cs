namespace ControleAcces.Test.Utilities;

internal record PorteSpy : Porte
{
    public PorteSpy(ushort mot, Lecteur lecteur) : base(mot, lecteur)
    {
    }

    public bool OuvertureDemandéeAuMoinsUneFois { get; private set; }

    /// <inheritdoc />
    public override void DemanderOuverture()
    {
        OuvertureDemandéeAuMoinsUneFois = true;
        base.DemanderOuverture();
    }
}