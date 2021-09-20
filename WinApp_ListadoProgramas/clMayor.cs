using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinApp_ListadoProgramas
{
    class clMayor
    {
        int num1, num2, num3, num4;
        public clMayor(int num1, int num2, int num3, int num4) {
            this.num1 = num1;
            this.num2 = num2;
            this.num3 = num3;
            this.num4 = num4; 
        }


        public int mayor() {
            if ((num1 > num2) && (num1 > num3) && (num1 > num4))
            {
                return num1;
            }
            else if ((num2 > num1) && (num2 > num3) && (num2 > num4)) {
                return num2;
            } else if ((num3 > num1) && (num3 > num2) && (num3 > num4)) {
                return num3;
            }
            else{
                return num4; 
            }
        }
    }
}
