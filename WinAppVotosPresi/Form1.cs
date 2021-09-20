using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppVotosPresi
{
    public partial class Form1 : Form
    {
        int[] VecVotacion = new int[50];
        int numVota;
       
        int partidoSele;
        int partido1=0;
        int partido2=0;
        int partido3=0;
        int cont = 0;
        Random objRan = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void LblVota2_Click(object sender, EventArgs e)
        {
            

        }

        private void TxtBxNumVota_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if ((e.KeyChar) == (char)Keys.Enter)
                {
                    
                    numVota = int.Parse(TxtBxNumVota.Text);

                    if (numVota > 0 && numVota < 50)
                    {
                        TxtBxNumVota.Enabled = true;
                        TxtBxNumVota.Focus();
                        TxtBxNumVota.Enabled = false;
                        
                    }
                    else
                    {
                        MessageBox.Show("ingrese un numero comprendido ente 0 y 49", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TxtBxNumVota.Clear();
                    }
                }
            }
            catch
            {
                MessageBox.Show("ingrese un numero comprendido ente 0 y 49", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtBxNumVota.Clear();
            }
            
        }

        private void TxtBxVotar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar) == (char)Keys.Enter)
            {
                
            }
        }

        private void TxtBxNumVota_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtBxVotar_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnResultado_Click(object sender, EventArgs e)
        {
            try
            {
                int Sum = 0;
                do
                {
                    partido1 = objRan.Next(50);
                    partido2 = objRan.Next(50);
                    partido3 = objRan.Next(50);

                    Sum = partido1 + partido2 + partido3;

                } while (Sum == numVota);   
                              

                ClsVotacion ObjtotalVota = new ClsVotacion(partido1, partido2, partido3);

                int gana = ObjtotalVota.MayorVot();

                if (gana == partido1)
                {
                    LblNomGana.Text = "Joe Biden";
                    LblGanaCant.Text = gana.ToString();
                }
                else if (gana == partido2)
                {
                    LblNomGana.Text = "Donald Trump";
                    LblGanaCant.Text = gana.ToString();
                }
                else if (gana == partido3)
                {
                    LblNomGana.Text = "Barack Obama";
                    LblGanaCant.Text = gana.ToString();
                }

            }
            catch
            {
               
            }
        }
    }
}
