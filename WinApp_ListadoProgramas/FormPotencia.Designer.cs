
namespace WinApp_ListadoProgramas
{
    partial class FormPotencia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPotencia));
            this.pbxlimpiar = new System.Windows.Forms.PictureBox();
            this.txtboxbase = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtboxexponente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Elementos = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxlimpiar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxlimpiar
            // 
            this.pbxlimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxlimpiar.Image = ((System.Drawing.Image)(resources.GetObject("pbxlimpiar.Image")));
            this.pbxlimpiar.Location = new System.Drawing.Point(625, 189);
            this.pbxlimpiar.Name = "pbxlimpiar";
            this.pbxlimpiar.Size = new System.Drawing.Size(24, 23);
            this.pbxlimpiar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxlimpiar.TabIndex = 31;
            this.pbxlimpiar.TabStop = false;
            this.pbxlimpiar.Click += new System.EventHandler(this.pbxlimpiar_Click);
            // 
            // txtboxbase
            // 
            this.txtboxbase.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxbase.Location = new System.Drawing.Point(264, 190);
            this.txtboxbase.Name = "txtboxbase";
            this.txtboxbase.Size = new System.Drawing.Size(312, 24);
            this.txtboxbase.TabIndex = 30;
            this.txtboxbase.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxbase_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(76, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 21);
            this.label1.TabIndex = 29;
            this.label1.Text = "Ingrese la base: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(332, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // txtboxexponente
            // 
            this.txtboxexponente.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxexponente.Location = new System.Drawing.Point(264, 236);
            this.txtboxexponente.Name = "txtboxexponente";
            this.txtboxexponente.Size = new System.Drawing.Size(312, 24);
            this.txtboxexponente.TabIndex = 33;
            this.txtboxexponente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxexponente_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(76, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 21);
            this.label2.TabIndex = 32;
            this.label2.Text = "Ingrese el exponente: ";
            // 
            // Elementos
            // 
            this.Elementos.FormattingEnabled = true;
            this.Elementos.ItemHeight = 16;
            this.Elementos.Location = new System.Drawing.Point(264, 306);
            this.Elementos.Name = "Elementos";
            this.Elementos.Size = new System.Drawing.Size(312, 100);
            this.Elementos.TabIndex = 34;
            // 
            // FormPotencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(776, 482);
            this.Controls.Add(this.Elementos);
            this.Controls.Add(this.txtboxexponente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbxlimpiar);
            this.Controls.Add(this.txtboxbase);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormPotencia";
            this.Text = "FormPotencia";
            ((System.ComponentModel.ISupportInitialize)(this.pbxlimpiar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxlimpiar;
        private System.Windows.Forms.TextBox txtboxbase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtboxexponente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox Elementos;
    }
}