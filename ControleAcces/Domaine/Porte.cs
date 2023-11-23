namespace ControleAcces.Domaine;

public record Porte : IPorte
{
    public ushort MotSurAutomate { get; }

    internal Porte(ushort motSurAutomate)
    {
        MotSurAutomate = motSurAutomate;
    }

    /// <inheritdoc />
    public virtual void DemanderOuverture()
    {

    }
}