using System;
using System.Collections.Generic;
using System.Text;

namespace mohitmasahat
{
    class nzeli
    {
        private int zel;
        private double tol;

        public nzeli(int y, double l)
        {
            zel = y;
            tol = l;
        }

        public double masahat()
        {
            return (zel * tol * tol) / (4 * Math.Tan(Math.PI / zel));
        }

        public double mohit()
        {
            return zel * tol;
        }
    }
}
