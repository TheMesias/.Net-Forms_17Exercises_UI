using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Text;

namespace WinAppEditorTexto
{

   
    public partial class Form1 : Form
    {
        string archivo;
        public Form1()
        {
            InitializeComponent();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFile = new OpenFileDialog();
            OpenFile.Filter = "Texto|*.txt";  //permite filtar solo los archivos de texto
            if (OpenFile.ShowDialog() == DialogResult.OK)
            {
                archivo = OpenFile.FileName;

                using(StreamReader sr = new StreamReader(archivo)) //abre un archivo y guarda su direccion
                {
                    
                    richTextBox1.Text = sr.ReadToEnd();
                    MessageBox.Show("El archivo fue abierto con exito", "Abrir", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                Form1.ActiveForm.Text = archivo + " |NOTEr";
               
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog SaveFile = new SaveFileDialog();
            SaveFile.Filter = "Texto|*.txt"; //permite filtar solo los archivos de texto

            if (archivo != null) //si la variable tiene algo
            {
                using(StreamWriter sw = new StreamWriter(archivo)) //guarda un archivo que esta abierto
                {
                    sw.WriteLine(richTextBox1.Text);
                    MessageBox.Show("El archivo fue guardado con exito", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                if (SaveFile.ShowDialog() == DialogResult.OK) //
                {
                    archivo = SaveFile.FileName;

                    using (StreamWriter sw = new StreamWriter(SaveFile.FileName)) // si el archivo es nuevo guarda con el nombre que le pongamos
                    {
                        sw.Write(richTextBox1.Text);
                        MessageBox.Show("El archivo fue guardado con exito", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    } 
                }
            }
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear(); //vacia el richTextBox
            archivo = null;
            Form1.ActiveForm.Text = archivo + "NOTEr";
            MessageBox.Show("Nuevo Archivo", "Nuevo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void adelanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
            
        }

        private void MenStriAtras_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void MenStriCortar_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void MenStriPegar_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void MenStriSeleccionaTodo_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void MenStripEliminarTodo_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void MenuColor_Click(object sender, EventArgs e)
        {
           
        }

        private void MenuFormato_Click(object sender, EventArgs e)
        {
            var frmt = fontDialog1.ShowDialog();
            if (frmt == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog1.Font;
               
            }
        }

        private void Seleccionar_tamanio(object sender, EventArgs e)
        {
            if(richTextBox1.SelectedText != "")
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.Font.SystemFontName, float.Parse(ComboBox1.SelectedItem.ToString()), richTextBox1.Font.Style);
                {

                }
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(richTextBox1.Font,FontStyle.Italic);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            
            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold);
        }

        private void toolStripButton1_DoubleClick(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Regular);
        }

        private void BtnAliIzq_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void BtnAlinCent_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }
        
        private void BtnAlinDere_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Regular);
        }

        private void todoElTextoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var cl = colorDialog1.ShowDialog();
            if (cl == DialogResult.OK)
            {
                richTextBox1.ForeColor = colorDialog1.Color;
            }
        }

        private void parteDelTextoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var cl = colorDialog1.ShowDialog();
            if (cl == DialogResult.OK)
            {
                richTextBox1.SelectionColor = colorDialog1.Color;
                
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
