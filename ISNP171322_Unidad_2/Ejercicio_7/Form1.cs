using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            {
                // Realizamos la suma de los primeros 100 números naturales
                int suma = SumarPrimerosNNumeros(100);

                // Mostramos el resultado en el Label
                lblResultado.Text = $"La suma de los primeros 100 números naturales es: {suma}";
            }
            {
            // Realizamos la suma de los primeros 100 números naturales
            int suma = SumarPrimerosNNumeros(100);

            // Mostramos el resultado en el Label
            lblResultado.Text = $"La suma de los primeros 100 números naturales es: {suma}";
        }
     }

        private int SumarPrimerosNNumeros(int n)
        {
            // Inicializamos la suma en cero
            int suma = 0;

            // Iteramos desde 1 hasta n y sumamos cada número
            for (int i = 1; i <= n; i++)
            {
                suma += i;
            }

            return suma;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¡Gracias por usar este programa!", "¡Hasta luego!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close(); // Cierra la aplicación

        }
    }
}
