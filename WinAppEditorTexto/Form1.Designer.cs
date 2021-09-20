
namespace WinAppEditorTexto
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ediccíonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenStriAtras = new System.Windows.Forms.ToolStripMenuItem();
            this.MenStriAdelante = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.MenStriCopiar = new System.Windows.Forms.ToolStripMenuItem();
            this.MenStriCortar = new System.Windows.Forms.ToolStripMenuItem();
            this.MenStriPegar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.MenStriSeleccionaTodo = new System.Windows.Forms.ToolStripMenuItem();
            this.MenStripEliminarTodo = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuColor = new System.Windows.Forms.ToolStripMenuItem();
            this.todoElTextoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parteDelTextoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFormato = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnCopiar = new System.Windows.Forms.ToolStripButton();
            this.Btn_Cortar = new System.Windows.Forms.ToolStripButton();
            this.BtnPegar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.ComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.BtnAliIzq = new System.Windows.Forms.ToolStripButton();
            this.BtnAlinCent = new System.Windows.Forms.ToolStripButton();
            this.BtnAlinDere = new System.Windows.Forms.ToolStripButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.guardarToolStripMenuItem,
            this.toolStripSeparator1,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("archivoToolStripMenuItem.Image")));
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nuevoToolStripMenuItem.Image")));
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("abrirToolStripMenuItem.Image")));
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("guardarToolStripMenuItem.Image")));
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(142, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salirToolStripMenuItem.Image")));
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // ediccíonToolStripMenuItem
            // 
            this.ediccíonToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenStriAtras,
            this.MenStriAdelante,
            this.toolStripSeparator2,
            this.MenStriCopiar,
            this.MenStriCortar,
            this.MenStriPegar,
            this.toolStripSeparator3,
            this.MenStriSeleccionaTodo,
            this.MenStripEliminarTodo});
            this.ediccíonToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ediccíonToolStripMenuItem.Image")));
            this.ediccíonToolStripMenuItem.Name = "ediccíonToolStripMenuItem";
            this.ediccíonToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.ediccíonToolStripMenuItem.Text = "Edicción";
            // 
            // MenStriAtras
            // 
            this.MenStriAtras.Image = ((System.Drawing.Image)(resources.GetObject("MenStriAtras.Image")));
            this.MenStriAtras.Name = "MenStriAtras";
            this.MenStriAtras.Size = new System.Drawing.Size(307, 26);
            this.MenStriAtras.Text = "Atras                   Ctrl + Z";
            this.MenStriAtras.Click += new System.EventHandler(this.MenStriAtras_Click);
            // 
            // MenStriAdelante
            // 
            this.MenStriAdelante.Image = ((System.Drawing.Image)(resources.GetObject("MenStriAdelante.Image")));
            this.MenStriAdelante.Name = "MenStriAdelante";
            this.MenStriAdelante.Size = new System.Drawing.Size(307, 26);
            this.MenStriAdelante.Text = "Adelante            Ctrl + Y";
            this.MenStriAdelante.Click += new System.EventHandler(this.adelanteToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(304, 6);
            // 
            // MenStriCopiar
            // 
            this.MenStriCopiar.Image = ((System.Drawing.Image)(resources.GetObject("MenStriCopiar.Image")));
            this.MenStriCopiar.Name = "MenStriCopiar";
            this.MenStriCopiar.Size = new System.Drawing.Size(307, 26);
            this.MenStriCopiar.Text = "Copiar                Ctrl + C";
            this.MenStriCopiar.Click += new System.EventHandler(this.copiarToolStripMenuItem_Click);
            // 
            // MenStriCortar
            // 
            this.MenStriCortar.Image = ((System.Drawing.Image)(resources.GetObject("MenStriCortar.Image")));
            this.MenStriCortar.Name = "MenStriCortar";
            this.MenStriCortar.Size = new System.Drawing.Size(307, 26);
            this.MenStriCortar.Text = "Cortar                Ctrl + X";
            this.MenStriCortar.Click += new System.EventHandler(this.MenStriCortar_Click);
            // 
            // MenStriPegar
            // 
            this.MenStriPegar.Image = ((System.Drawing.Image)(resources.GetObject("MenStriPegar.Image")));
            this.MenStriPegar.Name = "MenStriPegar";
            this.MenStriPegar.Size = new System.Drawing.Size(307, 26);
            this.MenStriPegar.Text = "Pegar                 Ctrl + V";
            this.MenStriPegar.Click += new System.EventHandler(this.MenStriPegar_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(304, 6);
            // 
            // MenStriSeleccionaTodo
            // 
            this.MenStriSeleccionaTodo.Image = ((System.Drawing.Image)(resources.GetObject("MenStriSeleccionaTodo.Image")));
            this.MenStriSeleccionaTodo.Name = "MenStriSeleccionaTodo";
            this.MenStriSeleccionaTodo.Size = new System.Drawing.Size(307, 26);
            this.MenStriSeleccionaTodo.Text = "Seleccionar Todo   Ctrl + E";
            this.MenStriSeleccionaTodo.Click += new System.EventHandler(this.MenStriSeleccionaTodo_Click);
            // 
            // MenStripEliminarTodo
            // 
            this.MenStripEliminarTodo.Image = ((System.Drawing.Image)(resources.GetObject("MenStripEliminarTodo.Image")));
            this.MenStripEliminarTodo.Name = "MenStripEliminarTodo";
            this.MenStripEliminarTodo.Size = new System.Drawing.Size(307, 26);
            this.MenStripEliminarTodo.Text = "Eliminar Todo         Ctrl + Alt + X";
            this.MenStripEliminarTodo.Click += new System.EventHandler(this.MenStripEliminarTodo_Click);
            // 
            // MenuColor
            // 
            this.MenuColor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.todoElTextoToolStripMenuItem,
            this.parteDelTextoToolStripMenuItem});
            this.MenuColor.Image = ((System.Drawing.Image)(resources.GetObject("MenuColor.Image")));
            this.MenuColor.Name = "MenuColor";
            this.MenuColor.Size = new System.Drawing.Size(79, 24);
            this.MenuColor.Text = "Color";
            this.MenuColor.Click += new System.EventHandler(this.MenuColor_Click);
            // 
            // todoElTextoToolStripMenuItem
            // 
            this.todoElTextoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("todoElTextoToolStripMenuItem.Image")));
            this.todoElTextoToolStripMenuItem.Name = "todoElTextoToolStripMenuItem";
            this.todoElTextoToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.todoElTextoToolStripMenuItem.Text = "Todo el Texto";
            this.todoElTextoToolStripMenuItem.Click += new System.EventHandler(this.todoElTextoToolStripMenuItem_Click);
            // 
            // parteDelTextoToolStripMenuItem
            // 
            this.parteDelTextoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("parteDelTextoToolStripMenuItem.Image")));
            this.parteDelTextoToolStripMenuItem.Name = "parteDelTextoToolStripMenuItem";
            this.parteDelTextoToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.parteDelTextoToolStripMenuItem.Text = "Parte del Texto";
            this.parteDelTextoToolStripMenuItem.Click += new System.EventHandler(this.parteDelTextoToolStripMenuItem_Click);
            // 
            // MenuFormato
            // 
            this.MenuFormato.Image = ((System.Drawing.Image)(resources.GetObject("MenuFormato.Image")));
            this.MenuFormato.Name = "MenuFormato";
            this.MenuFormato.Size = new System.Drawing.Size(99, 24);
            this.MenuFormato.Text = "Formato";
            this.MenuFormato.Click += new System.EventHandler(this.MenuFormato_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.ediccíonToolStripMenuItem,
            this.MenuColor,
            this.MenuFormato});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(843, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnCopiar,
            this.Btn_Cortar,
            this.BtnPegar,
            this.toolStripButton1,
            this.toolStripButton3,
            this.toolStripButton2,
            this.ComboBox1,
            this.BtnAliIzq,
            this.BtnAlinCent,
            this.BtnAlinDere});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(843, 28);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BtnCopiar
            // 
            this.BtnCopiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnCopiar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCopiar.Image")));
            this.BtnCopiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnCopiar.Name = "BtnCopiar";
            this.BtnCopiar.Size = new System.Drawing.Size(29, 25);
            this.BtnCopiar.Text = "Copiar";
            this.BtnCopiar.Click += new System.EventHandler(this.copiarToolStripMenuItem_Click);
            // 
            // Btn_Cortar
            // 
            this.Btn_Cortar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Btn_Cortar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Cortar.Image")));
            this.Btn_Cortar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_Cortar.Name = "Btn_Cortar";
            this.Btn_Cortar.Size = new System.Drawing.Size(29, 25);
            this.Btn_Cortar.Text = "Cortar";
            this.Btn_Cortar.Click += new System.EventHandler(this.MenStriCortar_Click);
            // 
            // BtnPegar
            // 
            this.BtnPegar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnPegar.Image = ((System.Drawing.Image)(resources.GetObject("BtnPegar.Image")));
            this.BtnPegar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnPegar.Name = "BtnPegar";
            this.BtnPegar.Size = new System.Drawing.Size(29, 25);
            this.BtnPegar.Text = "Pegar";
            this.BtnPegar.Click += new System.EventHandler(this.MenStriPegar_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 25);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            this.toolStripButton1.DoubleClick += new System.EventHandler(this.toolStripButton1_DoubleClick);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(29, 25);
            this.toolStripButton3.Text = "toolStripButton3";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(29, 25);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // ComboBox1
            // 
            this.ComboBox1.Items.AddRange(new object[] {
            "9",
            "10",
            "11",
            "12",
            "14",
            "18",
            "20",
            "24",
            "36"});
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.Size = new System.Drawing.Size(160, 28);
            this.ComboBox1.SelectedIndexChanged += new System.EventHandler(this.Seleccionar_tamanio);
            // 
            // BtnAliIzq
            // 
            this.BtnAliIzq.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnAliIzq.Image = ((System.Drawing.Image)(resources.GetObject("BtnAliIzq.Image")));
            this.BtnAliIzq.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnAliIzq.Name = "BtnAliIzq";
            this.BtnAliIzq.Size = new System.Drawing.Size(29, 25);
            this.BtnAliIzq.Text = "toolStripButton3";
            this.BtnAliIzq.Click += new System.EventHandler(this.BtnAliIzq_Click);
            // 
            // BtnAlinCent
            // 
            this.BtnAlinCent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnAlinCent.Image = ((System.Drawing.Image)(resources.GetObject("BtnAlinCent.Image")));
            this.BtnAlinCent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnAlinCent.Name = "BtnAlinCent";
            this.BtnAlinCent.Size = new System.Drawing.Size(29, 25);
            this.BtnAlinCent.Text = "toolStripButton4";
            this.BtnAlinCent.Click += new System.EventHandler(this.BtnAlinCent_Click);
            // 
            // BtnAlinDere
            // 
            this.BtnAlinDere.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnAlinDere.Image = ((System.Drawing.Image)(resources.GetObject("BtnAlinDere.Image")));
            this.BtnAlinDere.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnAlinDere.Name = "BtnAlinDere";
            this.BtnAlinDere.Size = new System.Drawing.Size(29, 25);
            this.BtnAlinDere.Text = "toolStripButton6";
            this.BtnAlinDere.Click += new System.EventHandler(this.BtnAlinDere_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(0, 68);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(841, 405);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(814, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 470);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ediccíonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenStriAtras;
        private System.Windows.Forms.ToolStripMenuItem MenStriAdelante;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem MenStriCopiar;
        private System.Windows.Forms.ToolStripMenuItem MenStriCortar;
        private System.Windows.Forms.ToolStripMenuItem MenStriPegar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem MenStriSeleccionaTodo;
        private System.Windows.Forms.ToolStripMenuItem MenStripEliminarTodo;
        private System.Windows.Forms.ToolStripMenuItem MenuColor;
        private System.Windows.Forms.ToolStripMenuItem MenuFormato;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BtnCopiar;
        private System.Windows.Forms.ToolStripButton Btn_Cortar;
        private System.Windows.Forms.ToolStripButton BtnPegar;
        private System.Windows.Forms.ToolStripComboBox ComboBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton BtnAliIzq;
        private System.Windows.Forms.ToolStripButton BtnAlinCent;
        private System.Windows.Forms.ToolStripButton BtnAlinDere;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripMenuItem todoElTextoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parteDelTextoToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

