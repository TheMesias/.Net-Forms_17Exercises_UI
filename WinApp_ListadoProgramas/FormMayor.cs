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
    public partial class FormMayor : Form
    {
        int num1, num2, num3, num4; 
        public FormMayor()
        {
            InitializeComponent();
            txt_2.Enabled = false;
            txt_3.Enabled = false;
            txt_4.Enabled = false;
        }

        private void txt_1_KeyPress(object sender, KeyPressEventArgs e)
        {
            clValidacion validacion = new clValidacion();
            validacion.especifico(e);

            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    num1 = int.Parse(txt_1.Text);
                   
                    txt_2.Enabled = true;
                    txt_2.Focus(); 
                }
                catch
                {
                   
                    MessageBox.Show("Ingrese un numero valido");
                }
            }
        }

        private void FormMayor_Load(object sender, EventArgs e)
        {
            txt_1.Focus();
        }

        private void txt_2_KeyPress(object sender, KeyPressEventArgs e)
        {
            clValidacion validacion = new clValidacion();
            validacion.especifico(e);

            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    num2 = int.Parse(txt_2.Text);
                    txt_3.Enabled = true;
                    txt_3.Focus();
                }
                catch
                {

                    MessageBox.Show("Ingrese un numero valido");
                }
            }
        }

        private void txt_3_KeyPress(object sender, KeyPressEventArgs e)
        {
            clValidacion validacion = new clValidacion();
            validacion.especifico(e);

            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    num3 = int.Parse(txt_3.Text);
                    txt_4.Enabled = true;
                    txt_4.Focus();
                }
                catch
                {

                    MessageBox.Show("Ingrese un numero valido");
                }
            }
        }

        private void txt_4_KeyPress(object sender, KeyPressEventArgs e)
        {
            clValidacion validacion = new clValidacion();
            validacion.especifico(e);

            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    num4 = int.Parse(txt_4.Text);
                    clMayor mayor = new clMayor(num1, num2, num3, num4);
                    lbl_Respuesta.Text = mayor.mayor().ToString(); 
                }
                catch
                {

                    MessageBox.Show("Ingrese un numero valido");
                }
            }
        }
    }
}
