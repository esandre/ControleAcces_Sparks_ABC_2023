namespace ControleAcces;

public class Lecteur
{
    internal bool ADétectéUnBadge { get; private set; }

    public void Détecter(Badge badge)
    {
        ADétectéUnBadge = true;
    }
}