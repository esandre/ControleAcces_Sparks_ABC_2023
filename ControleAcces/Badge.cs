namespace ControleAcces;

public record Badge
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
    public virtual bool Equals(Badge? other) 
        => _numéroDeSérie.Equals(other?._numéroDeSérie);

    /// <inheritdoc />
    public override int GetHashCode() 
        => _numéroDeSérie;
}