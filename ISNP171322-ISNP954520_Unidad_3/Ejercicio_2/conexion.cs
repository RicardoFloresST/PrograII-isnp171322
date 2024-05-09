using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_2
{
    internal class conexion
    {
        SqlConnection mibase = new SqlConnection();//Conexion a la base de datos
        SqlCommand miComando = new SqlCommand();// Ejecutar entradas SQL
        SqlDataAdapter miadaptador = new SqlDataAdapter();//intermediario entre la DB y la aplicacion
        DataSet ds = new DataSet();//Copia de la arquitectura de la DB en memoria

        public conexion()
        {
            try
            {
                String cadena = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Agenda.mdf;Integrated Security=True";
                mibase.ConnectionString = cadena;
                //mibase.Open();
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

        public DataSet ObtenerDatos()
        {
            try
            {
                ds.Clear();
                miComando.Connection = mibase;
                miComando.CommandText = "SELECT * FROM agendaPersonas";
                miadaptador.SelectCommand = miComando;
                miadaptador.Fill(ds, "agendaPersonas");
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener datos: " + ex.Message);
            }
        }

        public string InsertarDatos(String[] agendaPersonas, String accion)
        {
            String sql = "";
            try
            {
                if (accion == "Nuevo Registro")
                {
                    sql = "INSERT INTO agendaPersonas (nombreCompleto, texto, fechaCreacion) VALUES ('" + agendaPersonas[1] + "', '" + agendaPersonas[2] + "', '" + agendaPersonas[3] + "')";
                }
                else if (accion == "Editar Registro")
                {
                    sql = "UPDATE agendaPersonas SET nombreCompleto = '" + agendaPersonas[1] + "', texto = '" + agendaPersonas[2] + "', fechaCreacion = '" + agendaPersonas[3] +
                        "' WHERE IdPersona = '" + agendaPersonas[0] + "'";
                }
                else if (accion == "Eliminar Registro")
                {
                    sql = "DELETE FROM agendaPersonas WHERE IdPersona = '" + agendaPersonas[0] + "'";
                }
                return ejecutarSql(sql);
            }
            catch (Exception ex)
            {
                return "error al intentar guardar el registro: " + ex.Message;
            }
        }

        private String ejecutarSql(String sql)
        {
            try
            {
                miComando.CommandText = sql;
                miComando.Connection = mibase;
                mibase.Open(); // Abre la conexión antes de ejecutar la consulta
                return miComando.ExecuteNonQuery().ToString();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar la consulta SQL: " + ex.Message);
            }
            finally
            {
                mibase.Close(); // Siempre cierra la conexión después de ejecutar la consulta
            }
        }
    }
}