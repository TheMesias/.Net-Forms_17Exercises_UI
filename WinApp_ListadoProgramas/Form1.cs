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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            showForm(new home()); 
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }


        //Mover Formulario 
        bool dat = false; 
        private void panel_Superior_MouseDown(object sender, MouseEventArgs e)
        {
            dat = true; 
        }

        private void panel_Superior_MouseMove(object sender, MouseEventArgs e)
        {
            if (dat == true) {
                this.Location = Cursor.Position;
            }
        }

        private void panel_Superior_MouseUp(object sender, MouseEventArgs e)
        {
            dat = false; 
        }


        //Panel Principal 
        private void showForm(object formShow)
        {
            if (this.panel_Contenedor.Controls.Count > 0)
            {
                this.panel_Contenedor.Controls.RemoveAt(0);
            }

            Form fh = formShow as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel_Contenedor.Controls.Add(fh);
            this.panel_Contenedor.Tag = fh;
            fh.Show();
        }

        private void btn_cantidadCifras_Click(object sender, EventArgs e)
        {
            showForm(new FormCantidad_Numeros()); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            showForm(new FormVolumen()); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            showForm(new FormHipotenusa());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            showForm(new FormCelsius());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            showForm(new FormCalculadora());
        }

        private void btn_Segundos_Click(object sender, EventArgs e)
        {
            showForm(new FormSegundos());
        }

        private void btn_cuadrante_Click(object sender, EventArgs e)
        {
            showForm(new FormCoordenadas()); 
        }

        private void btn_juego_Click(object sender, EventArgs e)
        {
            Juego.MATEMENTE FormJ = new Juego.MATEMENTE();
            FormJ.Show();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            showForm(new home());
        }

        private void btn_Tipo_Click(object sender, EventArgs e)
        {
            showForm(new FormTipoNumeros()); 
        }

        private void btn_Fibonacci_Click(object sender, EventArgs e)
        {
            showForm(new FormFibonacci());
        }

        private void btn_elevar_Click(object sender, EventArgs e)
        {
            showForm(new FormPotencia());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            showForm(new FormMayor()); 
        }

        private void btn_editorTexto_Click(object sender, EventArgs e)
        {
            WinAppEditorTexto.Form1 FormE = new WinAppEditorTexto.Form1();
            FormE.Show();
        }

        private void btn_Voz_Click(object sender, EventArgs e)
        {
            Winapp_TextoVoz.Form1 FormTextoV = new Winapp_TextoVoz.Form1();
            FormTextoV.Show(); 
        }

        private void btn_candidatos_Click(object sender, EventArgs e)
        {
            WinAppVotosPresi.Form1 Candidatos = new WinAppVotosPresi.Form1();
            showForm(new WinAppVotosPresi.Form1());
        }

        private void btn_candidatos_Click_1(object sender, EventArgs e)
        {
            WinAppVotosPresi.Form1 Candidatos = new WinAppVotosPresi.Form1();
            showForm(new WinAppVotosPresi.Form1());
        }

        private void btn_Tallas_Click(object sender, EventArgs e)
        {
            showForm(new WinAppConversionTallas.Form1()); 
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            WinAppCompraInteractiva.Form1 compra = new WinAppCompraInteractiva.Form1();
            compra.Show();

        }
    }
}
