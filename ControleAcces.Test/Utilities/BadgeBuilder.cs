namespace ControleAcces.Test.Utilities;

internal class BadgeBuilder
{
    private int _numéroSérie = 0;

    public static Badge Default => new BadgeBuilder().Build();

    public BadgeBuilder AyantPourNuméroDeSérie(int numéro)
    {
        _numéroSérie = numéro;
        return this;
    }

    public Badge Build()
    {
        return new Badge(_numéroSérie);
    }
}