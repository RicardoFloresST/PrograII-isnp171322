using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Ejercicio_8
{
    public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void btnMostrar_Click(object sender, EventArgs e)
    {
            // Limpiamos el TextBox antes de mostrar la nueva tabla de multiplicar
            txtTablaMulti.Clear();

            // Verificamos si el usuario ingresó un número válido
            if (int.TryParse(txtNTabla.Text, out int numeroTabla))
            {
                // Si el número es mayor que 10, mostramos un mensaje de error
                if (numeroTabla > 10)
                {
                    MessageBox.Show("Solo se puede mostrar hasta la tabla del 10.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    numeroTabla = 10; // Cambiamos el número a 10 para mostrar la tabla del 10
                }

                // Construimos la tabla de multiplicar del número ingresado
                txtTablaMulti.AppendText($"Tabla del {numeroTabla}:\r\n");
                for (int i = 1; i <= 10; i++)
                {
                    int resultado = numeroTabla * i;
                    txtTablaMulti.AppendText($"{numeroTabla} x {i} = {resultado}\r\n");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido (1-10).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¡Gracias por usar este programa!", "¡Hasta luego!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close(); // Cierra la aplicación
        }
    }
}
