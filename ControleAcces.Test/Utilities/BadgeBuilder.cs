using ControleAcces.Application;
using ControleAcces.Domaine;

namespace ControleAcces.Test.Utilities;

public class BadgeBuilder
{
    private int _numéroSérie;
    private readonly BadgeFactory _badgeFactory;
    private readonly BadgeRepository _badgeRepository;

    public BadgeBuilder(BadgeFactory badgeFactory, BadgeRepository badgeRepository)
    {
        _badgeFactory = badgeFactory;
        _badgeRepository = badgeRepository;
    }

    public BadgeBuilder AyantPourNuméroDeSérie(int numéro)
    {
        _numéroSérie = numéro;
        return this;
    }

    public Badge Build()
    {
        var badgeCréé = _badgeFactory.CréerPourLeNuméro(_numéroSérie);
        _badgeRepository.Sauvegarder(badgeCréé);
        return _badgeRepository.RécupérerLeNuméro(_numéroSérie);
    }
}