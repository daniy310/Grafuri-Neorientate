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
            muchii = new int[0, 0];
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
                muchii[muchie.n2, muchie.n1] = 1;
            });
        }

        //b) Constructor de copiere
        public Graf(Graf G)
        {
            nrNoduri = G.nrNoduri;
            muchii = new int[nrNoduri + 1, nrNoduri + 1];
            for (int i = 1; i <= nrNoduri; i++)
                for (int j = 1; j <= nrNoduri; j++)
                    muchii[i, j] = G.muchii[i, j];
        }

        //d) returnarea numărului de noduri  
        public int NrNoduri
        {
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
            string s = "";
            for (int i = 1; i <= nrNoduri; i++)
                if (muchii[nod, i] == 1)
                    s += i.ToString() + " ";
            return s;
        }

        //f) determinare matricea lanțurilor
        public Graf matriceaLanturilor(Graf G)
        {
            Graf aux = new Graf(G);
            for (int k = 1; k < G.nrNoduri; k++)
                for (int i = 1; i <= G.nrNoduri; i++)
                    for (int j = 1; j <= G.nrNoduri; j++)
                        if (i != j)
                            if (aux.muchii[i, j] == 0)
                                aux.muchii[i, j] = aux.muchii[i, k] * aux.muchii[k, j];

            return aux;
        }

        //g) operatorul – pentru eliminarea unui nod și returnarea subgrafului obținut
        public static Graf operator -(Graf Gf, int nod)
        {
            Graf G = new Graf(Gf);
            for (int i = 1; i <= G.nrNoduri; i++){
                G.muchii[i, nod] = 0;
                G.muchii[nod, i] = 0;
            }

            //pentru fiecare rand de sub nod ridicam elementele o pozitie
            for (int i = nod + 1; i <= G.nrNoduri; i++)
                for (int j = 1; j <= G.nrNoduri; j++)
                    G.muchii[i - 1, j] = G.muchii[i, j];

            //pentru fiecare coloana din dreapta nodului mutam elementele cu o pozitie in stanga
            for (int j = nod + 1; j <= G.nrNoduri; j++)
                for (int i = 1; i <= G.nrNoduri; i++)
                    G.muchii[i, j - 1] = G.muchii[i, j];

            G.nrNoduri--;
            return G;
        }

        //h) operatorul ~ pentru determinare graf complementar
        public static Graf operator ~(Graf Gf)
        {
            Graf G = new Graf(Gf);
            for (int i = 1; i <= G.nrNoduri; i++)
                for (int j = 1; j <= G.nrNoduri; j++)
                    if (G.muchii[i, j] == 0)
                        G.muchii[i, j] = 1;
                    else
                        G.muchii[i, j] = 0;
            return G;
        }

        //i) metode  pentru citire / scriere
        public string afisare()
        {
            string s = "";
            for (int i = 1; i <= nrNoduri; i++)
            {
                for (int j = 1; j <= nrNoduri; j++)
                    s += muchii[i, j].ToString() + " ";
                s += '\n';
            }
            return s;
        }
    }
}
