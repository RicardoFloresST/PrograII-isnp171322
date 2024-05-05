using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;//libreria para conectarnos a las bases de datos
using System.Data.SqlClient;// Proveedor de datos, SQL Server

namespace Ejercicio_1
{
    internal class Conexion    {
        SqlConnection mibase = new SqlConnection();//Conexion a la base de datos
        SqlCommand miComando = new SqlCommand();// Ejecutar entradas SQL
        SqlDataAdapter miadaptador = new SqlDataAdapter();//intermediario entre la DB y la aplicacion
        DataSet ds = new DataSet();//Copia de la arquitectura de la DB en memoria

        public Conexion() {
            String cadena = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\dbo.Estudiantes.mdf;Integrated Security=True";
            mibase.ConnectionString = cadena;
            mibase.Open();
        }
        public DataSet ObtenerDatos() {
            ds.Clear();
            miComando.Connection = mibase;

            miComando.CommandText = "select * from Estudiantes";
            miadaptador.SelectCommand = miComando;
            miadaptador.Fill(ds, "Estudiantes");
            return ds;
        }
    }
}
