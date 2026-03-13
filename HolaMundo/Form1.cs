using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HolaMundo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Creamos una sentencia para que el texto de los textbox se convierta en asteriscos,
        //para ocultar la contraseña del usuario, y así evitar que alguien más pueda verla.
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.PasswordChar = '*';
        }
        //Lo aplicamos para ambos textbox
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }
        //Creamos un evento para validar la contraseña ingresada por el usuario,
        //verificando que cumpla con los requisitos establecidos.
        private void btn1_Click(object sender, EventArgs e)
        {   // Validamos la contraseña utilizando la función ValidarContrasena.
            if (ValidarContrasena(textBox1.Text))
            {   // Si la contraseña es válida, comparamos los textos de ambos
                // textbox para asegurarnos de que coincidan.
                if (textBox1.Text == textBox2.Text)
                {// Si las contraseñas coinciden, mostramos un mensaje de éxito al usuario.
                    MessageBox.Show("La contraseña ha sido validada", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {// Si las contraseñas no coinciden, mostramos un mensaje de advertencia al usuario.
                    MessageBox.Show("Las contraseñas no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }// Si la contraseña no cumple con los requisitos, mostramos un mensaje de error al usuario.
            else
            {
                MessageBox.Show("La contraseña no cumple con los requisitos:\n- Una mayúscula\n- Una minúscula\n- Un número\n- Un símbolo especial\n- Mínimo 8 caracteres",
                                "Validación fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Función para validar la contraseña utilizando una expresión regular.
        private bool ValidarContrasena(string password)
        {
            // Regex: 
            // (?=.*[a-z]) : Al menos una minúscula
            // (?=.*[A-Z]) : Al menos una mayúscula
            // (?=.*\d)    : Al menos un número
            // (?=.*[^\da-zA-Z]) : Al menos un símbolo (no alfanumérico)
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$";
            return Regex.IsMatch(password, pattern);
        }
    }
}
