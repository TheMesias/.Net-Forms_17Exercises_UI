using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinApp_ListadoProgramas
{
   

    public partial class FormCalculadora : Form
    {
        double val1 = 0 , val2 = 0;
        oper operador = oper.NF; 

        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void inputNum(string numero) {
            if(txt_resultado.Text == "0" && txt_resultado.Text != null)
            {
                txt_resultado.Text = numero;
            }
            else
            {
                txt_resultado.Text += numero;
            }

        }
        private void btn_cero_Click(object sender, EventArgs e)
        {
            if (txt_resultado.Text == "0") {
                return; 
            }
            else { 
                txt_resultado.Text += "0"; 
            }
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            inputNum("1"); 
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            inputNum("2");
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            inputNum("3");
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            inputNum("4");
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            inputNum("5");
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            inputNum("6");
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            inputNum("7");
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            inputNum("8");
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            inputNum("9");
        }

        private void btn_igual_Click(object sender, EventArgs e)
        {
            if (val2 == 0) {
                val2 = Convert.ToDouble(txt_resultado.Text);
                double resultado = Operacion();
                val1 = 0;
                val2 = 0;
                txt_resultado.Text = Convert.ToString(resultado); 
            }
        }

        private double Operacion() {
            double resultado = 0;

            switch (operador)
            {
                case oper.Suma:
                    resultado = val1 + val2; 
                    break;
                case oper.Resta:
                    resultado = val1 - val2;
                    break;
                case oper.Multiplicacion:
                    resultado = val1 * val2;
                    break;
                case oper.Division:
                    if (val2 == 0)
                    {
                        MessageBox.Show("Division incorrecta");
                    }
                    else {
                        resultado = val1 / val2; 
                    }
                    break;
                case oper.Modulo:
                    resultado = val1 % val2;
                    break;

                case oper.Seno:
                    resultado = Math.Sin(val1); 
                    break;

                case oper.Coseno:
                    resultado = Math.Cos(val1);
                    break;

                case oper.Exponencial:
                    resultado = Math.Exp(val1);
                    break;

                case oper.Potencia:
                    resultado = Math.Pow(val1, val2);
                    break;

                case oper.Tangente:
                    resultado = Math.Tan(val1);
                    break;

                case oper.Raiz:
                    resultado = Math.Sqrt(val1);
                    break; 



                
            }

            return resultado; 
        }

        private void btn_resta_Click(object sender, EventArgs e)
        {
            operador = oper.Resta;
            valor(); 
        }

        private void btn_suma_Click(object sender, EventArgs e)
        {
            operador = oper.Suma;
            valor();
            
        }

        private void btn_multiplicacion_Click(object sender, EventArgs e)
        {
            operador = oper.Multiplicacion;
            valor();
        }

        private void btn_division_Click(object sender, EventArgs e)
        {
            operador = oper.Division;
            valor();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            operador = oper.Modulo;
            valor();
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            if (txt_resultado.Text.Length > 1)
            {
                string txtRe = txt_resultado.Text;
                txtRe = txtRe.Substring(0, txtRe.Length - 1);
                if (txtRe.Length == 1 && txtRe.Contains("-"))
                {
                    txt_resultado.Text = "0";
                }
                else {
                    txt_resultado.Text = txtRe;
                }
            }
            else {
                txt_resultado.Text = "0"; 
            }
        }

        private void btn_c_Click(object sender, EventArgs e)
        {
            txt_resultado.Text = "0";
        }

        private void btn_punto_Click(object sender, EventArgs e)
        {
            if (txt_resultado.Text.Contains(","))
            {
                return;
            }
            
            txt_resultado.Text += ",";
            
        }

        private void btn_coseno_Click(object sender, EventArgs e)
        {
            operador = oper.Coseno;
            valor(); 
        }

        private void btn_raiz_Click(object sender, EventArgs e)
        {
            operador = oper.Raiz;
            valor(); 
        }

        private void btn_seno_Click(object sender, EventArgs e)
        {
            operador = oper.Seno;
            valor(); 
        }

        private void btn_exponencial_Click(object sender, EventArgs e)
        {
            operador = oper.Exponencial;
            valor(); 
        }

        private void btn_tan_Click(object sender, EventArgs e)
        {
            operador = oper.Tangente;
            valor(); 
        }

        private void btn_pow_Click(object sender, EventArgs e)
        {
            operador = oper.Potencia;
            valor(); 
        }

        private void valor() {
            val1 = Convert.ToDouble(txt_resultado.Text);
            txt_resultado.Text = "0";
        } 
    }

    public enum oper
    {
        NF = 0,
        Suma = 1,
        Resta = 2,
        Division = 3,
        Multiplicacion = 4,
        Modulo = 5,
        Seno = 6, 
        Coseno = 7, 
        Exponencial = 8, 
        Potencia = 9, 
        Tangente = 10, 
        Raiz = 11
    }
}
