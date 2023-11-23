namespace ControleAcces.Domaine;

public sealed class Badge : IEquatable<Badge>
{
    public int NuméroDeSérie { get; }

    internal Badge(int numéroDeSérie)
    {
        NuméroDeSérie = numéroDeSérie;
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
        return NuméroDeSérie == other.NuméroDeSérie;
    }

    /// <inheritdoc />
    public override bool Equals(object? obj) 
        => ReferenceEquals(this, obj) || obj is Badge other && Equals(other);

    /// <inheritdoc />
    public override int GetHashCode() => NuméroDeSérie;

    public static bool operator ==(Badge? left, Badge? right) => Equals(left, right);
    public static bool operator !=(Badge? left, Badge? right) => !Equals(left, right);
}