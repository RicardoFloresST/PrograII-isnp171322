using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_1
{
    public partial class PromedioEstudiante : Form
    {
        Conexion objConexion = new Conexion();
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();

        int posicion = 0;
        String accion = "Nuevo Registro";

        public PromedioEstudiante()
        {
            InitializeComponent();
        }
        
        private void actualizarDsEstudiantes()
        { 
            ds.Clear();
            ds = objConexion.ObtenerDatos();
            dt = ds.Tables["Estudiantes"];
            dt.PrimaryKey = new DataColumn[] { dt.Columns["IdEstudiante"] };
            mostrarDatosEstudiantes();

        }

        private void mostrarDatosEstudiantes() {
        if(dt.Rows.Count > 0) {
                txtCodigo.Text = dt.Rows[posicion][1].ToString();
                txtNombres.Text = dt.Rows[posicion][2].ToString();
                txtEdad.Text = dt.Rows[posicion][3].ToString();
                txtSexo.Text = dt.Rows[posicion][4].ToString();
                txtLab1.Text = dt.Rows[posicion][5].ToString();
                txtLab2.Text = dt.Rows[posicion][6].ToString();
                txtParcial.Text = dt.Rows[posicion][7].ToString();
                txtPromedio.Text = dt.Rows[posicion][8].ToString();
                txtPorcent30_1.Text = "30";
                txtPorcent30_2.Text = "30";
                txtPorcent40.Text = "40";
                txtMate.Text = "Programación II";
                txtYear.Text = "2024";

                lblNResgistroAlumno.Text = (posicion + 1) + " de " + dt.Rows.Count.ToString();
            } else {
                lblNResgistroAlumno.Text = "0 de 0";
                limpiarCajas();
            }
        }

        private void limpiarCajas() {
            txtCodigo.Text = "";
            txtNombres.Text = "";
            txtEdad.Text = "";
            txtSexo.Text = "";
            txtLab1.Text = "";
            txtLab2.Text = "";
            txtParcial.Text = "";
            txtPromedio.Text = "";
        }
       

        private void PromedioEstudiante_Load(object sender, EventArgs e)
        {
            actualizarDsEstudiantes();

        }

        private void btnCalcuPromedio_Click(object sender, EventArgs e)
        {
            // Obtener las notas de los campos de texto
            double lab1 = Convert.ToDouble(txtLab1.Text);
            double lab2 = Convert.ToDouble(txtLab2.Text);
            double parcial = Convert.ToDouble(txtParcial.Text);

            // Definir los porcentajes de cada nota
            double porcentajeLab1 = 0.30;
            double porcentajeLab2 = 0.30;
            double porcentajeParcial = 0.40;

            // Calcular el promedio ponderado
            double promedio = (lab1 * porcentajeLab1) + (lab2 * porcentajeLab2) + (parcial * porcentajeParcial);

            // Mostrar el promedio en el campo de texto
            txtPromedio.Text = promedio.ToString();
          }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (posicion <dt.Rows.Count-1) {
                posicion++;
                mostrarDatosEstudiantes();
            } else {
                MessageBox.Show("No hay mas Registros", "Navegaión de Estudiantes", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (posicion > 0)
            {
                posicion--;
                mostrarDatosEstudiantes();
            }
            else
            {
                MessageBox.Show("Estas en el Primer Registro", "Navegaión de Estudiantes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(btnAgregar.Text == "Agregar") {// Creando un nuevo registro
                btnAgregar.Text = "Guardar";
                btnEditar.Text = "Cancelar";
            }
            else
            { // Guardar datos
                btnAgregar.Text = "agregar";
                btnEditar.Text = "Editar";
                limpiarCajas();
            
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (btnEditar.Text == "Editar") {// Modificando un registro
                btnAgregar.Text = "Guardar";
                btnEditar.Text = "Cancelar";
            }
            else
            { // Cancelar
                btnAgregar.Text = "agregar";
                btnEditar.Text = "Editar";

            }
        }
    }
}





