using ControleAcces.Application;
using ControleAcces.Domaine;

namespace ControleAcces.Test.Utilities;

internal class BadgeBuilder
{
    private int _numéroSérie;

    public static Badge Default => new BadgeBuilder().Build();

    public BadgeBuilder AyantPourNuméroDeSérie(int numéro)
    {
        _numéroSérie = numéro;
        return this;
    }

    public Badge Build()
    {
        var badgeCréé = BadgeFactory.CréerPourLeNuméro(_numéroSérie);
        BadgeRepository.Sauvegarder(badgeCréé);

        return BadgeRepository.RécupérerLeNuméro(_numéroSérie);
    }
}