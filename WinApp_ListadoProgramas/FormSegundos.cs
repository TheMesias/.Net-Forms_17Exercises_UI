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
    public partial class FormSegundos : Form
    {
        int hora, minutos, segundos; 
        public FormSegundos()
        {
            InitializeComponent();
            txt_minutos.Enabled = false;
            txt_segundos.Enabled = false; 

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            clValidacion validacion = new clValidacion();
            validacion.SoloNumeros(e); 

            if (e.KeyChar == (char)Keys.Enter)
            {
                hora = int.Parse(textBox1.Text);

                if (hora >= 0 && hora <= 23)
                {
                    txt_minutos.Enabled = true;
                    txt_minutos.Focus();
                }
                else {
                    textBox1.Clear(); 
                    MessageBox.Show("Hora Incorrecta"); 
                }
            }
        }

        private void txt_minutos_KeyPress(object sender, KeyPressEventArgs e)
        {
            clValidacion validacion = new clValidacion();
            validacion.SoloNumeros(e);

            if (e.KeyChar == (char)Keys.Enter)
            {
                minutos = int.Parse(txt_minutos.Text);

                if (minutos >= 0 && minutos <= 59)
                {
                    txt_segundos.Enabled = true;
                    txt_segundos.Focus();
                }
                else
                {
                    txt_minutos.Clear(); 
                    MessageBox.Show("Minutos Incorrecto");
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            txt_minutos.Text = "";
            txt_segundos.Text = "";
            textBox1.Focus(); 
        }

        private void txt_segundos_KeyPress(object sender, KeyPressEventArgs e)
        {
            clValidacion validacion = new clValidacion();
            validacion.SoloNumeros(e);

            if (e.KeyChar == (char)Keys.Enter)
            {
                segundos = int.Parse(txt_segundos.Text);

                if (segundos >= 0 && segundos <= 59)
                {
                    calculo();
                    MessageBox.Show("Se ha calculado exitosamente");
                }
                else {
                    txt_segundos.Clear();
                    MessageBox.Show("Segundos Incorrectos");
                }
                
            }
        }

        private void calculo() {
            segundos++;
            if (segundos == 60)
            {
                segundos = 0;
                minutos++;
                if (minutos == 60)
                {
                    minutos = 0;
                    hora++;
                    if (hora == 24)
                        hora = 0;
                }
                lbl_hora.Text = hora.ToString();
                lbl_minutos.Text = minutos.ToString();
                lbl_segundos.Text = segundos.ToString();
            }
            else {
                lbl_hora.Text = hora.ToString();
                lbl_minutos.Text = minutos.ToString();
                lbl_segundos.Text = segundos.ToString();
            }
            
        }
    }
}
