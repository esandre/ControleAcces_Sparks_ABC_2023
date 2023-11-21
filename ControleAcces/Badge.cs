namespace ControleAcces;

public class Badge
{
    public void Attribuer(Porteur porteur)
    {
        EstAttribué = true;
        porteur.AUnBadge = true;
    }

    internal bool EstAttribué { get; private set; }
}