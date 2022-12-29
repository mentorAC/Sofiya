using System;
using System.Collections.Generic;
using System.Text;

namespace Les11
{
    internal class GRN
    {
        public int grivna;
        public GRN(int grivna)
        {
            this.grivna = grivna;

        }

        public static bool operator >(GRN grivna1, GRN grivna2)
        {
            return grivna1.grivna > grivna2.grivna;
        }
        public static bool operator <(GRN grivna1, GRN grivna2)
        {
            return grivna1.grivna < grivna2.grivna;
        }

    }
}
