
namespace WinApp_ListadoProgramas
{
    partial class FormTipoNumeros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTipoNumeros));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbxnumero = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrimo = new System.Windows.Forms.Button();
            this.btnPerfecto = new System.Windows.Forms.Button();
            this.btnCapicua = new System.Windows.Forms.Button();
            this.btnDivisores = new System.Windows.Forms.Button();
            this.btnFactorial = new System.Windows.Forms.Button();
            this.btnFactorion = new System.Windows.Forms.Button();
            this.lblsolucion = new System.Windows.Forms.Label();
            this.lblres = new System.Windows.Forms.Label();
            this.pbxlimpiar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxlimpiar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(332, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // tbxnumero
            // 
            this.tbxnumero.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxnumero.Location = new System.Drawing.Point(258, 188);
            this.tbxnumero.Name = "tbxnumero";
            this.tbxnumero.Size = new System.Drawing.Size(312, 24);
            this.tbxnumero.TabIndex = 5;
            this.tbxnumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxnumero_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(96, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ingrese el numero: ";
            // 
            // btnPrimo
            // 
            this.btnPrimo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrimo.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.btnPrimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrimo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimo.ForeColor = System.Drawing.Color.White;
            this.btnPrimo.Location = new System.Drawing.Point(20, 259);
            this.btnPrimo.Name = "btnPrimo";
            this.btnPrimo.Size = new System.Drawing.Size(110, 35);
            this.btnPrimo.TabIndex = 15;
            this.btnPrimo.Text = "PRIMO";
            this.btnPrimo.UseVisualStyleBackColor = true;
            this.btnPrimo.Click += new System.EventHandler(this.btnPrimo_Click);
            // 
            // btnPerfecto
            // 
            this.btnPerfecto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPerfecto.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.btnPerfecto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerfecto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerfecto.ForeColor = System.Drawing.Color.White;
            this.btnPerfecto.Location = new System.Drawing.Point(146, 259);
            this.btnPerfecto.Name = "btnPerfecto";
            this.btnPerfecto.Size = new System.Drawing.Size(110, 35);
            this.btnPerfecto.TabIndex = 16;
            this.btnPerfecto.Text = "PERFECTO";
            this.btnPerfecto.UseVisualStyleBackColor = true;
            this.btnPerfecto.Click += new System.EventHandler(this.btnPerfecto_Click);
            // 
            // btnCapicua
            // 
            this.btnCapicua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCapicua.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.btnCapicua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapicua.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapicua.ForeColor = System.Drawing.Color.White;
            this.btnCapicua.Location = new System.Drawing.Point(273, 259);
            this.btnCapicua.Name = "btnCapicua";
            this.btnCapicua.Size = new System.Drawing.Size(110, 35);
            this.btnCapicua.TabIndex = 17;
            this.btnCapicua.Text = "CAPICUA";
            this.btnCapicua.UseVisualStyleBackColor = true;
            this.btnCapicua.Click += new System.EventHandler(this.btnCapicua_Click);
            // 
            // btnDivisores
            // 
            this.btnDivisores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDivisores.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.btnDivisores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDivisores.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivisores.ForeColor = System.Drawing.Color.White;
            this.btnDivisores.Location = new System.Drawing.Point(398, 259);
            this.btnDivisores.Name = "btnDivisores";
            this.btnDivisores.Size = new System.Drawing.Size(110, 35);
            this.btnDivisores.TabIndex = 18;
            this.btnDivisores.Text = "DIVISORES";
            this.btnDivisores.UseVisualStyleBackColor = true;
            this.btnDivisores.Click += new System.EventHandler(this.btnDivisores_Click);
            // 
            // btnFactorial
            // 
            this.btnFactorial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFactorial.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.btnFactorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFactorial.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFactorial.ForeColor = System.Drawing.Color.White;
            this.btnFactorial.Location = new System.Drawing.Point(524, 259);
            this.btnFactorial.Name = "btnFactorial";
            this.btnFactorial.Size = new System.Drawing.Size(110, 35);
            this.btnFactorial.TabIndex = 19;
            this.btnFactorial.Text = "FACTORIAL";
            this.btnFactorial.UseVisualStyleBackColor = true;
            this.btnFactorial.Click += new System.EventHandler(this.btnFactorial_Click);
            // 
            // btnFactorion
            // 
            this.btnFactorion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFactorion.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.btnFactorion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFactorion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFactorion.ForeColor = System.Drawing.Color.White;
            this.btnFactorion.Location = new System.Drawing.Point(649, 259);
            this.btnFactorion.Name = "btnFactorion";
            this.btnFactorion.Size = new System.Drawing.Size(110, 35);
            this.btnFactorion.TabIndex = 20;
            this.btnFactorion.Text = "FACTORION";
            this.btnFactorion.UseVisualStyleBackColor = true;
            this.btnFactorion.Click += new System.EventHandler(this.btnFactorion_Click);
            // 
            // lblsolucion
            // 
            this.lblsolucion.AutoSize = true;
            this.lblsolucion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsolucion.ForeColor = System.Drawing.Color.White;
            this.lblsolucion.Location = new System.Drawing.Point(96, 347);
            this.lblsolucion.Name = "lblsolucion";
            this.lblsolucion.Size = new System.Drawing.Size(99, 21);
            this.lblsolucion.TabIndex = 21;
            this.lblsolucion.Text = "Respuesta: ";
            // 
            // lblres
            // 
            this.lblres.AutoSize = true;
            this.lblres.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblres.ForeColor = System.Drawing.Color.White;
            this.lblres.Location = new System.Drawing.Point(201, 347);
            this.lblres.Name = "lblres";
            this.lblres.Size = new System.Drawing.Size(0, 21);
            this.lblres.TabIndex = 22;
            // 
            // pbxlimpiar
            // 
            this.pbxlimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxlimpiar.Image = ((System.Drawing.Image)(resources.GetObject("pbxlimpiar.Image")));
            this.pbxlimpiar.Location = new System.Drawing.Point(585, 188);
            this.pbxlimpiar.Name = "pbxlimpiar";
            this.pbxlimpiar.Size = new System.Drawing.Size(24, 23);
            this.pbxlimpiar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxlimpiar.TabIndex = 23;
            this.pbxlimpiar.TabStop = false;
            this.pbxlimpiar.Click += new System.EventHandler(this.pbxlimpiar_Click);
            // 
            // FormTipoNumeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(776, 482);
            this.Controls.Add(this.pbxlimpiar);
            this.Controls.Add(this.lblres);
            this.Controls.Add(this.lblsolucion);
            this.Controls.Add(this.btnFactorion);
            this.Controls.Add(this.btnFactorial);
            this.Controls.Add(this.btnDivisores);
            this.Controls.Add(this.btnCapicua);
            this.Controls.Add(this.btnPerfecto);
            this.Controls.Add(this.btnPrimo);
            this.Controls.Add(this.tbxnumero);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormTipoNumeros";
            this.Text = "FormTipoNumeros";
            this.Load += new System.EventHandler(this.FormTipoNumeros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxlimpiar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbxnumero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrimo;
        private System.Windows.Forms.Button btnPerfecto;
        private System.Windows.Forms.Button btnCapicua;
        private System.Windows.Forms.Button btnDivisores;
        private System.Windows.Forms.Button btnFactorial;
        private System.Windows.Forms.Button btnFactorion;
        private System.Windows.Forms.Label lblsolucion;
        private System.Windows.Forms.Label lblres;
        private System.Windows.Forms.PictureBox pbxlimpiar;
    }
}