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
    public partial class FormVolumen : Form
    {
        double altura;
        double lado;
        public FormVolumen()
        {
            InitializeComponent();
            txt_altura.Visible = false; 
        }

        private void txt_lado_KeyPress(object sender, KeyPressEventArgs e)
        {
            clValidacion validacion = new clValidacion();
            validacion.SoloNumeros(e);

            if (e.KeyChar == (char)Keys.Enter)
            {
                try { 
                lado = double.Parse(txt_lado.Text);

                if (lado > 0)
                {
                    txt_altura.Visible = true;
                    txt_altura.Focus();
                }
                }
                catch {
                    MessageBox.Show("Ingrese numero valido"); 
                }
            }
        }

        private void txt_altura_KeyPress(object sender, KeyPressEventArgs e)
        {
            clValidacion validacion = new clValidacion();
            validacion.SoloNumeros(e);

            if (e.KeyChar == (char)Keys.Enter)
            {

                try { 
                    altura = double.Parse(txt_altura.Text);
                    clPiramide ObjP = new clPiramide();


                    lbl_respuesta.Text = ObjP.Volumen(altura, lado).ToString();
                }
                catch {
                    MessageBox.Show("Ingrese numero valido");
                }
            }
        }
    }
}
