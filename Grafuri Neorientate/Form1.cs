using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grafuri_Neorientate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<(int a, int b)> muchii = new List<(int a, int b)>();
            muchii.Add((1, 2));
            muchii.Add((2, 5));
            muchii.Add((1, 3));
            muchii.Add((4, 3));
            muchii.Add((1, 4));
            Graf g = new Graf(5, muchii);
            Console.WriteLine("Afisare numar noduri");
            Console.WriteLine(g.NrNoduri);

            Console.WriteLine("Afisare adiacenta nodului 1");
            Console.WriteLine(g.adiacenta(1));

            Console.WriteLine("Afisare matricea de adiacenta a grafului");
            Console.WriteLine(g.afisare());

            Graf lanturi = g.matriceaLanturilor(g);
            Console.WriteLine("Afisare matricea lanturilor");
            Console.WriteLine(lanturi.afisare());

            Graf h = new Graf(g - 3);
            Console.WriteLine("Afisare graf fara nodul 3");
            Console.WriteLine(h.afisare());

            Graf i = new Graf (~g);
            Console.WriteLine("Afisare graf complementar");
            Console.WriteLine(i.afisare());
        }
    }
}
