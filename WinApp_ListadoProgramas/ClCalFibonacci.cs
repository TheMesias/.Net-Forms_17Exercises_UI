using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinApp_ListadoProgramas
{
    class ClCalFibonacci
    {
        private int num;

        public ClCalFibonacci()
        {

        }
        public int SerieF(int num)
        {
            if ((num == 1) || (num == 0))
            {
                return num;
            }
            else
                return SerieF(num - 1) + SerieF(num - 2);

        }
    }
}
