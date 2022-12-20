using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Proiect_interviu
{
    internal class Ghiozdan
    {
        private ArticolInventar[] articole;
        
        public int NumarCurentArticole { get; internal set; }
        public double GreutateCurenta { get; internal set; }
        public double VolumCurent { get; internal set; }

        public int NumarMaximArticole { get; internal set; }
        public double GreutateMaxima { get; internal set; }
        public double VolumMaxim { get; internal set; }

        public Ghiozdan(int numarMaximArticole, double greutateMaxima, double volumMaxim)
        {
            articole = new ArticolInventar[numarMaximArticole];

            NumarMaximArticole = numarMaximArticole;
            GreutateMaxima = greutateMaxima;
            VolumMaxim = volumMaxim;

            NumarCurentArticole = 0;
            GreutateCurenta = 0;
            VolumCurent = 0;
        }

        public bool Adauga(ArticolInventar articol)
        {
            if(NumarCurentArticole + 1 == NumarMaximArticole)
            {
                return false;
            }

            if(GreutateCurenta + articol.Greutate > GreutateMaxima ||
                VolumCurent + articol.Volum > VolumMaxim)
            {
                return false;
            }

            articole[NumarCurentArticole++] = articol;
            VolumCurent += articol.Volum;
            GreutateCurenta += articol.Greutate;

            return true;
        }
    }
}
