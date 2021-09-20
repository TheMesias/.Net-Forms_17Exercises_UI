using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinApp_ListadoProgramas
{
    class ClSS
    {
        private int ba, exp;
        private double res;

        public ClSS(int x, int y, double r)
        {
            this.ba = x;
            this.exp = y;
            this.res = r;
        }
        public double SumaS()
        {
            res = 1;
            if (exp == 0)
            {
                return 1;
            }
            else if (exp > 0)
            {
                for (int i = 1; i <= exp; i++)
                {
                    res = res * ba;
                }
                return res;
            }
            else
            {
                for (int j = 1; j <= -exp; j++)
                {
                    res = res * ba;
                }
                res = (1 / res);
                return res; ;
            }

        }
    }
}
