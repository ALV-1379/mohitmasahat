using System;
using System.Collections.Generic;
using System.Text;

namespace mohitmasahat
{
    class triangle
    {
        private double ghaede;
        private double ertefa;

        public triangle(double h, double b)
        {
            ertefa = h;
            ghaede = b;
        }

        public double masahat()
        {
            return   (ertefa * ghaede) / 2;
        }

        public double mohit()
        {
            return ghaede + (2 * Math.Sqrt((ertefa * ertefa) + ((ghaede / 2) * (ghaede / 2))));
        }
    }
}
