﻿using ControleAcces.Application;
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
        return BadgeFactory.CréerPourLeNuméro(_numéroSérie);
    }
}