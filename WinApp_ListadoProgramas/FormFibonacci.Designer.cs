
namespace WinApp_ListadoProgramas
{
    partial class FormFibonacci
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFibonacci));
            this.pbxlimpiar = new System.Windows.Forms.PictureBox();
            this.txtbxnum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lboxelementos = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxlimpiar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxlimpiar
            // 
            this.pbxlimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxlimpiar.Image = ((System.Drawing.Image)(resources.GetObject("pbxlimpiar.Image")));
            this.pbxlimpiar.Location = new System.Drawing.Point(579, 192);
            this.pbxlimpiar.Name = "pbxlimpiar";
            this.pbxlimpiar.Size = new System.Drawing.Size(24, 23);
            this.pbxlimpiar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxlimpiar.TabIndex = 27;
            this.pbxlimpiar.TabStop = false;
            this.pbxlimpiar.Click += new System.EventHandler(this.pbxlimpiar_Click);
            // 
            // txtbxnum
            // 
            this.txtbxnum.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxnum.Location = new System.Drawing.Point(252, 192);
            this.txtbxnum.Name = "txtbxnum";
            this.txtbxnum.Size = new System.Drawing.Size(312, 24);
            this.txtbxnum.TabIndex = 26;
            this.txtbxnum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxnum_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(90, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 21);
            this.label1.TabIndex = 25;
            this.label1.Text = "Ingrese el numero: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(332, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // lboxelementos
            // 
            this.lboxelementos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.lboxelementos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lboxelementos.FormattingEnabled = true;
            this.lboxelementos.ItemHeight = 16;
            this.lboxelementos.Location = new System.Drawing.Point(252, 285);
            this.lboxelementos.Name = "lboxelementos";
            this.lboxelementos.Size = new System.Drawing.Size(312, 96);
            this.lboxelementos.TabIndex = 28;
            // 
            // FormFibonacci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(776, 482);
            this.Controls.Add(this.lboxelementos);
            this.Controls.Add(this.pbxlimpiar);
            this.Controls.Add(this.txtbxnum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormFibonacci";
            this.Text = "FormFibonacci";
            ((System.ComponentModel.ISupportInitialize)(this.pbxlimpiar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxlimpiar;
        private System.Windows.Forms.TextBox txtbxnum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox lboxelementos;
    }
}