using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Timer timer = new Timer();
            timer.Interval = 1000; // 1 segundo
            timer.Tick += timer1_Tick;
            timer.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUnitario.Text) || string.IsNullOrWhiteSpace(txtCant.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Detener la ejecución del método
            }

            double Uni = double.Parse(txtUnitario.Text);
            double Cant = double.Parse(txtCant.Text);
            if (Uni == 0 || Cant == 0)
            {
                MessageBox.Show("No se puede calcular con cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Verificar si los campos están en blanco
            
            // Obtener el valor unitario ingresado por el usuario
            decimal vUnitario = decimal.Parse(txtUnitario.Text);

            // Obtener la cantidad ingresada por el usuario
            int cantidad = int.Parse(txtCant.Text);

            // Calcular el total sin descuento
            decimal totalSinDescu = CalTotalSinDescu(vUnitario, cantidad);

            // Calcular el descuento aplicado
            decimal descuento = CalcularDescuento(totalSinDescu);

            // Calcular el total a pagar con descuento
            decimal totalConDescu = totalSinDescu - descuento;

            // Formatear el resultado con separador de miles y punto decimal
            // totalFormateado = totalConDescu.ToString("#,##0.00");


            // Mostrar el resultado en la etiqueta correspondiente
            txtTotalP.Text = "" + totalConDescu.ToString("#,##0.00");

            // Bloquear el campo de texto del monto a pagar
            txtDescuento.ReadOnly = true;
            txtTotalP.ReadOnly = true;
        }

        // Método para calcular el total sin descuento
        private decimal CalTotalSinDescu(decimal valorUnitario, int cantidad)
        {
            return valorUnitario * cantidad;
        }

        // Método para calcular el descuento aplicado
        private decimal CalcularDescuento(decimal totalSinDescuento)
        {
            decimal descuento;
            if (totalSinDescuento < 20000)
            {
                descuento = totalSinDescuento * 0.15m; // 15% de descuento
                txtDescuento.Text = "15%";
            }
            else
            {
                descuento = totalSinDescuento * 0.35m; // 35% de descuento
                txtDescuento.Text = "35%";
            }
            return descuento;
        }
         

        // Método para calcular el total a pagar
        private decimal CalcularTotalPagar(decimal totalSinDescuento, decimal descuento)
        {
            return totalSinDescuento - descuento;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            //Con este podemos limpiar todos los textbox
            txtUnitario.Text = "";
            txtCant.Text = "";
            txtDescuento.Text = "";
            txtTotalP.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)

        {

            // Obtener la fecha y hora actual
            DateTime currentDateTime = DateTime.Now;

            // Mostrar la fecha y hora en un Label llamado "lblDateTime" en un formato específico
            lblDate.Text = "Fecha: " + currentDateTime.ToString("dd/MM/yyyy");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime currentDateTime = DateTime.Now;
            string formattedTime = currentDateTime.ToString("tt");
            // Obtener la hora actual sincronizada
            DateTime horaActual = DateTime.Now;
            lblTime.Text = $"Hora: {horaActual.ToString("hh:mm:ss")} " + formattedTime;
        }

       
    }
}