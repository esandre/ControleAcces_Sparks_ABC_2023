namespace ControleAcces;

public sealed class Badge : IEquatable<Badge>
{
    private readonly int _numéroDeSérie;

    public Badge(int numéroDeSérie)
    {
        _numéroDeSérie = numéroDeSérie;
    }

    public void Attribuer(Porteur porteur)
    {
        EstAttribué = true;
    }

    internal bool EstAttribué { get; private set; }

    /// <inheritdoc />
    public bool Equals(Badge? other)
    {
        if (ReferenceEquals(null, other)) return false;
        if (ReferenceEquals(this, other)) return true;
        return _numéroDeSérie == other._numéroDeSérie;
    }

    /// <inheritdoc />
    public override bool Equals(object? obj) 
        => ReferenceEquals(this, obj) || obj is Badge other && Equals(other);

    /// <inheritdoc />
    public override int GetHashCode() => _numéroDeSérie;

    public static bool operator ==(Badge? left, Badge? right) => Equals(left, right);
    public static bool operator !=(Badge? left, Badge? right) => !Equals(left, right);
}