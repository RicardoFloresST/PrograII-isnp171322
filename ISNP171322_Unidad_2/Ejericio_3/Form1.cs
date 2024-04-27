using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejericio_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Timer timer = new Timer();
            timer.Interval = 1000; // 1 segundo
            timer.Tick += tTime_Tick;
            timer.Start();
        }
        private void rdbExponencial_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbExponencial.Checked)
            {
                lblSimbol.Text = "n^n"; 
            }
            else
            {  
                lblSimbol.Text = "";
            }
        }
        private void rdbRaiz_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbRaiz.Checked)
            {
                texNum1.Text = "2"; // Establecer num1 como 2 cuando se selecciona la raíz cuadrada
                lblSimbol.Text = "√";
                texNum1.Enabled = false; // Deshabilitar la edición de txtNum1
            }
            else
            {
                texNum1.Enabled = true; // Habilitar la edición de txtNum1 si no se selecciona la raíz cuadrada
                texNum1.Text = "";
                lblSimbol.Text = "";
            }
        }
        private void rdbRaizCub_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbRaizCub.Checked)
            {
                texNum1.Text = "3"; // Establecer num1 como 3 cuando se selecciona la raíz cúbica
                lblSimbol.Text = "∛";
                texNum1.Enabled = false; // Deshabilitar la edición de txtNum1
            }
            else
            {
                texNum1.Enabled = true; // Habilitar la edición de txtNum1 si no se selecciona la raíz cuadrada
                texNum1.Text = "";
                lblSimbol.Text = "";
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = double.Parse(texNum1.Text);
                double num2 = double.Parse(texNum2.Text);
                double respuesta = 0;
                if (num1 == 0 || num2 == 0)
                {
                    MessageBox.Show("No se puede calcular con cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (rbdSuma.Checked)
                {
                    respuesta = num1 + num2;
                }
                else if (rdbResta.Checked)
                {
                    respuesta = num1 - num2;
                }
                else if (rdbMulti.Checked)
                {
                    respuesta = num1 * num2;
                }
                else if (rdbDivision.Checked)
                {
                    respuesta = num1 / num2;
                }
                else if (rdbExponencial.Checked)
                {
                    respuesta = Math.Pow(num1, num2);
                }
                else if (rdbRaiz.Checked)
                {
                    respuesta = num1 == 2 ? Math.Sqrt(num2) : Math.Pow(num2, num1); // Raiz cuadrada

                }
                else if (rdbRaizCub.Checked)
                {
                    respuesta = num1 == 3 ? Math.Pow(num2, 1.0 / 3.0) : Math.Sqrt(num1); // Raíz cúbica
                }

                respuesta = Math.Round(respuesta, 10);
                texResulta.Text = respuesta.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Error, por favor ingreso los valores solicitados", "Calculadora", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //usado para dejar en blanco los textbox
            texNum1.Text = "";
            texNum2.Text = "";
            texResulta.Text = "";
        }

        private void lblDateTime_Click(object sender, EventArgs e)
        {
            // Obtener la fecha y hora actual
            
            DateTime currentDateTime = DateTime.Now;

            // Mostrar la fecha y hora en un Label llamado "lblDateTime"

            lblDateTime.Text = currentDateTime.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Obtener la fecha y hora actual
            DateTime currentDateTime = DateTime.Now;

            // Mostrar la fecha y hora en un Label llamado "lblDateTime" en un formato específico
            lblDateTime.Text = "Fecha: " + currentDateTime.ToString("dd/MM/yyyy");
        }

        private void tTime_Tick(object sender, EventArgs e)
        {
            DateTime currentDateTime = DateTime.Now;
            string formattedTime = currentDateTime.ToString("tt");
            // Obtener la hora actual sincronizada
            DateTime horaActual = DateTime.Now;
            lblTime.Text = $"Hora: {horaActual.ToString("hh:mm:ss")}"+ formattedTime;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

      
  