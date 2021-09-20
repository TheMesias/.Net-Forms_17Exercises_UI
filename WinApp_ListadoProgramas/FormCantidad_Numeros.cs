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
    public partial class FormCantidad_Numeros : Form
    {
        public FormCantidad_Numeros()
        {
            InitializeComponent();
        }

        private void txt_Entrada_KeyPress(object sender, KeyPressEventArgs e)
        {
            clValidacion validar = new clValidacion();

            validar.SoloNumeros(e);

            if (e.KeyChar == (char)Keys.Enter)
            {
                try { 
                    double input = double.Parse(txt_Entrada.Text);
                    clCantidadNumeros numeros = new clCantidadNumeros(); 
                    double resultado = numeros.calculo(input);
                    lbl_respuesta.Text = resultado.ToString();
                }
                catch {
                    MessageBox.Show("Escriba un numero valido"); 
                }
            }
        }
    }
}
