using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;//libreria usada para validar los textbox
using System.Runtime.InteropServices;//libreria usada para mover el form

using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ejercicio_2
{
    public partial class ConversorLongForms : Form
    {
        
        public ConversorLongForms()
        {
            InitializeComponent();
            
            // Llenar el ComboBox con las opciones de longitud
            cmbOrigen.Items.Add("Metros");
            cmbOrigen.Items.Add("Yardas");
            cmbOrigen.Items.Add("Centímetros");
            cmbOrigen.Items.Add("Milímetros");
            
            // Seleccionar la primera opción por defecto
            cmbOrigen.SelectedIndex = 0;

            // Llenar el ComboBox con las opciones de longitud
            cmbdestino.Items.Add("Metros");
            cmbdestino.Items.Add("Yardas");
            cmbdestino.Items.Add("Centímetros");
            cmbdestino.Items.Add("Milímetros");

            // Seleccionar la primera opción por defecto
            cmbdestino.SelectedIndex = 1;
        }

        private void RealizarConversion(string unidadResultado)
        {
            
            try
            {
               
                double valor = double.Parse(texCant.Text);
            double resultado = 0.0;
            

                // Realizar la conversión basada en las unidades seleccionadas en los ComboBoxes
                if (cmbOrigen.SelectedIndex == 0 && cmbdestino.SelectedIndex == 1) // Metros a Yardas
            {
                resultado = valor * 1.09361;
                    unidadResultado = "yrd";
                }
            else if (cmbOrigen.SelectedIndex == 1 && cmbdestino.SelectedIndex == 0) // Yardas a Metros
            {
                resultado = valor / 1.09361;
                    unidadResultado = "mt";
                }
            else if (cmbOrigen.SelectedIndex == 0 && cmbdestino.SelectedIndex == 2) // Metros a Centímetros
            {
                resultado = valor * 100;
                    unidadResultado = "cm";
                }
            else if (cmbOrigen.SelectedIndex == 2 && cmbdestino.SelectedIndex == 0) // Centímetros a Metros
            {
                resultado = valor / 100;
                    unidadResultado = "mt";
                }
            else if (cmbOrigen.SelectedIndex == 0 && cmbdestino.SelectedIndex == 3) // Metros a Milímetros
            {
                resultado = valor * 1000;
                    unidadResultado = "mm";
                }
            else if (cmbOrigen.SelectedIndex == 3 && cmbdestino.SelectedIndex == 0) // Milímetros a Metros
            {
                resultado = valor / 1000;
                    unidadResultado = "mt";

                }

            else if (cmbOrigen.SelectedIndex == 1 && cmbdestino.SelectedIndex == 3) // Yardas a Milímetros
            {
                resultado = valor * 914.4;
                    unidadResultado = "mm";
                }

            else if (cmbOrigen.SelectedIndex == 3 && cmbdestino.SelectedIndex == 1) // Milímetros a Yardas
            {
                resultado = valor / 914.4;
                    unidadResultado = "yrd";
                }

            else if (cmbOrigen.SelectedIndex == 2 && cmbdestino.SelectedIndex == 3) // Centímetros a Milímetros
            {
                resultado = valor * 10;
                    unidadResultado = "mm";
                }

            else if (cmbOrigen.SelectedIndex == 1 && cmbdestino.SelectedIndex == 2) // Yardas a Centímetros
            {
                resultado = valor * 91.44;
                    unidadResultado = "cm";
                }

            else if (cmbOrigen.SelectedIndex == 2 && cmbdestino.SelectedIndex == 1) // Yardas a Centímetros
            {
                resultado = valor / 91.44;
                    unidadResultado = "cm";
                }

            else if (cmbOrigen.SelectedIndex == 3 && cmbdestino.SelectedIndex == 2) // Milímetros a centímetros
            {
                resultado = valor / 10;
                    unidadResultado = "cm";
                }

                // Agregar más condiciones según sea necesario para otras conversiones
                resultado = Math.Round(resultado, 4);
                texReslut.Text = resultado.ToString() + " " + unidadResultado;
            }
            catch (Exception)
            {
                MessageBox.Show("Error por favor ingrese los valores solicitados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void texCant_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada no es un número o una tecla de control
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Mostrar una advertencia al usuario
                MessageBox.Show("Por favor, ingresa solo números.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Detener la tecla presionada para que no se escriba en el TextBox
                e.Handled = true;
            }
        }

        private void btnconver_Click(object sender, EventArgs e)
         {
             RealizarConversion(texReslut.Text);
           
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            //usado para dejar en blanco los textbox
            texCant.Text = "";
            texReslut.Text = "";
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
         private void label6_Click(object sender, EventArgs e)
         {
            AboutBox1 formAcercaDe = new AboutBox1();
            formAcercaDe.ShowDialog();
         }

       }
    }
 





