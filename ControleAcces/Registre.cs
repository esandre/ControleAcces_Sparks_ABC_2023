using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleAcces;

public class Registre
{
    private List<Porteur> porteurs = new List<Porteur>();

    public IEnumerable<Porteur> Porteurs => porteurs;

    public void Ajouter(Porteur porteur)
    {
        this.porteurs.Add(porteur);
    }
}
