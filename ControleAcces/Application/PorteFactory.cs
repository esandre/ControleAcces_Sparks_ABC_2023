using ControleAcces.Domaine;

namespace ControleAcces.Application;

public class PorteFactory
{
    private Lecteur _lecteur = new (0x0);
    private ushort _adresse;
    private IEnumerable<Func<IPorte, IPorte>> _décorateurs = Enumerable.Empty<Func<IPorte, IPorte>>();

    public PorteFactory LiéeAuLecteur(Lecteur lecteur)
    {
        _lecteur = lecteur;
        return this;
    }

    public PorteFactory AyantPourMot(ushort adresse)
    {
        _adresse = adresse;
        return this;
    }

    public PorteFactory Décorée(Func<IPorte, IPorte> decorateur)
    {
        _décorateurs = _décorateurs.Append(decorateur);
        return this;
    }

    public IPorte Build()
    {
        IPorte porte = new Porte(_adresse);
        porte = _décorateurs.Aggregate(porte, (current, décorateur) => décorateur(current));

        _lecteur.EnregistrerBadgeDétectéCallback(porte.DemanderOuverture);

        return porte;
    }
}