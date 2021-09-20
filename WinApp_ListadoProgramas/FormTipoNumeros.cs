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
    public partial class FormTipoNumeros : Form
    {
        public FormTipoNumeros()
        {
            InitializeComponent();
        }

        private void FormTipoNumeros_Load(object sender, EventArgs e)
        {
            tbxnumero.Focus();
        }

        private void tbxnumero_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    int n = int.Parse(tbxnumero.Text);
                    if ((n > 0) && (n < 31))
                    {

                        btnPrimo.Enabled = true;
                        btnPerfecto.Enabled = true;
                        btnFactorion.Enabled = true;
                        btnFactorial.Enabled = true;
                        btnDivisores.Enabled = true;
                        btnCapicua.Enabled = true;

                        MessageBox.Show("Opciones desbloqueadss", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnPrimo.Focus();

                    }
                    else
                    {
                        MessageBox.Show("Dato fuera de rango, ingrese un número entre 1 y 30", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tbxnumero.Clear();
                    }

                }
                catch
                {
                    MessageBox.Show("El dato ingresado no corresponde a un número entero, Ingrese un número entero porfavor Ej: 5", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbxnumero.Clear();
                }
            }
        }

        int valor = 0;

        private void pbxlimpiar_Click(object sender, EventArgs e)
        {
            tbxnumero.Clear();
            lblres.Text = "";
            tbxnumero.Focus();
        }

        private void btnPrimo_Click(object sender, EventArgs e)
        {
            valor = int.Parse(tbxnumero.Text);
            Clcalculos obj1 = new Clcalculos(valor);
            lblres.Text = obj1.Mostrar_Primo(valor);
        }

        private void btnPerfecto_Click(object sender, EventArgs e)
        {
            valor = int.Parse(tbxnumero.Text);
            Clcalculos obj1 = new Clcalculos(valor);
            lblres.Text = obj1.Mostrar_perfecto(valor);
        }

        private void btnCapicua_Click(object sender, EventArgs e)
        {
            valor = int.Parse(tbxnumero.Text);
            Clcalculos obj1 = new Clcalculos(valor);
            lblres.Text = obj1.Mostrar_Capicua(valor);
        }

        private void btnDivisores_Click(object sender, EventArgs e)
        {
            valor = int.Parse(tbxnumero.Text);
            Clcalculos obj1 = new Clcalculos(valor);
            lblres.Text = obj1.calcular_divisores(valor).ToString();
        }

        private void btnFactorial_Click(object sender, EventArgs e)
        {
            valor = int.Parse(tbxnumero.Text);
            Clcalculos obj1 = new Clcalculos(valor);
            lblres.Text = obj1.calcular_factorial(valor).ToString();
        }

        private void btnFactorion_Click(object sender, EventArgs e)
        {
            valor = int.Parse(tbxnumero.Text);
            Clcalculos obj1 = new Clcalculos(valor);
            lblres.Text = obj1.Mostrar_Factorion(valor);
        }
    }
}
