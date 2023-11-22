namespace ControleAcces;

public class Porteur
{
    public string Désignation { get; }
}

public interface ISpécification<in TRéel>
{
    bool EstConforme(TRéel réel);
}

public class NomSansEspacesSpécification  : ISpécification<Porteur>
{
    /// <inheritdoc />
    public bool EstConforme(Porteur réel)
    {
        return !réel.Désignation.Contains(' ');
    }
}

public class Conforme<TRéel, TSpecification> 
    where TSpecification : ISpécification<TRéel>
{
    private readonly TRéel _réel;
    private readonly TSpecification _specification;

    public Conforme(TRéel réel, TSpecification specification)
    {
        _réel = réel;
        _specification = specification;
    }

    public TReturn MapIfConform<TReturn>(
        Func<TRéel, TReturn> mappingFunction, 
        TReturn ifNotConform)
        => _specification.EstConforme(_réel) 
            ? mappingFunction(_réel) 
            : ifNotConform;
}

public void DoSomething(Conforme<Porteur, NomSansEspacesSpécification> porteur)
{
    var identifiantPorteur = porteur.MapIfConform(p => p.Désignation, "Invalid");
}