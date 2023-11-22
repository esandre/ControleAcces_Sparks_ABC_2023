using ControleAcces.Test.Utilities;

namespace ControleAcces.Test;

/**
    En tant que Porteur
    Je veux ouvrir les Portes
    Afin d'Accéder au bâtiment
 */
public class OuvertureBatimentTest
{
    [Fact]
    public void TestOuverturePorte()
    {
        // ETANT DONNE un Badge attribué à un Porteur
        var badge = BadgeBuilder.Default;
        badge.Attribuer(new Porteur());

        // ET un Porte reliée à un Lecteur
        var lecteur = new Lecteur();
        var porte = new PorteSpy(lecteur);

        // QUAND ce Badge est détecté par ce Lecteur
        lecteur.Détecter(badge);

        // ALORS la Porte a reçu un signal d'ouverture
        Assert.True(porte.OuvertureDemandéeAuMoinsUneFois);
    }

    [Fact]
    public void TestEtatInitialPorte()
    {
        // ETANT DONNE une Porte reliée à un Lecteur
        var lecteur = new Lecteur();
        var porte = new PorteSpy(lecteur);

        // ALORS la Porte n'a pas reçu de signal
        Assert.False(porte.OuvertureDemandéeAuMoinsUneFois);
    }

    [Fact]
    public void TestBadgeNonAttribué()
    {
        // ETANT DONNE un Badge non-Attribué
        var badge = BadgeBuilder.Default;

        // ET un Porte reliée à un Lecteur
        var lecteur = new Lecteur();
        var porte = new PorteSpy(lecteur);

        // QUAND ce Badge est détecté par ce Lecteur
        lecteur.Détecter(badge);

        // ALORS la Porte n'a reçu aucun signal d'ouverture
        Assert.False(porte.OuvertureDemandéeAuMoinsUneFois);
    }
}