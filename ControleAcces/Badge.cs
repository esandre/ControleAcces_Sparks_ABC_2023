namespace ControleAcces;

public class Badge
{
    public void Attribuer(Porteur porteur)
    {
        EstAttribué = true;
    }

    internal bool EstAttribué { get; private set; }
}