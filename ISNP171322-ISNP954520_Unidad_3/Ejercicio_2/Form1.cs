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
        // Lista para almacenar las entradas en la agenda
        private List<EntradaAgenda> entradasAgenda = new List<EntradaAgenda>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Configurar las columnas del DataGridView
            dataGridView1.Columns.Add("nombre", "Nombre");
            dataGridView1.Columns.Add("texto", "Texto");
            dataGridView1.Columns.Add("fecha", "Fecha");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Crear una nueva entrada de agenda con los valores ingresados por el usuario
            EntradaAgenda entrada = new EntradaAgenda
            {
                Nombre = txtNombre.Text,
                Texto = txtTexto.Text,
                Fecha = dtpFecha.Value
            };

            // Agregar la entrada a la lista
            entradasAgenda.Add(entrada);

            // Actualizar el DataGridView para mostrar la nueva entrada
            dataGridView1.Rows.Add(entrada.Nombre, entrada.Texto, entrada.Fecha.ToShortDateString());
        }
    }

    public class EntradaAgenda
    {
        public string Nombre { get; set; }
        public string Texto { get; set; }
        public DateTime Fecha { get; set; }
    }
}
