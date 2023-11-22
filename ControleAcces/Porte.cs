namespace ControleAcces;

public record Porte : IPorte
{
    private ushort _motSurAutomate;

    public Porte(ushort motSurAutomate, Lecteur lecteur)
    {
        lecteur.EnregistrerBadgeDétectéCallback(DemanderOuverture);
    }

    /// <inheritdoc />
    public virtual void DemanderOuverture()
    {

    }
}