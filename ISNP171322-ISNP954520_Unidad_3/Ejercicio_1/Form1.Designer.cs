namespace Ejercicio_1
{
    partial class PromedioEstudiante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PromedioEstudiante));
            this.grbNavegacion = new System.Windows.Forms.GroupBox();
            this.lblNResgistroEstudiantes = new System.Windows.Forms.Label();
            this.grbEditarControl = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txtSexo = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtPromedio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMate = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.txtPorcent30_2 = new System.Windows.Forms.TextBox();
            this.txtPorcent40 = new System.Windows.Forms.TextBox();
            this.txtPorcent30_1 = new System.Windows.Forms.TextBox();
            this.txtLab2 = new System.Windows.Forms.TextBox();
            this.txtParcial = new System.Windows.Forms.TextBox();
            this.txtLab1 = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grbFichaEstudiante = new System.Windows.Forms.GroupBox();
            this.btnCalcuPromedio = new System.Windows.Forms.Button();
            this.grdDatosEstudiantes = new System.Windows.Forms.DataGridView();
            this.IdEstudiante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NotaLab1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NotaLab2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NotaParcial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Promedio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label16 = new System.Windows.Forms.Label();
            this.txtBuscarEstudiante = new System.Windows.Forms.TextBox();
            this.btnNext = new Ejercicio_1.BotonCircular();
            this.btnBack = new Ejercicio_1.BotonCircular();
            this.grbNavegacion.SuspendLayout();
            this.grbEditarControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.grbFichaEstudiante.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatosEstudiantes)).BeginInit();
            this.SuspendLayout();
            // 
            // grbNavegacion
            // 
            this.grbNavegacion.Controls.Add(this.lblNResgistroEstudiantes);
            this.grbNavegacion.Controls.Add(this.btnNext);
            this.grbNavegacion.Controls.Add(this.btnBack);
            this.grbNavegacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbNavegacion.Location = new System.Drawing.Point(54, 399);
            this.grbNavegacion.Name = "grbNavegacion";
            this.grbNavegacion.Size = new System.Drawing.Size(377, 100);
            this.grbNavegacion.TabIndex = 73;
            this.grbNavegacion.TabStop = false;
            this.grbNavegacion.Text = "Navegación";
            // 
            // lblNResgistroEstudiantes
            // 
            this.lblNResgistroEstudiantes.AutoSize = true;
            this.lblNResgistroEstudiantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNResgistroEstudiantes.Location = new System.Drawing.Point(159, 44);
            this.lblNResgistroEstudiantes.Name = "lblNResgistroEstudiantes";
            this.lblNResgistroEstudiantes.Size = new System.Drawing.Size(53, 18);
            this.lblNResgistroEstudiantes.TabIndex = 74;
            this.lblNResgistroEstudiantes.Text = "x de n";
            // 
            // grbEditarControl
            // 
            this.grbEditarControl.Controls.Add(this.btnEliminar);
            this.grbEditarControl.Controls.Add(this.btnAgregar);
            this.grbEditarControl.Controls.Add(this.btnEditar);
            this.grbEditarControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbEditarControl.Location = new System.Drawing.Point(659, 399);
            this.grbEditarControl.Name = "grbEditarControl";
            this.grbEditarControl.Size = new System.Drawing.Size(377, 100);
            this.grbEditarControl.TabIndex = 72;
            this.grbEditarControl.TabStop = false;
            this.grbEditarControl.Text = "Edición";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(244, 34);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 40);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(48, 34);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 40);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(141, 34);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 40);
            this.btnEditar.TabIndex = 13;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txtSexo
            // 
            this.txtSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSexo.Location = new System.Drawing.Point(154, 153);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.Size = new System.Drawing.Size(100, 21);
            this.txtSexo.TabIndex = 71;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Cooper Std Black", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(12, 30);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(488, 42);
            this.label14.TabIndex = 70;
            this.label14.Text = "Registros De Estudiantes";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Ejercicio_1.Properties.Resources.Logotipo_horizontal_blanco1;
            this.pictureBox1.Location = new System.Drawing.Point(939, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 79);
            this.pictureBox1.TabIndex = 69;
            this.pictureBox1.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(98, 156);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 15);
            this.label13.TabIndex = 68;
            this.label13.Text = "Sexo:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.txtEstado);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.txtPromedio);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtYear);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtMate);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Location = new System.Drawing.Point(1006, 124);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(155, 221);
            this.panel1.TabIndex = 67;
            // 
            // txtEstado
            // 
            this.txtEstado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEstado.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstado.Location = new System.Drawing.Point(0, 98);
            this.txtEstado.Multiline = true;
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.ReadOnly = true;
            this.txtEstado.Size = new System.Drawing.Size(154, 27);
            this.txtEstado.TabIndex = 42;
            this.txtEstado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.SystemColors.Menu;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(51, 82);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 15);
            this.label15.TabIndex = 41;
            this.label15.Text = "Estado";
            // 
            // txtPromedio
            // 
            this.txtPromedio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPromedio.Font = new System.Drawing.Font("Cooper Black", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPromedio.Location = new System.Drawing.Point(0, 21);
            this.txtPromedio.Multiline = true;
            this.txtPromedio.Name = "txtPromedio";
            this.txtPromedio.ReadOnly = true;
            this.txtPromedio.Size = new System.Drawing.Size(154, 59);
            this.txtPromedio.TabIndex = 36;
            this.txtPromedio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Menu;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Promedio";
            // 
            // txtYear
            // 
            this.txtYear.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtYear.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYear.Location = new System.Drawing.Point(0, 192);
            this.txtYear.Multiline = true;
            this.txtYear.Name = "txtYear";
            this.txtYear.ReadOnly = true;
            this.txtYear.Size = new System.Drawing.Size(154, 27);
            this.txtYear.TabIndex = 37;
            this.txtYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Menu;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(61, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Año";
            // 
            // txtMate
            // 
            this.txtMate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMate.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMate.Location = new System.Drawing.Point(0, 142);
            this.txtMate.Multiline = true;
            this.txtMate.Name = "txtMate";
            this.txtMate.ReadOnly = true;
            this.txtMate.Size = new System.Drawing.Size(154, 31);
            this.txtMate.TabIndex = 38;
            this.txtMate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Menu;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(50, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "Materia";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox5.Location = new System.Drawing.Point(0, 3);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(155, 218);
            this.textBox5.TabIndex = 74;
            // 
            // txtPorcent30_2
            // 
            this.txtPorcent30_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPorcent30_2.Location = new System.Drawing.Point(911, 77);
            this.txtPorcent30_2.Name = "txtPorcent30_2";
            this.txtPorcent30_2.ReadOnly = true;
            this.txtPorcent30_2.Size = new System.Drawing.Size(53, 21);
            this.txtPorcent30_2.TabIndex = 66;
            this.txtPorcent30_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPorcent40
            // 
            this.txtPorcent40.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPorcent40.Location = new System.Drawing.Point(911, 119);
            this.txtPorcent40.Name = "txtPorcent40";
            this.txtPorcent40.ReadOnly = true;
            this.txtPorcent40.Size = new System.Drawing.Size(53, 21);
            this.txtPorcent40.TabIndex = 65;
            this.txtPorcent40.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPorcent30_1
            // 
            this.txtPorcent30_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPorcent30_1.Location = new System.Drawing.Point(911, 37);
            this.txtPorcent30_1.Name = "txtPorcent30_1";
            this.txtPorcent30_1.ReadOnly = true;
            this.txtPorcent30_1.Size = new System.Drawing.Size(53, 21);
            this.txtPorcent30_1.TabIndex = 64;
            this.txtPorcent30_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLab2
            // 
            this.txtLab2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLab2.Location = new System.Drawing.Point(813, 77);
            this.txtLab2.Name = "txtLab2";
            this.txtLab2.Size = new System.Drawing.Size(53, 21);
            this.txtLab2.TabIndex = 63;
            this.txtLab2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtParcial
            // 
            this.txtParcial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParcial.Location = new System.Drawing.Point(813, 119);
            this.txtParcial.Name = "txtParcial";
            this.txtParcial.Size = new System.Drawing.Size(53, 21);
            this.txtParcial.TabIndex = 62;
            this.txtParcial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLab1
            // 
            this.txtLab1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLab1.Location = new System.Drawing.Point(813, 37);
            this.txtLab1.Name = "txtLab1";
            this.txtLab1.Size = new System.Drawing.Size(53, 21);
            this.txtLab1.TabIndex = 61;
            this.txtLab1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNombres
            // 
            this.txtNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombres.Location = new System.Drawing.Point(154, 63);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(417, 21);
            this.txtNombres.TabIndex = 60;
            // 
            // txtEdad
            // 
            this.txtEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdad.Location = new System.Drawing.Point(154, 109);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(47, 21);
            this.txtEdad.TabIndex = 59;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(154, 23);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 21);
            this.txtCodigo.TabIndex = 58;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(676, 40);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(131, 15);
            this.label12.TabIndex = 57;
            this.label12.Text = "Nota Laboratorio 1:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(14, 63);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 15);
            this.label11.TabIndex = 56;
            this.label11.Text = "Nombre Completo:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(85, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 15);
            this.label10.TabIndex = 55;
            this.label10.Text = "Código:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(882, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 15);
            this.label7.TabIndex = 54;
            this.label7.Text = "%";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(882, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 15);
            this.label6.TabIndex = 53;
            this.label6.Text = "%";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(882, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 15);
            this.label5.TabIndex = 52;
            this.label5.Text = "%";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(676, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 15);
            this.label4.TabIndex = 51;
            this.label4.Text = "Nota Laboratorio 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(717, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 15);
            this.label3.TabIndex = 50;
            this.label3.Text = "Nota Parcial:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(97, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 49;
            this.label2.Text = "Edad:";
            // 
            // grbFichaEstudiante
            // 
            this.grbFichaEstudiante.Controls.Add(this.txtCodigo);
            this.grbFichaEstudiante.Controls.Add(this.label2);
            this.grbFichaEstudiante.Controls.Add(this.label10);
            this.grbFichaEstudiante.Controls.Add(this.label11);
            this.grbFichaEstudiante.Controls.Add(this.txtSexo);
            this.grbFichaEstudiante.Controls.Add(this.txtEdad);
            this.grbFichaEstudiante.Controls.Add(this.txtNombres);
            this.grbFichaEstudiante.Controls.Add(this.txtPorcent30_2);
            this.grbFichaEstudiante.Controls.Add(this.txtPorcent40);
            this.grbFichaEstudiante.Controls.Add(this.label13);
            this.grbFichaEstudiante.Controls.Add(this.txtPorcent30_1);
            this.grbFichaEstudiante.Controls.Add(this.txtLab1);
            this.grbFichaEstudiante.Controls.Add(this.label7);
            this.grbFichaEstudiante.Controls.Add(this.label3);
            this.grbFichaEstudiante.Controls.Add(this.label6);
            this.grbFichaEstudiante.Controls.Add(this.txtLab2);
            this.grbFichaEstudiante.Controls.Add(this.label5);
            this.grbFichaEstudiante.Controls.Add(this.label4);
            this.grbFichaEstudiante.Controls.Add(this.txtParcial);
            this.grbFichaEstudiante.Controls.Add(this.label12);
            this.grbFichaEstudiante.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbFichaEstudiante.Location = new System.Drawing.Point(0, 117);
            this.grbFichaEstudiante.Name = "grbFichaEstudiante";
            this.grbFichaEstudiante.Size = new System.Drawing.Size(1000, 228);
            this.grbFichaEstudiante.TabIndex = 74;
            this.grbFichaEstudiante.TabStop = false;
            this.grbFichaEstudiante.Text = "Ficha Estudiante";
            // 
            // btnCalcuPromedio
            // 
            this.btnCalcuPromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcuPromedio.Location = new System.Drawing.Point(751, 361);
            this.btnCalcuPromedio.Name = "btnCalcuPromedio";
            this.btnCalcuPromedio.Size = new System.Drawing.Size(124, 27);
            this.btnCalcuPromedio.TabIndex = 15;
            this.btnCalcuPromedio.Text = "Calcular Promedio";
            this.btnCalcuPromedio.UseVisualStyleBackColor = true;
            this.btnCalcuPromedio.Click += new System.EventHandler(this.btnCalcuPromedio_Click);
            // 
            // grdDatosEstudiantes
            // 
            this.grdDatosEstudiantes.AllowUserToAddRows = false;
            this.grdDatosEstudiantes.AllowUserToDeleteRows = false;
            this.grdDatosEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDatosEstudiantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdEstudiante,
            this.Codigo,
            this.NombreCompleto,
            this.Edad,
            this.Sexo,
            this.NotaLab1,
            this.NotaLab2,
            this.NotaParcial,
            this.Promedio,
            this.Estado});
            this.grdDatosEstudiantes.Location = new System.Drawing.Point(0, 541);
            this.grdDatosEstudiantes.Name = "grdDatosEstudiantes";
            this.grdDatosEstudiantes.ReadOnly = true;
            this.grdDatosEstudiantes.Size = new System.Drawing.Size(1193, 293);
            this.grdDatosEstudiantes.TabIndex = 75;
            this.grdDatosEstudiantes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDatosEstudiantes_CellClick);
            // 
            // IdEstudiante
            // 
            this.IdEstudiante.DataPropertyName = "IdEstudiante";
            this.IdEstudiante.HeaderText = "IdEstudiante";
            this.IdEstudiante.Name = "IdEstudiante";
            this.IdEstudiante.ReadOnly = true;
            this.IdEstudiante.Visible = false;
            this.IdEstudiante.Width = 5;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "CODIGO";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // NombreCompleto
            // 
            this.NombreCompleto.DataPropertyName = "NombreCompleto";
            this.NombreCompleto.HeaderText = "NOMBRE";
            this.NombreCompleto.Name = "NombreCompleto";
            this.NombreCompleto.ReadOnly = true;
            this.NombreCompleto.Width = 410;
            // 
            // Edad
            // 
            this.Edad.DataPropertyName = "Edad";
            this.Edad.HeaderText = "EDAD";
            this.Edad.Name = "Edad";
            this.Edad.ReadOnly = true;
            this.Edad.Width = 60;
            // 
            // Sexo
            // 
            this.Sexo.DataPropertyName = "Sexo";
            this.Sexo.HeaderText = "SEXO";
            this.Sexo.Name = "Sexo";
            this.Sexo.ReadOnly = true;
            this.Sexo.Width = 80;
            // 
            // NotaLab1
            // 
            this.NotaLab1.DataPropertyName = "NotaLab1";
            this.NotaLab1.HeaderText = "NOTA LAB1";
            this.NotaLab1.Name = "NotaLab1";
            this.NotaLab1.ReadOnly = true;
            // 
            // NotaLab2
            // 
            this.NotaLab2.DataPropertyName = "NotaLab2";
            this.NotaLab2.HeaderText = "NOTA LAB 2";
            this.NotaLab2.Name = "NotaLab2";
            this.NotaLab2.ReadOnly = true;
            // 
            // NotaParcial
            // 
            this.NotaParcial.DataPropertyName = "NotaParcial";
            this.NotaParcial.HeaderText = "NOTA PARCIAL";
            this.NotaParcial.Name = "NotaParcial";
            this.NotaParcial.ReadOnly = true;
            this.NotaParcial.Width = 120;
            // 
            // Promedio
            // 
            this.Promedio.DataPropertyName = "Promedio";
            this.Promedio.HeaderText = "PROMEDIO";
            this.Promedio.Name = "Promedio";
            this.Promedio.ReadOnly = true;
            this.Promedio.Width = 80;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(5, 514);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(127, 15);
            this.label16.TabIndex = 76;
            this.label16.Text = "Buscar Estudiante:";
            // 
            // txtBuscarEstudiante
            // 
            this.txtBuscarEstudiante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarEstudiante.Location = new System.Drawing.Point(143, 514);
            this.txtBuscarEstudiante.Name = "txtBuscarEstudiante";
            this.txtBuscarEstudiante.Size = new System.Drawing.Size(408, 21);
            this.txtBuscarEstudiante.TabIndex = 77;
            this.txtBuscarEstudiante.TextChanged += new System.EventHandler(this.txtBuscarEstudiante_TextChanged);
            this.txtBuscarEstudiante.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscarEstudiante_KeyUp);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.ForeColor = System.Drawing.Color.Transparent;
            this.btnNext.Image = global::Ejercicio_1.Properties.Resources.next1;
            this.btnNext.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnNext.Location = new System.Drawing.Point(61, 26);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(59, 57);
            this.btnNext.TabIndex = 49;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ForeColor = System.Drawing.Color.Transparent;
            this.btnBack.Image = global::Ejercicio_1.Properties.Resources._1back;
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnBack.Location = new System.Drawing.Point(256, 26);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(59, 57);
            this.btnBack.TabIndex = 0;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // PromedioEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1194, 834);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtBuscarEstudiante);
            this.Controls.Add(this.grdDatosEstudiantes);
            this.Controls.Add(this.grbFichaEstudiante);
            this.Controls.Add(this.btnCalcuPromedio);
            this.Controls.Add(this.grbNavegacion);
            this.Controls.Add(this.grbEditarControl);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PromedioEstudiante";
            this.Text = "Promedio Estudiantes";
            this.Load += new System.EventHandler(this.PromedioEstudiante_Load);
            this.grbNavegacion.ResumeLayout(false);
            this.grbNavegacion.PerformLayout();
            this.grbEditarControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grbFichaEstudiante.ResumeLayout(false);
            this.grbFichaEstudiante.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatosEstudiantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbNavegacion;
        private BotonCircular btnNext;
        private BotonCircular btnBack;
        private System.Windows.Forms.GroupBox grbEditarControl;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txtSexo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPromedio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPorcent30_2;
        private System.Windows.Forms.TextBox txtPorcent40;
        private System.Windows.Forms.TextBox txtPorcent30_1;
        private System.Windows.Forms.TextBox txtLab2;
        private System.Windows.Forms.TextBox txtParcial;
        private System.Windows.Forms.TextBox txtLab1;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNResgistroEstudiantes;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.GroupBox grbFichaEstudiante;
        private System.Windows.Forms.Button btnCalcuPromedio;
        private System.Windows.Forms.DataGridView grdDatosEstudiantes;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEstudiante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NotaLab1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NotaLab2;
        private System.Windows.Forms.DataGridViewTextBoxColumn NotaParcial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Promedio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtBuscarEstudiante;
    }
}

