namespace Ejericio_3
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblNum1 = new System.Windows.Forms.Label();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbRaizCub = new System.Windows.Forms.RadioButton();
            this.rdbRaiz = new System.Windows.Forms.RadioButton();
            this.rdbExponencial = new System.Windows.Forms.RadioButton();
            this.rdbDivision = new System.Windows.Forms.RadioButton();
            this.rdbMulti = new System.Windows.Forms.RadioButton();
            this.rdbResta = new System.Windows.Forms.RadioButton();
            this.rbdSuma = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.texNum1 = new System.Windows.Forms.TextBox();
            this.texNum2 = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.texResulta = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.tTime = new System.Windows.Forms.Timer(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblSimbol = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.BackColor = System.Drawing.Color.Transparent;
            this.lblNum1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum1.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNum1.Location = new System.Drawing.Point(76, 48);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(75, 18);
            this.lblNum1.TabIndex = 0;
            this.lblNum1.Text = "Número 1";
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.BackColor = System.Drawing.Color.Transparent;
            this.lblNum2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum2.ForeColor = System.Drawing.Color.White;
            this.lblNum2.Location = new System.Drawing.Point(76, 106);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(75, 18);
            this.lblNum2.TabIndex = 1;
            this.lblNum2.Text = "Número 2";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnCalcular.Location = new System.Drawing.Point(109, 280);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(108, 31);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.rdbRaizCub);
            this.groupBox1.Controls.Add(this.rdbRaiz);
            this.groupBox1.Controls.Add(this.rdbExponencial);
            this.groupBox1.Controls.Add(this.rdbDivision);
            this.groupBox1.Controls.Add(this.rdbMulti);
            this.groupBox1.Controls.Add(this.rdbResta);
            this.groupBox1.Controls.Add(this.rbdSuma);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(373, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 179);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones";
            // 
            // rdbRaizCub
            // 
            this.rdbRaizCub.AutoSize = true;
            this.rdbRaizCub.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbRaizCub.Location = new System.Drawing.Point(7, 155);
            this.rdbRaizCub.Name = "rdbRaizCub";
            this.rdbRaizCub.Size = new System.Drawing.Size(93, 17);
            this.rdbRaizCub.TabIndex = 6;
            this.rdbRaizCub.Text = "Raiz Cúbica";
            this.rdbRaizCub.UseVisualStyleBackColor = true;
            this.rdbRaizCub.CheckedChanged += new System.EventHandler(this.rdbRaizCub_CheckedChanged);
            // 
            // rdbRaiz
            // 
            this.rdbRaiz.AutoSize = true;
            this.rdbRaiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbRaiz.Location = new System.Drawing.Point(7, 133);
            this.rdbRaiz.Name = "rdbRaiz";
            this.rdbRaiz.Size = new System.Drawing.Size(108, 17);
            this.rdbRaiz.TabIndex = 5;
            this.rdbRaiz.Text = "Raiz Cuadrada";
            this.rdbRaiz.UseVisualStyleBackColor = true;
            this.rdbRaiz.CheckedChanged += new System.EventHandler(this.rdbRaiz_CheckedChanged);
            // 
            // rdbExponencial
            // 
            this.rdbExponencial.AutoSize = true;
            this.rdbExponencial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbExponencial.Location = new System.Drawing.Point(7, 109);
            this.rdbExponencial.Name = "rdbExponencial";
            this.rdbExponencial.Size = new System.Drawing.Size(94, 17);
            this.rdbExponencial.TabIndex = 4;
            this.rdbExponencial.Text = "Exponencial";
            this.rdbExponencial.UseVisualStyleBackColor = true;
            this.rdbExponencial.CheckedChanged += new System.EventHandler(this.rdbExponencial_CheckedChanged);
            // 
            // rdbDivision
            // 
            this.rdbDivision.AutoSize = true;
            this.rdbDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbDivision.Location = new System.Drawing.Point(6, 85);
            this.rdbDivision.Name = "rdbDivision";
            this.rdbDivision.Size = new System.Drawing.Size(70, 17);
            this.rdbDivision.TabIndex = 3;
            this.rdbDivision.Text = "División";
            this.rdbDivision.UseVisualStyleBackColor = true;
            // 
            // rdbMulti
            // 
            this.rdbMulti.AutoSize = true;
            this.rdbMulti.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMulti.Location = new System.Drawing.Point(7, 62);
            this.rdbMulti.Name = "rdbMulti";
            this.rdbMulti.Size = new System.Drawing.Size(103, 17);
            this.rdbMulti.TabIndex = 2;
            this.rdbMulti.Text = "Multiplicación";
            this.rdbMulti.UseVisualStyleBackColor = true;
            // 
            // rdbResta
            // 
            this.rdbResta.AutoSize = true;
            this.rdbResta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbResta.Location = new System.Drawing.Point(7, 38);
            this.rdbResta.Name = "rdbResta";
            this.rdbResta.Size = new System.Drawing.Size(58, 17);
            this.rdbResta.TabIndex = 1;
            this.rdbResta.Text = "Resta";
            this.rdbResta.UseVisualStyleBackColor = true;
            // 
            // rbdSuma
            // 
            this.rbdSuma.AutoSize = true;
            this.rbdSuma.Checked = true;
            this.rbdSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbdSuma.Location = new System.Drawing.Point(7, 14);
            this.rbdSuma.Name = "rbdSuma";
            this.rbdSuma.Size = new System.Drawing.Size(56, 17);
            this.rbdSuma.TabIndex = 0;
            this.rbdSuma.TabStop = true;
            this.rbdSuma.Text = "Suma";
            this.rbdSuma.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Ejericio_3.Properties.Resources.Logotipo_vertical_white120x97;
            this.pictureBox1.Location = new System.Drawing.Point(115, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 103);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // texNum1
            // 
            this.texNum1.BackColor = System.Drawing.Color.White;
            this.texNum1.Location = new System.Drawing.Point(164, 46);
            this.texNum1.Name = "texNum1";
            this.texNum1.Size = new System.Drawing.Size(100, 20);
            this.texNum1.TabIndex = 4;
            // 
            // texNum2
            // 
            this.texNum2.BackColor = System.Drawing.Color.White;
            this.texNum2.Location = new System.Drawing.Point(164, 105);
            this.texNum2.Name = "texNum2";
            this.texNum2.Size = new System.Drawing.Size(100, 20);
            this.texNum2.TabIndex = 5;
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.Color.Transparent;
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.White;
            this.lblResult.Location = new System.Drawing.Point(109, 228);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(99, 20);
            this.lblResult.TabIndex = 6;
            this.lblResult.Text = "Resultado";
            // 
            // texResulta
            // 
            this.texResulta.BackColor = System.Drawing.Color.White;
            this.texResulta.Location = new System.Drawing.Point(214, 228);
            this.texResulta.Name = "texResulta";
            this.texResulta.Size = new System.Drawing.Size(174, 20);
            this.texResulta.TabIndex = 7;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnClear.Location = new System.Drawing.Point(280, 280);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(108, 31);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Limpiar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblDateTime
            // 
            this.lblDateTime.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.BackColor = System.Drawing.Color.Transparent;
            this.lblDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.ForeColor = System.Drawing.Color.White;
            this.lblDateTime.Location = new System.Drawing.Point(7, 9);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(0, 16);
            this.lblDateTime.TabIndex = 9;
            // 
            // tTime
            // 
            this.tTime.Tick += new System.EventHandler(this.tTime_Tick);
            // 
            // lblTime
            // 
            this.lblTime.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(492, 20);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(0, 16);
            this.lblTime.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkBlue;
            this.button1.Location = new System.Drawing.Point(532, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 29);
            this.button1.TabIndex = 11;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblSimbol
            // 
            this.lblSimbol.AutoSize = true;
            this.lblSimbol.BackColor = System.Drawing.Color.Transparent;
            this.lblSimbol.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSimbol.ForeColor = System.Drawing.Color.White;
            this.lblSimbol.Location = new System.Drawing.Point(267, 43);
            this.lblSimbol.Name = "lblSimbol";
            this.lblSimbol.Size = new System.Drawing.Size(0, 23);
            this.lblSimbol.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 393);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Powered By Ricardo Flores";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Ejericio_3.Properties.Resources.vector_fondo_matematico_geometrico_degradado_azul_educacion_remix_53876_114100;
            this.ClientSize = new System.Drawing.Size(626, 410);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSimbol);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.texResulta);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.texNum2);
            this.Controls.Add(this.texNum1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblNum2);
            this.Controls.Add(this.lblNum1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Caculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbDivision;
        private System.Windows.Forms.RadioButton rdbMulti;
        private System.Windows.Forms.RadioButton rdbResta;
        private System.Windows.Forms.RadioButton rbdSuma;
        private System.Windows.Forms.RadioButton rdbRaiz;
        private System.Windows.Forms.RadioButton rdbExponencial;
        private System.Windows.Forms.TextBox texNum1;
        private System.Windows.Forms.TextBox texNum2;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox texResulta;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Timer tTime;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.RadioButton rdbRaizCub;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblSimbol;
        private System.Windows.Forms.Label label1;
    }
}

