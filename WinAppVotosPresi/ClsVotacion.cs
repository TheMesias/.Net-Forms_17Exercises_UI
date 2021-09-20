using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppVotosPresi
{
    class ClsVotacion
    {
        int cont1, cont2, cont3;
        int[] vec = new int [50];
        public ClsVotacion(int partido1,int partido2, int partido3)
        {

            this.cont1 = partido1;
            this.cont2 = partido2;
            this.cont3 = partido3;
        }

        public int MayorVot()
        {
            int mayor;
            vec[0] = cont1;
            vec[1] = cont2;
            vec[2] = cont3;

            mayor = vec[0];

            for(int i = 0; i < 3; i++)
            {
                if (vec[i] > mayor)
                {
                    mayor = vec[i];
                }
            }

            return mayor;

        }
    }
}
