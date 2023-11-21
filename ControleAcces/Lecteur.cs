namespace ControleAcces;

public class Lecteur
{
    private Action _badgeDétectéCallback = () => { };

    internal void EntegistrerBadgeDétectéCallback(Action badgeDétecté)
    {
        _badgeDétectéCallback = badgeDétecté;
    }

    public void Détecter(Badge badge)
    {
        if(badge.EstAttribué)
            _badgeDétectéCallback();
    }
}