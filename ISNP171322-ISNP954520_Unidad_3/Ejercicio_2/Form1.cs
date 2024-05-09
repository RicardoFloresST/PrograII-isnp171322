using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_2
{
    public partial class Form1 : Form
    {
        private conexion objConexion = new conexion();
        private DataSet ds = new DataSet();
        private DataTable dt = new DataTable();
        private int posicion = 0;
        private string accion = "Nuevo Registro";

        public Form1()
        {
            InitializeComponent();
        }

        private void actualizarDsPersonas()
        {
            try
            {
                ds.Clear();
                ds = objConexion.ObtenerDatos();
                dt = ds.Tables["agendaPersonas"];
                dt.PrimaryKey = new DataColumn[] { dt.Columns["IdPersona"] };
                mostrarDatosPersonas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mostrarDatosPersonas()
        {
            if (dt.Rows.Count > 0)
            {
                txtNombre.Text = dt.Rows[posicion]["nombreCompleto"].ToString();
                txtTexto.Text = dt.Rows[posicion]["texto"].ToString();
                dtpFecha.Value = Convert.ToDateTime(dt.Rows[posicion]["fechaCreacion"]);

                lblNResgistroPersonas.Text = (posicion + 1) + " de " + dt.Rows.Count.ToString();
            }
            else
            {
                lblNResgistroPersonas.Text = "0 de 0";
                limpiarCajas();
            }
        }

        private void limpiarCajas()
        {
            txtNombre.Text = "";
            txtTexto.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
            actualizarDsPersonas();
            grdDatosPersonas.DataSource = dt.DefaultView;
           
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (posicion < dt.Rows.Count - 1)
            {
                posicion++;
                Console.WriteLine(txtNombre.Text); // Agregar aquí
                mostrarDatosPersonas();
            }
            else
            {
                MessageBox.Show("No hay mas Registros", "Navegaión de Personas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (posicion > 0)
            {
                posicion--;
                Console.WriteLine(txtNombre.Text); // Agregar aquí
                mostrarDatosPersonas();
            }
            else
            {
                MessageBox.Show("Estas en el Primer Registro", "Navegaión de Personas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            

            if (btnAgregar.Text == "Agregar")

            { //Agregando un nueva Persona
                limpiarCajas();
                //Cambiar el texto del botón a guardar
                btnAgregar.Text = "Guardar";
                btnEditar.Text = "Cancelar";
                activarDesactivarControles(false);
                accion = "Nuevo Registro";

            }
            else
            {// Verificar si los campos de notas están vacíos
                if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtTexto.Text))
                {
                    MessageBox.Show("Por favor, llene todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {//Guardando un nueva Persona
                    if (dt.Rows.Count > 0 && posicion < dt.Rows.Count)
                    {
                        String[] agendaPersonas = new String[] {
                         dt.Rows[posicion].ItemArray[0].ToString(), // IdEstudiante
                         txtNombre.Text,
                         txtTexto.Text,
                         dtpFecha.Value.ToString("dd/MM/yyyy")
                    };
                        String Resp = objConexion.InsertarDatos(agendaPersonas, accion);
                        if (Resp != "1")
                        {
                            MessageBox.Show("Error al intentar guardar el registro: " + Resp, "Edición de Estudiantes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            actualizarDsPersonas();
                            mostrarDatosPersonas();
                            activarDesactivarControles(true);
                            btnAgregar.Text = "Agregar";
                            btnEditar.Text = "Editar";
                        }                      
                    }
                    else
                    {
                        MessageBox.Show("No hay Personas disponibles para realizar esta operación.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }

                }

            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (btnEditar.Text == "Editar")
    {
        btnAgregar.Text = "Guardar";
        btnEditar.Text = "Cancelar";
        activarDesactivarControles(false);
        accion = "Editar Registro";
    }
    else
    {
        // Verificar si se está editando una persona
        if (accion == "Editar Registro")
        {
            // Mostrar los datos originales de la persona
            mostrarDatosPersonas();
            activarDesactivarControles(true);
            btnAgregar.Text = "Agregar";
            btnEditar.Text = "Editar";
        }
        else
        {
            // Si se está agregando una nueva persona, limpiar los campos y restablecer el formulario
            limpiarCajas();
            btnAgregar.Text = "Agregar";
            btnEditar.Text = "Editar";
            activarDesactivarControles(true);
        }
    }
}
        private void activarDesactivarControles(Boolean estado)
        {
            grbDatosPersonas.Enabled = !estado;
            grbNavegacion.Enabled = estado;
            btnEliminar.Enabled = estado;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Preguntar al usuario si está seguro de eliminar a la persona
            DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar a " + txtNombre.Text + "?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Verificar la respuesta del usuario
            if (result == DialogResult.Yes)
            {
                // Si el usuario confirma la eliminación, proceder con la eliminación de la persona
                String Resp = objConexion.InsertarDatos(new String[] {
            dt.Rows[posicion].ItemArray[0].ToString()
        }, "Eliminar Registro");

                // Mostrar un mensaje de éxito si la eliminación fue exitosa
                if (Resp == "1")
                {
                    MessageBox.Show(txtNombre.Text + " ha sido eliminado exitosamente.", "Eliminación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    actualizarDsPersonas();
                }
                else
                {
                    MessageBox.Show("Error al intentar eliminar a la persona: " + Resp, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Si el usuario cancela la eliminación, mostrar un mensaje de que no se realizó la eliminación
                MessageBox.Show(txtNombre.Text + " no ha sido borrado.", "Eliminación cancelada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            filtrarDatosPersonas(txtBuscar.Text);
        }

        private void filtrarDatosPersonas(String valor) {
            BindingSource bs = new BindingSource();
            bs.DataSource = grdDatosPersonas.DataSource;
            bs.Filter = "nombreCompleto like '%" + valor + "%' OR nombreCompleto like '%" + valor + "%' ";
            grdDatosPersonas.DataSource = bs;
        }
        private void seleccionarPersona() {
            int _ID = int.Parse(grdDatosPersonas.CurrentRow.Cells["IdPersona"].Value.ToString());
            posicion = dt.Rows.IndexOf(dt.Rows.Find(_ID));
            mostrarDatosPersonas();
        }
        private void grdDatosPersonas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionarPersona();
        }

        private void txtBuscarPersona_KeyUp(object sender, KeyEventArgs e)
        {
            filtrarDatosPersonas(txtBuscar.Text);
            if (e.KeyCode == Keys.Enter)
            {
                seleccionarPersona();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que quieres salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                MessageBox.Show("¡Hasta luego! Gracias por usar nuestra aplicación.", "Despedida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit(); // Cierra la aplicación
            }
            // Si el usuario selecciona "No", la aplicación continúa ejecutándose normalmente.

        }
        
    }
}


