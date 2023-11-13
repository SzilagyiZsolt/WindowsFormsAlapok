using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAlapok
{
    internal class Orszag
    {
        string OrszagNev;
        double terulet;

        public Orszag(string line)
        {
            string[] sor=line.Split(';');
            OrszagNev1 = sor[0];
            Terulet=double.Parse(sor[1].Replace('.',','));
        }

        public string OrszagNev1 { get => OrszagNev; set => OrszagNev = value; }
        public double Terulet { get => terulet; set => terulet=value; }
        public override string ToString()
        {
            return OrszagNev;
        }
    }
}
