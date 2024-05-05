using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;//libreria para conectarnos a las bases de datos
using System.Data.SqlClient;// Proveedor de datos, SQL Server

namespace Ejercicio_1
{
    internal class Conexion {
        SqlConnection mibase = new SqlConnection();//Conexion a la base de datos
        SqlCommand miComando = new SqlCommand();// Ejecutar entradas SQL
        SqlDataAdapter miadaptador = new SqlDataAdapter();//intermediario entre la DB y la aplicacion
        DataSet ds = new DataSet();//Copia de la arquitectura de la DB en memoria

        public Conexion() {
            try
            {
                String cadena = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\dbo.Estudiantes.mdf;Integrated Security=True";
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
        public DataSet ObtenerDatos() {
            ds.Clear();
            miComando.Connection = mibase;

            miComando.CommandText = "select * from Estudiantes";
            miadaptador.SelectCommand = miComando;
            miadaptador.Fill(ds, "Estudiantes");
            return ds;
        }
        public string administrarEstudiantes(String[] Estudiantes, String accion)
        {
            String sql = "";
            try
            {
                if (accion == "Nuevo Registro")
                {
                    sql = "INSERT INTO Estudiantes (Codigo, NombreCompleto, Edad, Sexo, NotaLab1, NotaLab2, NotaParcial, Promedio) VALUES ('" + Estudiantes[1] + "', '" + Estudiantes[2] + "', '" + Estudiantes[3] + "', '" + Estudiantes[4] + "', '" + Estudiantes[5] + "', '" + Estudiantes[6] + "', '" + Estudiantes[7] + "', '" + Estudiantes[8] + "')";
                }
                else if (accion == "Editar Registro")
                {
                    sql = "UPDATE Estudiantes SET Codigo = '" + Estudiantes[1] + "'," + " NombreCompleto = '" + Estudiantes[2] + "'," + " Edad = "
                     + Estudiantes[3] + "," + " Sexo = '" + Estudiantes[4] + "'," + " NotaLab1 = " + Estudiantes[5] + "," + " NotaLab2 = '"
                     + Estudiantes[6] + "'," + " NotaParcial = " + Estudiantes[7] + "," + " Promedio = '" + Estudiantes[8] +
                      "' WHERE IdEstudiante = '" + Estudiantes[0] + "'";
                }
                else if (accion == "Eliminar Registro")
                {
                    sql = "DELETE Estudiantes WHERE IdEstudiante = '" + Estudiantes[0] + "'";
                }
                return ejecutarSql(sql);

            }
            catch (Exception ex)
            {
                return "error al intentar guardar el registro: " + ex.Message;
            }
        }
        private String ejecutarSql(String sql) {
            try
            {
                miComando.CommandText = sql;
                miComando.Connection = mibase;
                return miComando.ExecuteNonQuery().ToString();
            }
            catch (Exception ex)
            {
                return "Error al ejecutar la consulta SQL: " + ex.Message;
            }
            
        }
    }
}
