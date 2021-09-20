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
    public partial class FormCoordenadas : Form
    {
        double x, y; 
        public FormCoordenadas()
        {
            InitializeComponent();
            txt_y.Enabled = false; 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_x_KeyPress(object sender, KeyPressEventArgs e)
        {
            clValidacion validacion = new clValidacion();
            validacion.especifico(e);

            if (e.KeyChar == (char)Keys.Enter)
            {
                try {
                    x = double.Parse(txt_x.Text);
                    txt_y.Enabled = true;
                    txt_y.Focus(); 

                } catch {
                    txt_x.Clear(); 
                    MessageBox.Show("Ingrese un numero valido"); 
                }
            } 
        }

        private void txt_y_KeyPress(object sender, KeyPressEventArgs e)
        {
            clValidacion validacion = new clValidacion();
            validacion.especifico(e);

            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    y = double.Parse(txt_y.Text);
                    calculo(); 

                }
                catch
                {
                    txt_y.Clear();
                    MessageBox.Show("Ingrese un numero valido");
                }
            }
        }

        private void calculo() {
            lbl_Cuadrante.Text = calcularCuadrante(x, y);
            lbl_Distancia.Text = calcularDistancia(x, y).ToString(); 
            
        }

        string calcularCuadrante(double x, double y)
        {
            if (x > 0 && y > 0)
            {
                return "uno";
            }
            else if (x < 0 && y > 0)
            {
                return "dos";
            }
            else if (x < 0 && y < 0)
            {
                return "tres";
            }
            else if (x > 0 && y < 0)
            {
                return "cuatro";
            }
            else if (x == 0 && y == 0)
            {
                return "origen";
            }
            else
            {
                return "eje";
            }
        }

        double calcularDistancia(double x, double y)
        {
            return Math.Sqrt(Math.Pow(x, 2)) + Math.Sqrt(Math.Pow(y, 2));
        }

    }
}
