using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Concepeţi o clasă adecvată pentru implementarea grafurilor neorientate 5 reprezentate prin matrice de adiacenţă şi date prin numărul de noduri şi lista de muchii. Clasa va conţine metodele: 
a) constuctor/constructori de initializare
b) constructor de copiere 
d) returnarea numărului de noduri  
e) afisare lista adiacență pentru un nod dat 
f) determinare matricea lanțurilor 
g) operatorul – pentru eliminarea unui nod și returnarea subgrafului obținut 
h) operatorul ~ pentru determinare graf complementar 
i) metode  pentru citire /scriere
Programul va permite selectarea operațiilor prin intermediul unui meniu cu opţiunile corespunzătoare tuturor cerintelor, precum şi cu opţiunea Ieşire. 
*/


namespace Grafuri_Neorientate
{
    class Graf
    {
        int nrNoduri;
        int[,] muchii;

        public void Initializare()
        {
            for (int i = 1; i <= nrNoduri; i++)
                for (int j = 1; j <= nrNoduri; j++)
                    muchii[i, j] = 0;
        }

        //a) Constructor de initializare fara valori
        public Graf()
        {
            nrNoduri = 0;
            muchii = new int[0,0];
            Initializare();
        }

        //Constructor de initializare cu valori
        public Graf(int _nrNoduri, List<(int n1, int n2)> _muchii)
        {
            nrNoduri = _nrNoduri;
            muchii = new int[nrNoduri + 1, nrNoduri + 1];
            Initializare();
            _muchii.ForEach(muchie =>
            {
                muchii[muchie.n1, muchie.n2] = 1;
            });
        }

        //b) Constructor de copiere
        public Graf(Graf G)
        {
            nrNoduri = G.nrNoduri;
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
        //public string adiacenta(int nod)
        //{
         
        //}

        //public static Graf oprator -(Graf G, int nod){
            
        //}
    }
}
