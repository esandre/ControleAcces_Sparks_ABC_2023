namespace ControleAcces.Test
{
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
            // ETANT DONNE un Badge
            var badge = new Badge();

            // ET un Porte reliée à un Lecteur
            var lecteur = new Lecteur();
            var porte = new Porte(lecteur);

            // QUAND ce Badge est détecté par ce Lecteur
            lecteur.Détecter(badge);

            // ALORS la Porte est ouverte
            Assert.True(porte.EstOuverte);
        }
    }
}