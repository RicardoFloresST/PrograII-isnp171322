namespace Ejercicio_3
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
            this.groupBoxVacunas = new System.Windows.Forms.GroupBox();
            this.chkNeumococo = new System.Windows.Forms.CheckBox();
            this.chkCoranaVirus = new System.Windows.Forms.CheckBox();
            this.chkTB = new System.Windows.Forms.CheckBox();
            this.chkInfluenza = new System.Windows.Forms.CheckBox();
            this.chkFiebremarilla = new System.Windows.Forms.CheckBox();
            this.chcHepatitis = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCRegistro = new System.Windows.Forms.TextBox();
            this.txtNombreC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grdDatosPacientes = new System.Windows.Forms.DataGridView();
            this.IdPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vacuna_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vacuna_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vacuna_3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vacuna_4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vacuna_5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vacuna_6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBuscarPaciente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxVacunas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatosPacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxVacunas
            // 
            this.groupBoxVacunas.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxVacunas.Controls.Add(this.chkNeumococo);
            this.groupBoxVacunas.Controls.Add(this.chkCoranaVirus);
            this.groupBoxVacunas.Controls.Add(this.chkTB);
            this.groupBoxVacunas.Controls.Add(this.chkInfluenza);
            this.groupBoxVacunas.Controls.Add(this.chkFiebremarilla);
            this.groupBoxVacunas.Controls.Add(this.chcHepatitis);
            this.groupBoxVacunas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxVacunas.Location = new System.Drawing.Point(217, 152);
            this.groupBoxVacunas.Name = "groupBoxVacunas";
            this.groupBoxVacunas.Size = new System.Drawing.Size(485, 157);
            this.groupBoxVacunas.TabIndex = 1;
            this.groupBoxVacunas.TabStop = false;
            this.groupBoxVacunas.Text = "Esquema de Vacunación";
            // 
            // chkNeumococo
            // 
            this.chkNeumococo.AutoSize = true;
            this.chkNeumococo.Location = new System.Drawing.Point(372, 109);
            this.chkNeumococo.Name = "chkNeumococo";
            this.chkNeumococo.Size = new System.Drawing.Size(102, 19);
            this.chkNeumococo.TabIndex = 11;
            this.chkNeumococo.Text = "Neumococo";
            this.chkNeumococo.UseVisualStyleBackColor = true;
            // 
            // chkCoranaVirus
            // 
            this.chkCoranaVirus.AutoSize = true;
            this.chkCoranaVirus.Location = new System.Drawing.Point(18, 109);
            this.chkCoranaVirus.Name = "chkCoranaVirus";
            this.chkCoranaVirus.Size = new System.Drawing.Size(104, 19);
            this.chkCoranaVirus.TabIndex = 10;
            this.chkCoranaVirus.Text = "CoranaVirus";
            this.chkCoranaVirus.UseVisualStyleBackColor = true;
            // 
            // chkTB
            // 
            this.chkTB.AutoSize = true;
            this.chkTB.Location = new System.Drawing.Point(194, 36);
            this.chkTB.Name = "chkTB";
            this.chkTB.Size = new System.Drawing.Size(43, 19);
            this.chkTB.TabIndex = 9;
            this.chkTB.Text = "TB";
            this.chkTB.UseVisualStyleBackColor = true;
            // 
            // chkInfluenza
            // 
            this.chkInfluenza.AutoSize = true;
            this.chkInfluenza.Location = new System.Drawing.Point(372, 36);
            this.chkInfluenza.Name = "chkInfluenza";
            this.chkInfluenza.Size = new System.Drawing.Size(85, 19);
            this.chkInfluenza.TabIndex = 8;
            this.chkInfluenza.Text = "Influenza";
            this.chkInfluenza.UseVisualStyleBackColor = true;
            // 
            // chkFiebremarilla
            // 
            this.chkFiebremarilla.AutoSize = true;
            this.chkFiebremarilla.Location = new System.Drawing.Point(194, 109);
            this.chkFiebremarilla.Name = "chkFiebremarilla";
            this.chkFiebremarilla.Size = new System.Drawing.Size(124, 19);
            this.chkFiebremarilla.TabIndex = 7;
            this.chkFiebremarilla.Text = "Fiebre Amarilla";
            this.chkFiebremarilla.UseVisualStyleBackColor = true;
            // 
            // chcHepatitis
            // 
            this.chcHepatitis.AutoSize = true;
            this.chcHepatitis.Location = new System.Drawing.Point(18, 36);
            this.chcHepatitis.Name = "chcHepatitis";
            this.chcHepatitis.Size = new System.Drawing.Size(96, 19);
            this.chcHepatitis.TabIndex = 6;
            this.chcHepatitis.Text = "Hepatitís B";
            this.chcHepatitis.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Codigo Registro:";
            // 
            // txtCRegistro
            // 
            this.txtCRegistro.Location = new System.Drawing.Point(217, 49);
            this.txtCRegistro.Name = "txtCRegistro";
            this.txtCRegistro.Size = new System.Drawing.Size(100, 20);
            this.txtCRegistro.TabIndex = 3;
            // 
            // txtNombreC
            // 
            this.txtNombreC.Location = new System.Drawing.Point(217, 94);
            this.txtNombreC.Name = "txtNombreC";
            this.txtNombreC.Size = new System.Drawing.Size(439, 20);
            this.txtNombreC.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre Completo:";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(235, 333);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 35);
            this.btnRegistrar.TabIndex = 6;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(347, 333);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 35);
            this.btnModificar.TabIndex = 7;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(467, 333);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 35);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(589, 333);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 35);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1034, 356);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Ejercicio_3.Properties.Resources.minsal;
            this.pictureBox2.Location = new System.Drawing.Point(724, 164);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(278, 132);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Ejercicio_3.Properties.Resources.Logotipo_vertical_azul1;
            this.pictureBox1.Location = new System.Drawing.Point(1023, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 132);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // grdDatosPacientes
            // 
            this.grdDatosPacientes.AllowUserToAddRows = false;
            this.grdDatosPacientes.AllowUserToDeleteRows = false;
            this.grdDatosPacientes.BackgroundColor = System.Drawing.Color.White;
            this.grdDatosPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDatosPacientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdPaciente,
            this.Codigo,
            this.NombreCompleto,
            this.vacuna_1,
            this.vacuna_2,
            this.vacuna_3,
            this.vacuna_4,
            this.vacuna_5,
            this.vacuna_6});
            this.grdDatosPacientes.Location = new System.Drawing.Point(-1, 422);
            this.grdDatosPacientes.Name = "grdDatosPacientes";
            this.grdDatosPacientes.ReadOnly = true;
            this.grdDatosPacientes.Size = new System.Drawing.Size(1154, 289);
            this.grdDatosPacientes.TabIndex = 13;
            this.grdDatosPacientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDatosPacientes_CellContentClick);
            // 
            // IdPaciente
            // 
            this.IdPaciente.DataPropertyName = "IdPaciente";
            this.IdPaciente.HeaderText = "IdPaciente";
            this.IdPaciente.Name = "IdPaciente";
            this.IdPaciente.ReadOnly = true;
            this.IdPaciente.Visible = false;
            this.IdPaciente.Width = 20;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "codigoPaciente";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // NombreCompleto
            // 
            this.NombreCompleto.DataPropertyName = "nombreCompleto";
            this.NombreCompleto.HeaderText = "Nombre Completo";
            this.NombreCompleto.Name = "NombreCompleto";
            this.NombreCompleto.ReadOnly = true;
            this.NombreCompleto.Width = 410;
            // 
            // vacuna_1
            // 
            this.vacuna_1.DataPropertyName = "vacuna_1";
            this.vacuna_1.HeaderText = "vacuna_1";
            this.vacuna_1.Name = "vacuna_1";
            this.vacuna_1.ReadOnly = true;
            // 
            // vacuna_2
            // 
            this.vacuna_2.DataPropertyName = "vacuna_2";
            this.vacuna_2.HeaderText = "vacuna_2";
            this.vacuna_2.Name = "vacuna_2";
            this.vacuna_2.ReadOnly = true;
            // 
            // vacuna_3
            // 
            this.vacuna_3.DataPropertyName = "vacuna_3";
            this.vacuna_3.HeaderText = "vacuna_3";
            this.vacuna_3.Name = "vacuna_3";
            this.vacuna_3.ReadOnly = true;
            // 
            // vacuna_4
            // 
            this.vacuna_4.DataPropertyName = "vacuna_4";
            this.vacuna_4.HeaderText = "vacuna_4";
            this.vacuna_4.Name = "vacuna_4";
            this.vacuna_4.ReadOnly = true;
            // 
            // vacuna_5
            // 
            this.vacuna_5.DataPropertyName = "vacuna_5";
            this.vacuna_5.HeaderText = "vacuna_5";
            this.vacuna_5.Name = "vacuna_5";
            this.vacuna_5.ReadOnly = true;
            // 
            // vacuna_6
            // 
            this.vacuna_6.DataPropertyName = "vacuna_6";
            this.vacuna_6.HeaderText = "vacuna_6";
            this.vacuna_6.Name = "vacuna_6";
            this.vacuna_6.ReadOnly = true;
            // 
            // txtBuscarPaciente
            // 
            this.txtBuscarPaciente.Location = new System.Drawing.Point(125, 394);
            this.txtBuscarPaciente.Name = "txtBuscarPaciente";
            this.txtBuscarPaciente.Size = new System.Drawing.Size(297, 20);
            this.txtBuscarPaciente.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 394);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Buscar Registro";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Ejercicio_3.Properties.Resources.pngtree_the_vaccine_covid_19_image_1297467;
            this.ClientSize = new System.Drawing.Size(1153, 713);
            this.Controls.Add(this.txtBuscarPaciente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.grdDatosPacientes);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtNombreC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCRegistro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxVacunas);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxVacunas.ResumeLayout(false);
            this.groupBoxVacunas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatosPacientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxVacunas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCRegistro;
        private System.Windows.Forms.TextBox txtNombreC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView grdDatosPacientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn vacuna_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn vacuna_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn vacuna_3;
        private System.Windows.Forms.DataGridViewTextBoxColumn vacuna_4;
        private System.Windows.Forms.DataGridViewTextBoxColumn vacuna_5;
        private System.Windows.Forms.DataGridViewTextBoxColumn vacuna_6;
        private System.Windows.Forms.TextBox txtBuscarPaciente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chcHepatitis;
        private System.Windows.Forms.CheckBox chkNeumococo;
        private System.Windows.Forms.CheckBox chkCoranaVirus;
        private System.Windows.Forms.CheckBox chkTB;
        private System.Windows.Forms.CheckBox chkInfluenza;
        private System.Windows.Forms.CheckBox chkFiebremarilla;
    }
}

