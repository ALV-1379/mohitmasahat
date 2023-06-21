using System;
using System.Collections.Generic;
using System.Text;

namespace mohitmasahat
{
    class beyzi
    {
        private double shoa1;
        private double shoa2;
        private double p = 3.14;

        public beyzi(double ghotr1, double ghotr2)
        {
            shoa1 = ghotr1;
            shoa2 = ghotr2;
        }

        public double masahat()
        {
            return p * shoa1 * shoa2;
        }

        public double mohit()
        {
            return 2 * p * Math.Sqrt((shoa1 * shoa1 + shoa2 * shoa2) / 2);
        }
    }
}
