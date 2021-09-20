using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinApp_ListadoProgramas
{
    class Clcalculos
    {
        int numero;
        int divisores;
        int divisor;
        public Clcalculos(int num)
        {
            this.numero = num;
        }

        public int calcular_primo(int nump)
        {


            divisor = 1;
            divisores = 0;

            do
            {
                if (nump % divisor == 0)
                {
                    divisores++;
                }
                divisor++;
            } while (divisor <= nump);

            return divisores;
        }
        public string Mostrar_Primo(int nump)
        {
            string Res1 = (calcular_primo(nump) == 2 ? "Es un número primo  " : " No es un número primo ");
            return Res1;
        }

        public int calcular_perfecto(int numperfec)
        {
            int resto;
            resto = 0;

            for (int i = 1; i < numperfec; i++)
            {

                if (numperfec % i == 0) resto = resto + i;

            }
            return resto;
        }
        public string Mostrar_perfecto(int numperfec)
        {
            string Res2 = (calcular_perfecto(numperfec) == numperfec ? " El número ingresado es un número pefecto" : "El número ingresado NO es un número perfecto");
            return Res2;
        }
        public int calcular_factorial(int _fact)
        {
            int factorial;

            factorial = 1;

            for (int i = 1; i <= _fact; i++)
            {
                factorial = factorial * i;
            }
            return factorial;
        }

        public int calcular_factorion(int _facto)
        {
            int n;
            n = 0;

            if (_facto == 1)
            {
                n = _facto;
            }
            else if (_facto == 2)
            {
                n = _facto;
            }
            else if (_facto == 145)
            {
                n = _facto;
            }
            else if (_facto == 40585)
            {
                n = _facto;
            }

            return n;
        }
        public string Mostrar_Factorion(int _facto)
        {
            string Res3 = (calcular_factorion(_facto) == _facto ? "El número ingresado perteneces a uno de los número factoriones" : " El número ingresado NO pertenece a uno de los números factoriones ");
            return Res3;
        }
        public int calcular_capicua(int _capi)
        {
            int invertido;
            invertido = 0;

            while (_capi > 0)
            {
                invertido = invertido * 10 + (_capi % 10);
                _capi = _capi / 10;
            }
            return invertido;
        }
        public string Mostrar_Capicua(int _capi)
        {
            string Res4 = (calcular_capicua(_capi) == _capi ? $"El  número ingresado es un número capicua" : " El  número ingresado NO es un número capicua");
            return Res4;
        }
        public int calcular_divisores(int num)
        {
            divisor = 1;
            divisores = 0;

            do
            {
                if (num % divisor == 0)
                {
                    divisores++;
                }
                divisor++;
            } while (divisor <= num);

            return divisores;
        }
    }
}
