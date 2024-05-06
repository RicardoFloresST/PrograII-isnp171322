using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_3
{
    public partial class Form1 : Form
    {
        Conexion objConexion = new Conexion();
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();

        int posicion = 0;
        string accion = "Nuevo Registro";

        public Form1()
        {
            InitializeComponent();
        }

        private void actualizarDatosPacientes()
        {
            ds.Clear();
            ds = objConexion.ObtenerDatos();
            dt = ds.Tables["VacunasPacientes"];
            dt.PrimaryKey = new DataColumn[] { dt.Columns["IdPaciente"] };
            // Asignar el origen de datos al DataGridView
            grdDatosPacientes.DataSource = dt;
        }

        private string ObtenerOpcionSeleccionada()
        {
            string opcionesSeleccionadas = "";

            foreach (Control control in groupBoxVacunas.Controls)
            {
                if (control is CheckBox checkBox && checkBox.Checked)
                {
                    opcionesSeleccionadas += checkBox.Text + ", ";
                }
            }

            if (!string.IsNullOrEmpty(opcionesSeleccionadas))
            {
                opcionesSeleccionadas = opcionesSeleccionadas.TrimEnd(',', ' ');
            }

            return opcionesSeleccionadas;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string vacunasSeleccionadas = ObtenerOpcionSeleccionada();
            string codigoPaciente = txtCRegistro.Text;
            string nombreCompleto = txtNombreC.Text;

            GuardarRegistroEnBaseDeDatos(vacunasSeleccionadas, codigoPaciente, nombreCompleto);
            actualizarDatosPacientes();

            MessageBox.Show($"Se ha registrado al paciente {nombreCompleto} con el código {codigoPaciente} y las vacunas {vacunasSeleccionadas}.", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void GuardarRegistroEnBaseDeDatos(string vacunasSeleccionadas, string codigoPaciente, string nombreCompleto)
        {
            string connectionString = "Tu cadena de conexión";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO VacunasPacientes (codigoPaciente, nombreCompleto, vacunas) VALUES (@CodigoPaciente, @NombreCompleto, @VacunasSeleccionadas)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CodigoPaciente", codigoPaciente);
                        command.Parameters.AddWithValue("@NombreCompleto", nombreCompleto);
                        command.Parameters.AddWithValue("@VacunasSeleccionadas", vacunasSeleccionadas);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción aquí, por ejemplo, mostrando un mensaje de error
                Console.WriteLine("Error al abrir la conexión: " + ex.Message);
            }
            }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string codigoPaciente = txtCRegistro.Text;
            string nombreCompleto = txtNombreC.Text;
            string vacunasSeleccionadas = ObtenerOpcionSeleccionada();

            ActualizarRegistroEnBaseDeDatos(vacunasSeleccionadas, codigoPaciente, nombreCompleto);

            MessageBox.Show($"Se ha modificado la información del paciente {nombreCompleto} con el código {codigoPaciente}.", "Modificación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ActualizarRegistroEnBaseDeDatos(string vacunasSeleccionadas, string codigoPaciente, string nombreCompleto)
        {
            string connectionString = "Tu cadena de conexión";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE VacunasPacientes SET vacunas = @VacunasSeleccionadas WHERE codigoPaciente = @CodigoPaciente";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@VacunasSeleccionadas", vacunasSeleccionadas);
                    command.Parameters.AddWithValue("@CodigoPaciente", codigoPaciente);
                    command.ExecuteNonQuery();
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string codigoPaciente = txtCRegistro.Text;
            EliminarRegistroDeBaseDeDatos(codigoPaciente);
            MessageBox.Show($"Se ha eliminado al paciente con el código {codigoPaciente}.", "Eliminación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void EliminarRegistroDeBaseDeDatos(string codigoPaciente)
        {
            string connectionString = "Tu cadena de conexión";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM VacunasPacientes WHERE codigoPaciente = @CodigoPaciente";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CodigoPaciente", codigoPaciente);
                    command.ExecuteNonQuery();
                }
            }
        }

        private void txtBuscarPaciente_TextChanged(object sender, EventArgs e)
        {
            filtrarDatosPacientes(txtBuscarPaciente.Text);
        }

        private void filtrarDatosPacientes(string valor)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = grdDatosPacientes.DataSource;
            bs.Filter = "Codigo like '%" + valor + "%' OR NombreCompleto like '%" + valor + "%' ";
            grdDatosPacientes.DataSource = bs;
        }

        private void seleccionarPaciente()
        {
            int _idPaciente = int.Parse(grdDatosPacientes.CurrentRow.Cells["IdPaciente"].Value.ToString());
            posicion = dt.Rows.IndexOf(dt.Rows.Find(_idPaciente));
        }

        private void grdDatosPacientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionarPaciente();
        }

        private void txtBuscarPaciente_KeyUp(object sender, KeyEventArgs e)
        {
            filtrarDatosPacientes(txtBuscarPaciente.Text);
            if (e.KeyCode == Keys.Enter)
            {
                seleccionarPaciente();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtCRegistro.Text = "";
            txtNombreC.Text = "";

            // Desmarca todos los checkboxes
            foreach (Control control in groupBoxVacunas.Controls)
            {
                if (control is CheckBox checkBox)
                {
                    checkBox.Checked = false;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            actualizarDatosPacientes();
        }

        private void grdDatosPacientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < grdDatosPacientes.Rows.Count)
            {
                DataGridViewRow selectedRow = grdDatosPacientes.Rows[e.RowIndex];

                // Obtener los valores de las celdas seleccionadas
                string codigoPaciente = selectedRow.Cells["codigoPaciente"].Value.ToString();
                string nombreCompleto = selectedRow.Cells["nombreCompleto"].Value.ToString();
                // Asignar los valores a los TextBox correspondientes
                txtCRegistro.Text = codigoPaciente;
                txtNombreC.Text = nombreCompleto;

                // Marcar las vacunas correspondientes en los CheckBox
                for (int i = 0; i < selectedRow.Cells.Count; i++)
                {
                    if (selectedRow.Cells[i].Value != null && selectedRow.Cells[i].Value.ToString() != string.Empty)
                    {
                        // Aquí debes verificar si el nombre de la columna es una vacuna
                        // Puedes hacerlo comparando el nombre de la columna con los nombres de tus vacunas
                        // Por ejemplo:
                        string columnName = grdDatosPacientes.Columns[i].Name;
                        if (columnName.StartsWith("vacuna_"))
                        {
                            string vacuna = selectedRow.Cells[i].Value.ToString();
                            // Aquí buscas el CheckBox correspondiente al nombre de la vacuna
                            // y lo marcas si lo encuentras
                            foreach (Control control in groupBoxVacunas.Controls)
                            {
                                if (control is CheckBox checkBox && checkBox.Text == vacuna)
                                {
                                    checkBox.Checked = true;
                                    break;
                                }
                            }
                        }
                    }
                }
            }
        }
    }
    }

