using ControleAcces.Test.Utilities;

namespace ControleAcces.Test;

public class EntitésTest(FunctionalTestFixture fixture) : IFunctionalTest, IClassFixture<FunctionalTestFixture>
{
    [Fact]
    public void LesBadgesSontDesEntités()
    {
        // ETANT DONNE deux instances de Badge ayant le même numéro
        const int numéroCommun = 303;
        var badgeBuilder = BadgeBuilder
            .AyantPourNuméroDeSérie(numéroCommun);

        var badgeA = badgeBuilder.Build();
        var badgeB = badgeBuilder.Build();

        // QUAND on les compare
        var aEgalB = badgeA == badgeB;
        var bEgalA = badgeB == badgeA;

        // ALORS ils sont le même badge
        Assert.True(aEgalB);
        Assert.True(bEgalA);
    }

    [Fact]
    public void LesLecteursSontDesEntités()
    {
        // ETANT DONNE deux lecteurs d'adresses identiques
        var lecteurA = new LecteurBuilder().AyantUneAdresseSpécifique(0x12).Build();
        var lecteurB = new LecteurBuilder().AyantUneAdresseSpécifique(0x12).Build();

        // QUAND on les compare
        var aEgalB = lecteurA == lecteurB;
        var bEgalA = lecteurB == lecteurA;

        // ALORS ils sont deux lecteurs identiques
        Assert.True(aEgalB);
        Assert.True(bEgalA);
    }

    [Fact]
    public void LesLecteursSontDesEntitésMêmeReliées()
    {
        // TODO : Le Lecteur est un candidat pour être une entité, a refacto dès que possible

        // ETANT DONNE deux lecteurs d'adresses identiques, l'un relié
        var lecteurA = new LecteurBuilder()
            .AyantUneAdresseSpécifique(0x12)
            .Build();

        var lecteurB = new LecteurBuilder()
            .AyantUneAdresseSpécifique(0x12)
            .Build();

        lecteurB.EnregistrerBadgeDétectéCallback(() => {});

        // QUAND on les compare
        var aEgalB = lecteurA == lecteurB;
        var bEgalA = lecteurB == lecteurA;

        // ALORS ils sont deux lecteurs identiques
        Assert.True(aEgalB);
        Assert.True(bEgalA);
    }

    /// <inheritdoc />
    public BadgeBuilder BadgeBuilder => fixture.BadgeBuilder;
}