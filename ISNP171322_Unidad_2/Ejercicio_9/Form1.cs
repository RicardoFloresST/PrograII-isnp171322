using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Array para almacenar los números ingresados por el usuario
            double[] numeros = new double[10];

            // Obtener los números ingresados por el usuario y almacenarlos en el array
            for (int i = 0; i < 10; i++)
            {
                if (!double.TryParse(Controls[$"txtNumero{i + 1}"].Text, out numeros[i]))
                {
                    MessageBox.Show("Por favor, ingrese números válidos en todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // Encontrar el número mayor en el array
            double mayor = numeros.Max();

            // Mostrar el número mayor en el Label
            lblResult.Text = $"El mayor de los 10 números es: {mayor}";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¡Gracias por usar este programa!", "¡Hasta luego!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close(); // Cierra la aplicación
        }
    }
}
        
    

