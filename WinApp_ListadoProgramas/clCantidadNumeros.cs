using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinApp_ListadoProgramas
{
    class clCantidadNumeros
    {
        public double calculo(double input) {
            double result = Math.Floor((Math.Log(input) / Math.Log(10)) + 1);
            return result; 
        }
    }
}
