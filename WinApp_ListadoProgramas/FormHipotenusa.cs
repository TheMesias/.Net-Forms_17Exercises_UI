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
    public partial class FormHipotenusa : Form
    {
        double inputA;
        double inputB;
        public FormHipotenusa()
        {
            InitializeComponent();
            txt_catetoB.Visible = false;
        }

        private void txt_catetoA_KeyPress(object sender, KeyPressEventArgs e)
        {
            clValidacion validacion = new clValidacion();
            validacion.SoloNumeros(e);

            if (e.KeyChar == (char)Keys.Enter)
            {
                try { 
                    inputA = double.Parse(txt_catetoA.Text);
                    if (inputA > 0)
                    {
                        txt_catetoB.Visible = true;
                        txt_catetoB.Focus();
                    }
                }
                catch {
                    MessageBox.Show("Ingrese numero valido"); 
                }

            }
        }

        private void txt_catetoB_KeyPress(object sender, KeyPressEventArgs e)
        {
            clValidacion validacion = new clValidacion();
            validacion.SoloNumeros(e);

            if (e.KeyChar == (char)Keys.Enter)
            {
                try { 
                    inputB = double.Parse(txt_catetoB.Text);

                    clHipotenusa objCateto = new clHipotenusa();
                    double result = objCateto.Hipotenusa(inputA, inputB);

                    lbl_respuesta.Text = result.ToString();
                }
                catch {
                    MessageBox.Show("Ingrese numero valido");  
                }

            }
        }
    }
}
