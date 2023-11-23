using ControleAcces.Domaine;

namespace ControleAcces.Test.Utilities;

internal record PorteSpy : IPorte
{
    private readonly IPorte _spied;

    public PorteSpy(IPorte spied)
    {
        _spied = spied;
    }

    public bool OuvertureDemandéeAuMoinsUneFois { get; private set; }

    /// <inheritdoc />
    public void DemanderOuverture()
    {
        OuvertureDemandéeAuMoinsUneFois = true;
        _spied.DemanderOuverture();
    }
}