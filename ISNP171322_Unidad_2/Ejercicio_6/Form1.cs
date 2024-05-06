using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvertir_Click_1(object sender, EventArgs e)
        {
            int numDecimal;
            if (int.TryParse(txtnumero.Text, out numDecimal))
            {
                if (numDecimal >= 1 && numDecimal <= 20)
                {
                    string numeroRomano = ConvertirANumRomano(numDecimal);
                    lblResltado.Text = $"Romano equivalente es: {numeroRomano}";
                }
                else
                {
                    MessageBox.Show("Ingrese un número entre 1 y 20.", "Número Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Ingrese un número válido.", "Número Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private string ConvertirANumRomano(int numero)
        {
            string[] unidades = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
            string[] decenas = { "", "X", "XX", "XXX", "XL", "L" };
            if (numero <= 9)
            {
                return unidades[numero];
            }
            else if (numero <= 19)
            {
                return decenas[numero / 10] + unidades[numero % 10];
            }
            else
            {
                return "XX";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
 }
