using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Obtener el nombre de usuario y la contraseña ingresados por el usuario
            string usuario = txtUser.Text.Trim();
            string contraseña = txtPass.Text.Trim();

            // Verificar si ambos campos están llenos
            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(contraseña))
            {
                MessageBox.Show("Por favor, llene todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Salir del método para evitar continuar con la verificación
            }

            // Verificar si el nombre de usuario y la contraseña son "ugb"
            if (usuario == "ugb" && contraseña == "ugb")
            {
                // Mostrar mensaje de bienvenida si las credenciales son correctas
                lblResult.Text = "Bienvenido Al Portal del Estudiante";
            }
            else
            {
                // Mostrar mensaje de acceso denegado si las credenciales son incorrectas
                lblResult.Text = "Acceso denegado. ¿Tienes problemas para iniciar sesión?";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¡Gracias por utilizar este programa!", "¡Hasta luego!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close(); // Cierra la aplicación
        }
    }
}