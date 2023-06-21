using System;
using System.Collections.Generic;
using System.Text;

namespace mohitmasahat
{
    class circle
    {
        
        
            private double shoa;
            private const double p = 3.14;

            public circle(double r)
            {
                shoa = r;
            }

            public double masahat()
            {
                return p * shoa * shoa;
            }

            public double mohit()
            {
                return 2 * p * shoa;
            }
        }
    }
}
