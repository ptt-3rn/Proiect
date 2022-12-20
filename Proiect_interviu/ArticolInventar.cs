using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_interviu
{
    internal class ArticolInventar
    {
        public double Greutate { get; internal set; }
        public double Volum { get; internal set; }

        public ArticolInventar(double greutate, double volum)
        {
            Greutate = greutate;
            Volum = volum;
        }

    }
}
