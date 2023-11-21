using ControleAcces.Test.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleAcces.Test
{
    /*
     * 
     * 	En tant qu'Administrateur
	 *  Je veux créer un Porteur
	 *  Afin de lui attacher un Badge
     * 
     */
    public class CréationPorteurTest
    {
        [Fact]
        public void TestCréationPorteur()
        {
            // ETANT DONNE le Registre du Batiment 
            var leRegistre = new Registre();

            // QUAND un Porteur est créé
            var porteur = new Porteur();
            leRegistre.Ajouter(porteur);

            // ALORS ce Registre contient le Porteur
            Assert.Contains<Porteur>(porteur, leRegistre.Porteurs);
        }

        [Fact]
        public void TestEtatInitialPorteur()
        {
            // ETANT DONNE un nouveau Porteur
            var porteur = new Porteur();

            // ALORS ce Porteur n'a pas de Badge
            Assert.False(porteur.AUnBadge);
        }

        [Fact]
        public void TestAttributionBadge()
        {
            // ETANT DONNE un nouveau Porteur
            var porteur = new Porteur();

            // QUAND ce Porteur est attribué à un Badge
            var badge = new Badge();
            badge.Attribuer(porteur);

            // ALORS le Porteur a un Badge
            Assert.True(porteur.AUnBadge);
        }
    }
}
