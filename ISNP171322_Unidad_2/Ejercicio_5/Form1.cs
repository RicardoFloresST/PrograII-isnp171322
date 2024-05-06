using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_5
{
    public partial class Form1 : Form
    {
        private const int NumeroLaboratorios = 3;
        private const int NumeroParciales = 2;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnPromedio_Click(object sender, EventArgs e)
        {
            // Obtener las calificaciones de los laboratorios y parciales
            double lab1 = Convert.ToDouble(txtLab1.Text);
            double lab2 = Convert.ToDouble(txtLab2.Text);
            double lab3 = Convert.ToDouble(txtLab3.Text);
            double parcial1 = Convert.ToDouble(txtPar1.Text);
            double parcial2 = Convert.ToDouble(txtPar2.Text);
            double parcial3 = Convert.ToDouble(txtPar3.Text);

            // Calcular el promedio final
            double promedioLaboratorios = (lab1 + lab2 + lab3) / 3;
            double promedioParciales = (parcial1 + parcial2 + parcial3) / 3;
            double promedioFinal = (promedioLaboratorios + promedioParciales) / 2;

           // Mostrar el promedio final en el cuadro de texto correspondiente
            txtNotaFin.Text = promedioFinal.ToString("0.00");

        }
    }
}