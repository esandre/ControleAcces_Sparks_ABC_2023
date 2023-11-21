namespace ControleAcces;

public class Porte
{
    private readonly Lecteur _lecteur;

    public Porte(Lecteur lecteur)
    {
        _lecteur = lecteur;
    }

    public bool EstOuverte => _lecteur.ADétectéUnBadge;
}