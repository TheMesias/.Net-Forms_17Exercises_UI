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
    public partial class FormPotencia : Form
    {
        int exp, b;
        double respuesta = 1;
        public FormPotencia()
        {
            InitializeComponent();
        }

        private void pbxlimpiar_Click(object sender, EventArgs e)
        {
            txtboxbase.Clear();
            txtboxexponente.Clear();
            txtboxexponente.Enabled = false;
            Elementos.Items.Clear();
            txtboxbase.Focus();
        }

        private void txtboxbase_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    b = int.Parse(txtboxbase.Text);

                    if ((b > 0) && (b < 11))
                    {
                        txtboxexponente.Enabled = true;
                        txtboxexponente.Focus();

                    }
                    else
                    {
                        MessageBox.Show("Dato fuera de rango, ingrese un número entre 1 y 10", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtboxbase.Clear();
                    }
                }
                catch
                {
                    MessageBox.Show("Dato ingresado no corresponde a un número entero, Ej: 5 es un número entero", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtboxbase.Clear();
                }
            }
        }

        private void txtboxexponente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    exp = int.Parse(txtboxexponente.Text);

                    if ((exp > -11) && (exp < 11))
                    {
                        ClSS objc1 = new ClSS(b, exp, respuesta);
                        Elementos.Items.Add(objc1.SumaS());


                    }
                    else
                    {
                        MessageBox.Show("Dato fuera de rango, ingrese un número entre -10 y 10", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtboxexponente.Clear();
                    }
                }
                catch
                {
                    MessageBox.Show("Dato ingresado no corresponde a un número entero, Ej: 5 es un número entero", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtboxexponente.Clear();
                }
            }
        }
    }
}
