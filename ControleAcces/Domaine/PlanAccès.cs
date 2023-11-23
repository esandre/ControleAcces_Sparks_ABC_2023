using ControleAcces.Port;

namespace ControleAcces.Domaine;

public class PlanAccès
{
    public PlanAccès(IPorteRepository porteRepository)
    {
        ListeGénéralePortes = porteRepository.Portes;
    }

    public IEnumerable<IPorte> ListeGénéralePortes { get; }
}