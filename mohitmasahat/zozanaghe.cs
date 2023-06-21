using System;
using System.Collections.Generic;
using System.Text;

namespace mohitmasahat
{
    class zozanaghe
    {
        private double ertfa;
        private double y;
        private double x;
        private double zel1;
        private double zel2;

        public zozanaghe(double ertefa, double zelb, double zelp, double zelr, double zelc)
        {
            ertfa = ertefa;
            y = zelb;
            x = zelp;
            zel1 = zelr;
            zel2 = zelc;
        }

        public double masahat()
        {
            return (ertfa * (y + x))/2;
        }

        public double mohit()
        {
            return x + y + zel1 + zel2;
        }
    }
}
}
