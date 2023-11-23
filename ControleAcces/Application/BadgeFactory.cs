﻿using ControleAcces.Domaine;

namespace ControleAcces.Application;

/**
 * Complètement overkill vu la complexité de la création du badge, c'est pour l'exemple
 */
public class BadgeFactory
{
    public Badge CréerPourLeNuméro(int numéroSérie)
    {
        return new Badge(numéroSérie);
    }
}