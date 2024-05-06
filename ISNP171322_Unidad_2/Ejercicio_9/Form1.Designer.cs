namespace Ejercicio_9
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
            this.txtNumero1 = new System.Windows.Forms.TextBox();
            this.txtNumero6 = new System.Windows.Forms.TextBox();
            this.txtNumero7 = new System.Windows.Forms.TextBox();
            this.txtNumero8 = new System.Windows.Forms.TextBox();
            this.txtNumero10 = new System.Windows.Forms.TextBox();
            this.txtNumero9 = new System.Windows.Forms.TextBox();
            this.txtNumero5 = new System.Windows.Forms.TextBox();
            this.txtNumero4 = new System.Windows.Forms.TextBox();
            this.txtNumero3 = new System.Windows.Forms.TextBox();
            this.txtNumero2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNumero1
            // 
            this.txtNumero1.Location = new System.Drawing.Point(208, 96);
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(100, 20);
            this.txtNumero1.TabIndex = 0;
            // 
            // txtNumero6
            // 
            this.txtNumero6.Location = new System.Drawing.Point(208, 226);
            this.txtNumero6.Name = "txtNumero6";
            this.txtNumero6.Size = new System.Drawing.Size(100, 20);
            this.txtNumero6.TabIndex = 1;
            // 
            // txtNumero7
            // 
            this.txtNumero7.Location = new System.Drawing.Point(208, 252);
            this.txtNumero7.Name = "txtNumero7";
            this.txtNumero7.Size = new System.Drawing.Size(100, 20);
            this.txtNumero7.TabIndex = 2;
            // 
            // txtNumero8
            // 
            this.txtNumero8.Location = new System.Drawing.Point(208, 278);
            this.txtNumero8.Name = "txtNumero8";
            this.txtNumero8.Size = new System.Drawing.Size(100, 20);
            this.txtNumero8.TabIndex = 3;
            // 
            // txtNumero10
            // 
            this.txtNumero10.Location = new System.Drawing.Point(208, 330);
            this.txtNumero10.Name = "txtNumero10";
            this.txtNumero10.Size = new System.Drawing.Size(100, 20);
            this.txtNumero10.TabIndex = 4;
            // 
            // txtNumero9
            // 
            this.txtNumero9.Location = new System.Drawing.Point(208, 304);
            this.txtNumero9.Name = "txtNumero9";
            this.txtNumero9.Size = new System.Drawing.Size(100, 20);
            this.txtNumero9.TabIndex = 5;
            // 
            // txtNumero5
            // 
            this.txtNumero5.Location = new System.Drawing.Point(208, 200);
            this.txtNumero5.Name = "txtNumero5";
            this.txtNumero5.Size = new System.Drawing.Size(100, 20);
            this.txtNumero5.TabIndex = 7;
            // 
            // txtNumero4
            // 
            this.txtNumero4.Location = new System.Drawing.Point(208, 174);
            this.txtNumero4.Name = "txtNumero4";
            this.txtNumero4.Size = new System.Drawing.Size(100, 20);
            this.txtNumero4.TabIndex = 8;
            // 
            // txtNumero3
            // 
            this.txtNumero3.Location = new System.Drawing.Point(208, 148);
            this.txtNumero3.Name = "txtNumero3";
            this.txtNumero3.Size = new System.Drawing.Size(100, 20);
            this.txtNumero3.TabIndex = 9;
            // 
            // txtNumero2
            // 
            this.txtNumero2.Location = new System.Drawing.Point(208, 122);
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new System.Drawing.Size(100, 20);
            this.txtNumero2.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(59, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(442, 22);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ingrese 10 números para encontrar el número mayor";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(489, 418);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(61, 209);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(84, 37);
            this.btnBuscar.TabIndex = 13;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.BackColor = System.Drawing.Color.Transparent;
            this.lblResult.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.White;
            this.lblResult.Location = new System.Drawing.Point(253, 366);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 19);
            this.lblResult.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Ejercicio_9.Properties.Resources.Logotipo_horizontal_blanco1;
            this.pictureBox1.Location = new System.Drawing.Point(4, 372);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(245, 80);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Ejercicio_9.Properties.Resources.vb2;
            this.ClientSize = new System.Drawing.Size(576, 450);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumero2);
            this.Controls.Add(this.txtNumero3);
            this.Controls.Add(this.txtNumero4);
            this.Controls.Add(this.txtNumero5);
            this.Controls.Add(this.txtNumero9);
            this.Controls.Add(this.txtNumero10);
            this.Controls.Add(this.txtNumero8);
            this.Controls.Add(this.txtNumero7);
            this.Controls.Add(this.txtNumero6);
            this.Controls.Add(this.txtNumero1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumero1;
        private System.Windows.Forms.TextBox txtNumero6;
        private System.Windows.Forms.TextBox txtNumero7;
        private System.Windows.Forms.TextBox txtNumero8;
        private System.Windows.Forms.TextBox txtNumero10;
        private System.Windows.Forms.TextBox txtNumero9;
        private System.Windows.Forms.TextBox txtNumero5;
        private System.Windows.Forms.TextBox txtNumero4;
        private System.Windows.Forms.TextBox txtNumero3;
        private System.Windows.Forms.TextBox txtNumero2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

