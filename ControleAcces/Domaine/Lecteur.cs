namespace ControleAcces.Domaine;

public class Lecteur : IEquatable<Lecteur>
{
    private readonly ushort _adresseSurLeBus;
    private Action _badgeDétectéCallback = () => { };

    public Lecteur(ushort adresseSurLeBus)
    {
        _adresseSurLeBus = adresseSurLeBus;
    }

    public void EnregistrerBadgeDétectéCallback(Action badgeDétecté)
    {
        _badgeDétectéCallback = badgeDétecté;
    }

    public void Détecter(Badge badge)
    {
        if (badge.EstAttribué)
            _badgeDétectéCallback();
    }

    /// <inheritdoc />
    public bool Equals(Lecteur? other)
    {
        if (ReferenceEquals(null, other)) return false;
        if (ReferenceEquals(this, other)) return true;
        return _adresseSurLeBus == other._adresseSurLeBus;
    }

    /// <inheritdoc />
    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != GetType()) return false;
        return Equals((Lecteur)obj);
    }

    /// <inheritdoc />
    public override int GetHashCode() => _adresseSurLeBus.GetHashCode();

    public static bool operator ==(Lecteur? left, Lecteur? right) => Equals(left, right);

    public static bool operator !=(Lecteur? left, Lecteur? right) => !Equals(left, right);
}