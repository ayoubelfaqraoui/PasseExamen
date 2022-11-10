using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasseExamen
{
    internal class Etudiant
    {
        string cne;
        string nom;
        string prenom;
        public Etudiant(string cne, string nom, string prenom)
        {
            this.cne = cne;
            this.nom = nom;
            this.prenom = prenom;
        }
    }
}
