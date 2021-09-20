using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppConversionTallas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnGenerar_Click(object sender, EventArgs e)
        {
            int filas = dataGridView1.Rows.Add(36);
            for (int i = 0; i <= 36; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = 48 + i;
                dataGridView1.Rows[i].Cells[1].Value = (48 + i) * 2.54;
            }
        }

       
    }
}
