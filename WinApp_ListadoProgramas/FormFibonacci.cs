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
    public partial class FormFibonacci : Form
    {
        int[] Arreglo = new int[9];
        int i = 0;
        public FormFibonacci()
        {
            InitializeComponent();
        }

        private void txtbxnum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar) == (char)Keys.Enter)
            {
                try
                {
                    int num = int.Parse(txtbxnum.Text);
                    //Arreglo[num] = int.Parse(txtbxnum.Text);
                    ClCalFibonacci objc1 = new ClCalFibonacci();


                    /*
                    if (i == 10)
                    {
                        MessageBox.Show("Datos Cargados");
                        
                    }
                    else
                    {

                    }*/



                    if ((num > 0) && (num < 11))
                    {
                        for (int k = 0; k < num; k++)
                        {
                            Arreglo[k] = objc1.SerieF(k);
                        }
                        for (int j = 0; j < num; j++)
                        {
                            lboxelementos.Items.Add(Arreglo[j]);
                        }
                        txtbxnum.Enabled = false;
                    }
                    else
                        MessageBox.Show("Dato ingresado fuera de rango, digite un número del 1 al 10", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtbxnum.Clear();
                }
                catch
                {
                    MessageBox.Show("Dato ingresado no corresponde a un número entero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtbxnum.Clear();
                }
            }
        }

        private void pbxlimpiar_Click(object sender, EventArgs e)
        {
            txtbxnum.Enabled = true;
            txtbxnum.Clear();
            txtbxnum.Focus();

            lboxelementos.Items.Clear();
        }
    }
}
