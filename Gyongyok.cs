using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfHelixToolkit
{
    internal class Gyongyok
    {
        int x, y, z, ertek;

        public Gyongyok(string sor)
        {
            string[] mezok = sor.Split(';');
            this.x = int.Parse(mezok[0]);
            this.y = int.Parse(mezok[1]);
            this.z = int.Parse(mezok[2]);
            this.ertek = int.Parse(mezok[3]);
        }

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public int Z { get => z; set => z = value; }
        public int Ertek { get => ertek; set => ertek = value; }
    }
}
