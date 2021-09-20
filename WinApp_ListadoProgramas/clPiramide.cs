using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinApp_ListadoProgramas
{
    class clPiramide
    {
        public double Volumen(double altura, double lado)
        {
            double vol;
            lado *= lado;

            vol = (altura * lado)/3;

            return vol;
        }
    }
}
