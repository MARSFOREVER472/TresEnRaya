using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        // Vamos a declarar variables para el juego como elementos fundamentales.

        char who = 'o'; // Si es un círculo.
        short movement = 0; // Se inicializa con un número limitado de movimientos.

        // Método para la interfaz visual del juego.
        public Form1()
        {
            InitializeComponent();
        }

        // Método para inicializar un nuevo juego.
        private void nuevaPartidaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        // Método para redireccionar a la parte de información del juego.
        private void informaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        // Método para los botones del tablero.
        private void b1_Click(object sender, EventArgs e)
        {
            Button bt = sender as Button; // Botones del tablero.
            bt.Enabled = false; // Si es que no funciona al presionar un botón.
            bt.BackColor = Color.DarkOrange; // El color del botón es naranja oscuro.

            // Ahora procedemos a utilizar un algoritmo para el juego mediante una condición (if).

            if (who == 'o') // Si es un círculo.
            {
                bt.Text = "o"; // Se escribe exactamente igual desde este if mediante texto.
            }
        }
    }
}
