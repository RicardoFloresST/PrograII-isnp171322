using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;//libreria para conectarnos a las bases de datos
using System.Data.SqlClient;// Proveedor de datos, SQL Server

namespace Ejercicio_3
{
    internal class Conexion
    {
        SqlConnection mibase = new SqlConnection();
        SqlCommand miComando = new SqlCommand();
        SqlDataAdapter miadaptador = new SqlDataAdapter();
        DataSet ds = new DataSet();

        public Conexion()
        {
            try
            {
                String cadena = @"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\crtVacunas.mdf; Integrated Security=True";
                mibase.ConnectionString = cadena;
                mibase.Open();
                if (mibase.State == ConnectionState.Open)
                {
                    Console.WriteLine("Conexión establecida correctamente.");
                }
                else
                {
                    Console.WriteLine("Error al establecer la conexión.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al abrir la conexión: " + ex.Message);
            }
        }

        public string AdministrarPaciente(string codigoPaciente, string nombreCompleto, string[] vacunasSeleccionadas, string accion)
        {
            string sql = "";
            try
            {
                if (accion == "Nuevo Registro")
                {
                    // Construir la consulta para insertar el nuevo registro
                    // La consulta dependerá de la cantidad de vacunas seleccionadas
                    string columnasVacunas = string.Join(", ", vacunasSeleccionadas.Select((vacuna, index) => $"@Vacuna{index + 1}"));
                    string valoresVacunas = string.Join(", ", Enumerable.Range(1, vacunasSeleccionadas.Length).Select(index => $"vacuna_{index} = @Vacuna{index}"));
                    sql = $"INSERT INTO VacunasPacientes (codigoPaciente, nombreCompleto, {valoresVacunas}) VALUES (@CodigoPaciente, @NombreCompleto, {columnasVacunas})";
                }
                else if (accion == "Modificar Registro")
                {
                    // Construir la consulta para actualizar el registro
                    // Aquí también depende de cómo está estructurada tu base de datos
                    // Podrías necesitar un UPDATE para cada vacuna seleccionada
                }
                else if (accion == "Eliminar Registro")
                {
                    // Construir la consulta para eliminar el registro
                }

                // Usar SqlCommand para ejecutar la consulta construida
                using (SqlCommand command = new SqlCommand(sql, mibase))
                {
                    command.Parameters.AddWithValue("@CodigoPaciente", codigoPaciente);
                    command.Parameters.AddWithValue("@NombreCompleto", nombreCompleto);
                    for (int i = 0; i < vacunasSeleccionadas.Length; i++)
                    {
                        command.Parameters.AddWithValue($"@Vacuna{i + 1}", vacunasSeleccionadas[i]);
                    }
                    command.ExecuteNonQuery();
                }

                return "Operación realizada correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al intentar realizar la operación: " + ex.Message;
            }
        }

        public DataSet ObtenerDatos()
        {
            ds.Clear();
            miComando.Connection = mibase;

            miComando.CommandText = "SELECT * FROM vacunasPacientes";
            miadaptador.SelectCommand = miComando;
            miadaptador.Fill(ds, "VacunasPacientes");
            return ds;
        }
    }
}
