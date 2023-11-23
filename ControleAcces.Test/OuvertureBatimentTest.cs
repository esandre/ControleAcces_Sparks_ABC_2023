using ControleAcces.Domaine;
using ControleAcces.Test.Utilities;

namespace ControleAcces.Test;

/**
    En tant que Porteur
    Je veux ouvrir les Portes
    Afin d'Accéder au bâtiment
 */
public class OuvertureBatimentTest(FunctionalTestFixture fixture) : IFunctionalTest, IClassFixture<FunctionalTestFixture>
{
    [Fact]
    public void TestOuverturePorte()
    {
        // ETANT DONNE un Badge attribué à un Porteur
        var badge = BadgeBuilder.Build();
        badge.Attribuer(new Porteur());

        // ET un Porte reliée à un Lecteur
        var lecteur = LecteurBuilder.Default;
        var porte = new PorteBuilder().LiéeAuLecteur(lecteur).Build();

        // QUAND ce Badge est détecté par ce Lecteur
        lecteur.Détecter(badge);

        // ALORS la Porte a reçu un signal d'ouverture
        Assert.True(porte.OuvertureDemandéeAuMoinsUneFois);
    }

    [Fact]
    public void TestEtatInitialPorte()
    {
        // ETANT DONNE une Porte reliée à un Lecteur
        var lecteur = LecteurBuilder.Default;
        var porte = new PorteBuilder().LiéeAuLecteur(lecteur).Build();

        // ALORS la Porte n'a pas reçu de signal
        Assert.False(porte.OuvertureDemandéeAuMoinsUneFois);
    }

    [Fact]
    public void TestBadgeNonAttribué()
    {
        // ETANT DONNE un Badge non-Attribué
        var badge = BadgeBuilder.Build();

        // ET un Porte reliée à un Lecteur
        var lecteur = LecteurBuilder.Default;
        var porte = PorteBuilder.Default;

        // QUAND ce Badge est détecté par ce Lecteur
        lecteur.Détecter(badge);

        // ALORS la Porte n'a reçu aucun signal d'ouverture
        Assert.False(porte.OuvertureDemandéeAuMoinsUneFois);
    }

    /// <inheritdoc />
    public BadgeBuilder BadgeBuilder => fixture.BadgeBuilder;
}