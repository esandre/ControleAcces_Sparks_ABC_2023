using ControleAcces.Test.Utilities;

namespace ControleAcces.Test;

/**
    En tant qu'Administrateur
    Je veux consulter la liste générale des Portes
    Afin d'agir sur elles
 */
public class TestPlanAccès
{
    [Fact(DisplayName = "Un Plan d'Accès ayant une Porte permet de la retrouver")]
    public void PlanAccèsContientPorteTest()
    {
        // ETANT DONNE un Plan d'Accès ayant une Porte
        var porteUnique = new Porte(LecteurBuilder.Default);
        var fakeRepository = new FakePorteRepository() 
            { Portes = new []{ porteUnique }};

        var planAccès = new PlanAccès(fakeRepository);

        // QUAND on demande la Liste Générale des Portes
        var listeObtenue = planAccès.ListeGénéralePortes;

        // ALORS elle contient uniquement cette Porte
        Assert.Contains(porteUnique, listeObtenue);
    }
}