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
            muchii.Add((2, 0));
            muchii.Add((1, 0));
            Graf g = new Graf(3, muchii);
            Console.WriteLine(g.NrNoduri);
        }
    }
}
