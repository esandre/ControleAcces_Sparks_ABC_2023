namespace ControleAcces;

public class Porte : IPorte
{
    public Porte(Lecteur lecteur)
    {
        lecteur.EntegistrerBadgeDétectéCallback(DemanderOuverture);
    }

    /// <inheritdoc />
    public virtual void DemanderOuverture()
    {

    }
}