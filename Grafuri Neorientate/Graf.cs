using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafuri_Neorientate
{
    class Graf
    {
        int nrNoduri;
        List<List<int>> muchii;

        //a) Constructor de initializare fara valori
        public Graf()
        {
            nrNoduri = 0;
            muchii = new List<List<int>>();
        }

        //Constructor de initializare cu valori
        public Graf(int _nrNoduri, List<(int n1, int n2)> _muchii)
        {
            muchii = new List<List<int>>();
            this.nrNoduri = _nrNoduri;
            _muchii.ForEach(muchie =>
            {
                muchii[muchie.n1][muchie.n2] = 1;
            });
        }

        //b) Constructor de copiere
        public Graf(Graf G)
        {
            nrNoduri = G.nrNoduri;
            muchii = new List<List<int>>(G.muchii);
        }

        //d) returnarea numărului de noduri  
        public int NrNoduri {
            get
            {
                return nrNoduri;
            }
            set
            {
                nrNoduri = value;
            }
        }

        //e) afisare lista adiacență pentru un nod dat 
        public string adiacenta(int nod)
        {
            return muchii[nod].ToString();
        }
    }
}
