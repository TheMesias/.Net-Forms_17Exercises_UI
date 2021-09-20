using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinApp_ListadoProgramas
{
    class clHipotenusa
    {
        public double Hipotenusa(double a, double b)
        {
            double resultado = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            return resultado;
        }
    }
}
