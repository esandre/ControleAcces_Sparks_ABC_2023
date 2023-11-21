namespace ControleAcces.Test.Utilities;

internal class PorteSpy : Porte
{
    public PorteSpy(Lecteur lecteur) : base(lecteur)
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