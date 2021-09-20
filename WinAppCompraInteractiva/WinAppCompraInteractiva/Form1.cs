using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppCompraInteractiva
{
    public partial class Form1 : Form
    {

        double precioblusa , preciotop,preciochaq , preciofalda;
        double preciocamiseta, preciozapatos, precioleva, precioterno;
        public Form1()
        {
            InitializeComponent();
        }

        private void panel_mujer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panel_bienvenida.Visible = false;
            hombremoda.Visible = false;
            estrella1.Visible = false;
            estrella2.Visible = false;
            estrella3.Visible = false;
            estrella4.Visible = false;
            estrella5.Visible = false;
            estrella6.Visible = false;
            estrella7.Visible = false;
            estrella8.Visible = false;
            pbx_hombre.Visible= false;
            lbl_titulo.Visible = true;
            lbl_titulo.Text = "MUJERES";
            panel_mujer.Visible = true;
            pxb_carritocompra.Visible = true;
            pbx_mujer.Visible = false;
            lbl_mujer.Visible = false;
            lblhombre.Visible = false;
            panel_fondofactura.Visible = true;
            gifmujer.Visible = true;
            pbx_regresar.Visible = true;
            lbl_detalle.Visible = false;
            dataGridView2.Visible = false;
            btn_pagar.Visible = false;
            lbl_totalhombre.Visible = false;
            lbl_titupaghombre.Visible = false;
            lbl_titupagmujer.Visible = false;
            btn_pagar.Visible = false;
            lbl_totalapagarmujer.Visible = false;
            chbx_blusa.Visible = false;
            chbx_falda.Visible = false;
            chbx_chaqjean.Visible = false;
            chbx_top.Visible = false;
            cbx_blusa.Visible = false;
            cbx_unidades.Visible = false;
            btn_blusa.Visible = false;
            pxb2_amarillo.Visible = false;
            cbx_tallaschqjean.Visible = false;
            cbx_unidadeschjean.Visible = false;
            btn_chaq.Visible = false;
            pxb_chq2.Visible = false;
            cbx_tallatop.Visible = false;
            cbx_unidadtop.Visible = false;
            btn_top.Visible = false;
            pxb_top2.Visible = false;
            pxb_falda2.Visible = false;
            cbx_unifalda.Visible = false;
            cbx_tallafalda.Visible = false;
            btn_falda.Visible = false;
            btn_comp.Visible = false;
            dataGridView1.Visible = false;
            pxb_falda.Visible = true;
            pxb_chaquetajean.Visible = true;
            pxb_blusaamarilla.Visible = true;
            pxb_croptop.Visible = true;
            lbl_amarillo.Visible = true;
            lbl_top.Visible = true;
            lbl_caque.Visible = true;
            lbl_titulofalda.Visible = true;
            lbl_precioamarillo.Visible = true;
            lbl_preciochaq.Visible = true;
            lbl_preciotop.Visible = true;
            label10.Visible = true;
            




        }

        private void pxb_carritocompra_Click(object sender, EventArgs e)
        {
            pbx_regresar.Visible = false;
            // panel_hombre.Visible = true;
            pxb_falda.Visible = false;
            lbl_titulofalda.Visible = false;
            label10.Visible = false;
            //panel_carro.Visible = true;
            pxb_croptop.Visible = false;
            lbl_top.Visible = false;
            lbl_preciotop.Visible = false;
            pxb_chaquetajean.Visible = false;
            lbl_caque.Visible = false;
            lbl_preciochaq.Visible = false;
            pxb_blusaamarilla.Visible = false;
            lbl_amarillo.Visible = false;
            lbl_precioamarillo.Visible = false;
            pxb2_amarillo.Visible = true;
            btn_blusa.Visible = true;
            cbx_blusa.Visible = true;
            cbx_unidades.Visible = true;
            chbx_blusa.Visible = true;
            pxb_top2.Visible = true;
            chbx_top.Visible = true;
            cbx_tallatop.Visible= true;
            cbx_unidadtop.Visible = true;
            btn_blusa.Enabled = false;
            btn_chaq.Enabled = false;
            btn_falda.Enabled = false;
            btn_top.Enabled = false;
            cbx_blusa.Enabled = false;
            cbx_unidades.Enabled = false;
            btn_blusa.Enabled = false;
            cbx_tallatop.Enabled = false;
            cbx_unidadtop.Enabled = false;
            btn_top.Enabled = false;
            cbx_tallaschqjean.Enabled = false;
            cbx_unidadeschjean.Enabled = false;
            btn_chaq.Enabled = false;
            cbx_tallafalda.Enabled = false;
            cbx_unifalda.Enabled = false;
            btn_falda.Enabled = false;
            pxb_chq2.Visible = true;
            chbx_chaqjean.Visible = true;
            cbx_tallaschqjean.Visible = true;
            cbx_unidadeschjean.Visible = true;
            btn_chaq.Visible = true;
            pxb_falda2.Visible = true;
            chbx_falda.Visible = true;
            btn_falda.Visible = true;
            btn_top.Visible = true;
            cbx_tallafalda.Visible = true;
            cbx_unifalda.Visible = true;
            btn_comp.Visible = true;
            


        }

        private void chbx_blusa_CheckedChanged(object sender, EventArgs e)
        {
            if (chbx_blusa.Checked)
            {
                cbx_blusa.Enabled = true;
                cbx_unidades.Enabled = true;
                btn_blusa.Enabled = false;
            }
            else
            {
                cbx_blusa.Enabled = false;
                cbx_unidades.Enabled = false;
                btn_blusa.Enabled = false;
            }
                
        }

        private void chbx_top_CheckedChanged(object sender, EventArgs e)
        {
            if (chbx_top.Checked)
            {
                cbx_tallatop.Enabled = true;
                cbx_unidadtop.Enabled = true;
                btn_top.Enabled = false;
            }
            else
            {
                cbx_tallatop.Enabled = false;
                cbx_unidadtop.Enabled = false;
                btn_top.Enabled = false;
            }
        }

        private void chbx_chaqjean_CheckedChanged(object sender, EventArgs e)
        {
            if (chbx_chaqjean.Checked)
            {
                cbx_tallaschqjean.Enabled = true;
                cbx_unidadeschjean.Enabled = true;
                btn_chaq.Enabled = false;
            }
            else
            {
                cbx_tallaschqjean.Enabled = false;
                cbx_unidadeschjean.Enabled = false;
                btn_chaq.Enabled = false;
            }
        }

        private void cbx_unidadtop_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbx_unidadtop.SelectedIndex)
            {
                case 0:
                    preciotop = 17 * 1;
                    break;
                case 1:
                    preciotop = 17 * 2;
                    break;
                case 2:
                    preciotop = 17 * 6;
                    break;
                case 3:
                    preciotop = 17 * 12;
                    break;
            }
        }

        private void cbx_unidadeschjean_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbx_unidadeschjean.SelectedIndex)
            {
                case 0:
                    preciochaq = 30* 1;
                    break;
                case 1:
                    preciochaq = 30 * 2;
                    break;
                case 2:
                    preciochaq = 30 * 6;
                    break;
                case 3:
                    preciochaq = 30 * 12;
                    break;
            }
        }

        private void cbx_unifalda_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbx_unifalda.SelectedIndex)
            {
                case 0:
                    preciofalda = 15 * 1;
                    break;
                case 1:
                    preciofalda = 15 * 2;
                    break;
                case 2:
                    preciofalda = 15 * 6;
                    break;
                case 3:
                    preciofalda = 15 * 12;
                    break;
            }
        }

        private void panel_carro_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_falda_Click(object sender, EventArgs e)
        {

        }

        private void cbx_tallafalda_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pbx_hombre_Click(object sender, EventArgs e)
        {
            panel_mujer.Visible = true;
            //pbx_mujer.Enabled = false;
            panel_hombre.Visible = true;
            lbl_titulo.Text = "HOMBRES";
            lbl_titulo.Visible = true;
            pxbcarro_hombre.Visible = true;
            pbx_mujer.Visible = false;
            lbl_mujer.Visible = false;
            lblhombre.Visible = false;
            pbx_hombre.Visible = false;
            panel_fondofactura.Visible = true;
            hombremoda.Visible = true;
            //panel_fondofactura.Visible = false;
            panel_bienvenida.Visible = false;
            pbx_regresar.Visible = true;
            lbl_detalle.Visible = false;
            dataGridView1.Visible = false;
            lbl_titupagmujer.Visible = false;
            btn_pagar.Visible = false;
            lbl_totalapagarmujer.Visible = false;
            chbx_blusa.Visible = false;
            chbx_falda.Visible = false;
            chbx_chaqjean.Visible = false;
            chbx_top.Visible = false;
            cbx_blusa.Visible = false;
            cbx_unidades.Visible = false;
            btn_blusa.Visible = false;
            pxb2_amarillo.Visible = false;
            cbx_tallaschqjean.Visible = false;
            cbx_unidadeschjean.Visible = false;
            btn_chaq.Visible = false;
            pxb_chq2.Visible = false;
            cbx_tallatop.Visible = false;
            cbx_unidadtop.Visible = false;
            btn_top.Visible = false;
            pxb_top2.Visible = false;
            pxb_falda2.Visible = false;
            cbx_unifalda.Visible = false;
            cbx_tallafalda.Visible = false;
            btn_falda.Visible = false;
            btn_comp.Visible = false;
            chbox_camiseta.Visible = false;
            chbx_leva.Visible = false;
            chbx_zapatos.Visible = false;
            chbx_terno.Visible = false;
            pxb_zapatos2.Visible = false;
            pbx_leva2.Visible = false;
            pbx_terno2.Visible = false;
            pxb_camiseta2.Visible = false;
            cbx_tallacamiseta.Visible = false;
            cbx_tallaterno.Visible = false;
            cbx_tallaleva.Visible = false;
            cbx_tallazapatos.Visible = false;
            cbx_unidadescamiseta.Visible = false;
            cbx_unidadleva.Visible = false;
            cbx_unidadzapato.Visible = false;
            cbx_unidadterno.Visible = false;
            btn_leva.Visible = false;
            btn_terrno.Visible = false;
            btn_zzapatos.Visible = false;
            btn_camisetahom.Visible = false;
            btn_comprarhombre.Visible = false;
            pxb_camiseta.Visible = true;
            pxb_terno.Visible = true;
            pxb_leva.Visible = true;
            pxb_zapatos.Visible = true;
            lbl_precioterno.Visible = true;
            lbl_preciozapatos.Visible = true;
            lbl_precioleva.Visible = true;
            lbl_preciocamiseta.Visible = true;
            lbl_camiseta.Visible = true;
            lbl_terno.Visible = true;
            lbl_leva.Visible = true;
            lbl_zapatos.Visible = true;
            dataGridView2.Visible = false;
            lbl_titupaghombre.Visible = false;
            lbl_totalhombre.Visible = false;

        }

        private void pxbcarro_hombre_Click(object sender, EventArgs e)
        {
            pxb_zapatos.Visible = false;
            lbl_preciozapatos.Visible = false;
            lbl_zapatos.Visible = false;
            pxb_camiseta.Visible = false;
            lbl_camiseta.Visible = false;
            lbl_preciocamiseta.Visible = false;
            pxb_terno.Visible = false;
            lbl_terno.Visible = false;
            lbl_precioterno.Visible = false;
            pxb_leva.Visible = false;
            lbl_leva.Visible = false;
            lbl_precioleva.Visible = false;
            pxb_camiseta2.Visible = true;
            chbox_camiseta.Visible = true;
            cbx_tallacamiseta.Visible = true;
            cbx_unidadescamiseta.Visible = true;
            btn_camisetahom.Visible = true;
            btn_camisetahom.Enabled = false;
            cbx_tallacamiseta.Enabled = false;
            cbx_unidadescamiseta.Enabled = false;
            pbx_terno2.Visible = true;
            chbx_terno.Visible = true;
            cbx_tallaterno.Visible = true;
            cbx_tallaterno.Enabled = false;
            cbx_unidadterno.Visible = true;
            cbx_unidadterno.Enabled = false;
            btn_terrno.Visible = true;
            btn_terrno.Enabled = false;
            pbx_leva2.Visible = true;
            chbx_leva.Visible = true;
            cbx_tallaleva.Visible = true;
            cbx_tallaleva.Enabled = false;
            cbx_unidadleva.Visible = true;
            cbx_unidadleva.Enabled = false;
            btn_leva.Visible = true;
            btn_leva.Enabled = false;
            pxb_zapatos2.Visible = true;
            chbx_zapatos.Visible = true;
            cbx_tallazapatos.Visible = true;
            cbx_tallazapatos.Enabled = false;
            cbx_unidadzapato.Visible = true;
            cbx_unidadzapato.Enabled = false;
            btn_zzapatos.Visible = true;
            btn_zzapatos.Enabled = false;
            btn_comprarhombre.Visible = true;
            pbx_regresar.Visible = false;

        }

        private void chbox_camiseta_CheckedChanged(object sender, EventArgs e)
        {
            if (chbox_camiseta.Checked)
            {
                cbx_tallacamiseta.Enabled=true;
                cbx_unidadescamiseta.Enabled = true;
                
            }
            else
            {

                cbx_tallacamiseta.Enabled = false;
                cbx_unidadescamiseta.Enabled = false;

            }
        }

        private void chbx_terno_CheckedChanged(object sender, EventArgs e)
        {
            if (chbx_terno.Checked)
            {
                cbx_tallaterno.Enabled = true;
                cbx_unidadterno.Enabled = true;
                
            }
            else
            {
                cbx_tallaterno.Enabled = false;
                cbx_unidadterno.Enabled = false;

            }
        }

        private void chbx_leva_CheckedChanged(object sender, EventArgs e)
        {
            if (chbx_leva.Checked)
            {
                cbx_tallaleva.Enabled = true;
                cbx_unidadleva.Enabled = true;

            }
            else
            {
                cbx_tallaleva.Enabled = false;
                cbx_unidadleva.Enabled = false;

            }
        }

        private void cbx_unidadescamiseta_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbx_unidadescamiseta.SelectedIndex)
            {
                case 0:
                    preciocamiseta = 7 * 1;
                    break;
                case 1:
                    preciocamiseta = 7* 2;
                    break;
                case 2:
                    preciocamiseta = 7 * 6;
                    break;
                case 3:
                    preciocamiseta = 7 * 12;
                    break;
            }
        }

        private void cbx_unidadterno_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbx_unidadterno.SelectedIndex)
            {
                case 0:
                    precioterno = 52 * 1;
                    break;
                case 1:
                    precioterno = 52 * 2;
                    break;
                case 2:
                    precioterno = 52 * 6;
                    break;
                case 3:
                    precioterno = 52 * 12;
                    break;
            }
        }

        private void cbx_unidadleva_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbx_unidadleva.SelectedIndex)
            {
                case 0:
                    precioleva = 25 * 1;
                    break;
                case 1:
                    precioleva = 25 * 2;
                    break;
                case 2:
                    precioleva = 25 * 6;
                    break;
                case 3:
                    precioleva = 25 * 12;
                    break;
            }
        }

        private void cbx_unidadzapato_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbx_unidadzapato.SelectedIndex)
            {
                case 0:
                    preciozapatos = 21 * 1;
                    break;
                case 1:
                    preciozapatos = 21 * 2;
                    break;
                case 2:
                    preciozapatos = 21* 6;
                    break;
                case 3:
                    preciozapatos= 21 * 12;
                    break;
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbx_regresar_Click(object sender, EventArgs e)
        {
            pbx_hombre.Visible = true;
            pbx_mujer.Visible = true;
            panel_bienvenida.Visible = true;
            panel_fondofactura.Visible = false;
            panel_mujer.Visible = false;
            panel_hombre.Visible = false;
            pxb_carritocompra.Visible = false;
            pxbcarro_hombre.Visible = false;
            pbx_regresar.Visible = false;

        }

        private void btn_pagar_Click(object sender, EventArgs e)
        {

        
            MessageBox.Show("Compra Exitosa", "Bien Hecho", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk);
            
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            chbox_camiseta.Enabled = true;
            chbx_leva.Enabled = true;
            chbx_terno.Enabled = true;
            chbx_zapatos.Enabled = true;
            chbx_blusa.Enabled = true;
            chbx_chaqjean.Enabled = true;
            chbx_falda.Enabled = true;
            chbx_top.Enabled = true;
            btn_comp.Enabled = true;
            
            btn_comprarhombre.Enabled = true;
            panel_hombre.Visible = false;
            panel_mujer.Visible = false;
            panel_fondofactura.Visible = false;
            pbx_hombre.Visible = true;
            pbx_mujer.Visible = true;
            panel_bienvenida.Visible = true;
            lbl_titulo.Visible = false;
            pxbcarro_hombre.Visible = false;
            pxb_carritocompra.Visible = false;

        }

        private void chbx_zapatos_CheckedChanged(object sender, EventArgs e)
        {
            if (chbx_zapatos.Checked)
            {
                cbx_tallazapatos.Enabled = true;
                cbx_unidadzapato.Enabled = true;
                
            }
            else
            {
                cbx_tallazapatos.Enabled = false;
                cbx_unidadzapato.Enabled = false;

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_comprarhombre_Click(object sender, EventArgs e)
        {
            dataGridView2.Visible = true;
            btn_pagar.Visible = true;
            lbl_titupaghombre.Visible = true;
            lbl_totalhombre.Visible = true;
            hombremoda.Visible = false;
            gifmujer.Visible = false;
            lbl_detalle.Visible = true;
            chbx_zapatos.Enabled = false;
            chbx_leva.Enabled = false;
            chbx_terno.Enabled = false;
            chbox_camiseta.Enabled = false;
            btn_comprarhombre.Enabled = false;
            
            
            if (chbox_camiseta.Checked)
            {
                dataGridView2.Rows.Add();
                int fila = dataGridView2.Rows.Count - 1;
                dataGridView2[0, fila].Value = chbox_camiseta.Text;
                dataGridView2[1, fila].Value = cbx_tallacamiseta.Text;
                dataGridView2[2, fila].Value = cbx_unidadescamiseta.Text;
                dataGridView2[3, fila].Value = "7.00";
                dataGridView2[4, fila].Value = preciocamiseta;

            }

            else
            {
                cbx_tallacamiseta.Enabled = false;
                cbx_unidadescamiseta.Enabled = false;
                btn_blusa.Enabled = false;
            }

            if (chbx_terno.Checked)
            {
                dataGridView2.Rows.Add();
                int fila = dataGridView2.Rows.Count - 1;
                dataGridView2[0, fila].Value = chbx_terno.Text;
                dataGridView2[1, fila].Value = cbx_tallaterno.Text;
                dataGridView2[2, fila].Value = cbx_unidadterno.Text;
                dataGridView2[3, fila].Value = "52.00";
                dataGridView2[4, fila].Value = precioterno;

            }

            else
            {
                cbx_tallaterno.Enabled = false;
                cbx_unidadterno.Enabled = false;
                
            }

            if (chbx_leva.Checked)
            {
                dataGridView2.Rows.Add();
                int fila = dataGridView2.Rows.Count - 1;
                dataGridView2[0, fila].Value = chbx_leva.Text;
                dataGridView2[1, fila].Value = cbx_tallaleva.Text;
                dataGridView2[2, fila].Value = cbx_unidadleva.Text;
                dataGridView2[3, fila].Value = "25.00";
                dataGridView2[4, fila].Value = precioleva;

            }

            else
            {
                cbx_tallaleva.Enabled = false;
                cbx_unidadleva.Enabled = false;

            }

            if (chbx_zapatos.Checked)
            {
                dataGridView2.Rows.Add();
                int fila = dataGridView2.Rows.Count - 1;
                dataGridView2[0, fila].Value = chbx_zapatos.Text;
                dataGridView2[1, fila].Value = cbx_tallazapatos.Text;
                dataGridView2[2, fila].Value = cbx_unidadzapato.Text;
                dataGridView2[3, fila].Value = "21.00";
                dataGridView2[4, fila].Value = preciozapatos;

            }

            else
            {
                cbx_tallazapatos.Enabled = false;
                cbx_unidadzapato.Enabled = false;

            }

            lbl_totalhombre.Text = (preciocamiseta + precioterno + preciozapatos + precioleva).ToString();

        }

        private void cbx_unidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbx_unidades.SelectedIndex)
            {
                case 0:
                    precioblusa = 12 * 1;
                    break;
                case 1:
                    precioblusa = 12 * 2;
                    break;
                case 2:
                    precioblusa = 12 * 6;
                    break;
                case 3:
                    precioblusa = 12 * 12;
                    break;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            btn_pagar.Visible = true;
            lbl_titupagmujer.Visible = true;
            lbl_totalapagarmujer.Visible = true;
            //panel_fondofactura.Visible = false;
            gifmujer.Visible = false;
            lbl_detalle.Visible = true;
            chbx_falda.Enabled = false;
            chbx_chaqjean.Enabled = false;
            chbx_top.Enabled = false;
            chbx_blusa.Enabled = false;
            btn_comp.Enabled = false;

            if (chbx_blusa.Checked)
            {
                dataGridView1.Rows.Add();
                int fila = dataGridView1.Rows.Count - 1;
                dataGridView1[0, fila].Value = chbx_blusa.Text;
                dataGridView1[1, fila].Value = cbx_blusa.Text;
                dataGridView1[2, fila].Value = cbx_unidades.Text;
                dataGridView1[3, fila].Value = "12.00";
                dataGridView1[4, fila].Value = precioblusa;
                    
            }
            
            else
            {
                cbx_blusa.Enabled = false;
                cbx_unidades.Enabled = false;
                btn_blusa.Enabled = false;
            }
            

            if (chbx_top.Checked)
            {
                dataGridView1.Rows.Add();
                int fila = dataGridView1.Rows.Count - 1;
                dataGridView1[0, fila].Value = chbx_top.Text;
                dataGridView1[1, fila].Value = cbx_tallatop.Text;
                dataGridView1[2, fila].Value = cbx_unidadtop.Text;
                dataGridView1[3, fila].Value = "17.00";
                dataGridView1[4, fila].Value = preciotop;
            }
            else
            {
                cbx_tallatop.Enabled = false;
                cbx_unidadtop.Enabled = false;
                btn_top.Enabled = false;
            }


            if (chbx_chaqjean.Checked)
            {
                dataGridView1.Rows.Add();
                int fila = dataGridView1.Rows.Count - 1;
                dataGridView1[0, fila].Value = chbx_chaqjean.Text;
                dataGridView1[1, fila].Value = cbx_tallaschqjean.Text;
                dataGridView1[2, fila].Value = cbx_unidadeschjean.Text;
                dataGridView1[3, fila].Value = "30.00";
                dataGridView1[4, fila].Value = preciochaq;
            }
            else
            {
                cbx_tallaschqjean.Enabled = false;
                cbx_unidadeschjean.Enabled = false;
                btn_chaq.Enabled = false;
            }

            if (chbx_falda.Checked)
            {

                dataGridView1.Rows.Add();
                int fila = dataGridView1.Rows.Count - 1;
                dataGridView1[0, fila].Value = chbx_falda.Text;
                dataGridView1[1, fila].Value = cbx_tallafalda.Text;
                dataGridView1[2, fila].Value = cbx_unifalda.Text;
                dataGridView1[3, fila].Value = "15.00";
                dataGridView1[4, fila].Value = preciofalda;

            }
            else
            {
                cbx_tallafalda.Enabled = false;
                cbx_unifalda.Enabled = false;
                btn_falda.Enabled = false;
            }


            lbl_totalapagarmujer.Text = (preciofalda + preciochaq + preciotop + precioblusa).ToString();
        }

        private void chbx_falda_CheckedChanged(object sender, EventArgs e)
        {
            if (chbx_falda.Checked)
            {
                cbx_tallafalda.Enabled = true;
                cbx_unifalda.Enabled = true;
                btn_falda.Enabled = false;
            }
            else
            {
                cbx_tallafalda.Enabled = false;
                cbx_unifalda.Enabled = false;
                btn_falda.Enabled = false;
            }
        }
    }
}
