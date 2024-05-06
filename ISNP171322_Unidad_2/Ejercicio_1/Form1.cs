using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_1
{
    public partial class ComversorForms: Form
    {
        public ComversorForms()
        {
            InitializeComponent();
        }
        private void btnConver1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out double libras))
            {
                double kg = libras * 0.453592; // 1 libra = 0.453592 kilogramos
                textBox3.Text = kg.ToString("0.0000");
            }
            else
            {
                MessageBox.Show("Por favor, introduzca un valor válido en libras.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox2.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out double kg))
            {
                double libras = kg / 0.453592; // 1 kilogramo = 2.20462 libras
                textBox4.Text = libras.ToString("0.0000");
            }
            else
            {
                MessageBox.Show("Por favor, introduzca un valor válido en kilogramos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}