namespace ControleAcces;

public class Porte : IPorte
{
    public Porte(Lecteur lecteur)
    {
        lecteur.EnregistrerBadgeDétectéCallback(DemanderOuverture);
    }

    /// <inheritdoc />
    public virtual void DemanderOuverture()
    {

    }
}