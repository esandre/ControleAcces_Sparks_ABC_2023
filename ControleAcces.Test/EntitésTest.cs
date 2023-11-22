using ControleAcces.Test.Utilities;

namespace ControleAcces.Test;

public class EntitésTest
{
    [Fact]
    public void LesBadgesSontDesEntités()
    {
        // ETANT DONNE deux instances de Badge ayant le même numéro
        const int numéroCommun = 303;
        var badgeBuilder = new BadgeBuilder()
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
}