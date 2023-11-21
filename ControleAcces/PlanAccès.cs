using ControleAcces.Port;

namespace ControleAcces;

public class PlanAccès
{
    public PlanAccès(IPorteRepository porteRepository)
    {
        ListeGénéralePortes = porteRepository.Portes;
    }

    public IEnumerable<Porte> ListeGénéralePortes { get; }
}