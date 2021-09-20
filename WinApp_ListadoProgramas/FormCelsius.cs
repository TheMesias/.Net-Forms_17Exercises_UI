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
    public partial class FormCelsius : Form
    {
        public FormCelsius()
        {
            InitializeComponent();
        }

        private void txt_grados_KeyPress(object sender, KeyPressEventArgs e)
        {
            clValidacion validacion = new clValidacion();
            validacion.SoloNumeros(e);

            if (e.KeyChar == (char)Keys.Enter)
            {
                double grados = double.Parse(txt_grados.Text);

                double result = (grados - 32) * 5 / 9;

                lbl_respuesta.Text = result.ToString();

            }
        }
    }
}
