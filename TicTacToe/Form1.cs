﻿using System;
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
            // Ahora pasaremos a este método para el menú de una nueva partida.

            who = 'o'; // Círculo del tablero.
            movement = 0; // Número limitado de movimientos.
            b1.Enabled = true; b1.Text = ""; b1.BackColor = Color.DarkRed; // Botón 1.
            b2.Enabled = true; b2.Text = ""; b2.BackColor = Color.DarkSalmon; // Botón 2.
            b3.Enabled = true; b3.Text = ""; b3.BackColor = Color.DarkRed; // Botón 3.
            b4.Enabled = true; b4.Text = ""; b4.BackColor = Color.DarkSalmon; // Botón 4.
            b5.Enabled = true; b5.Text = ""; b5.BackColor = Color.DarkRed; // Botón 5.
            b6.Enabled = true; b6.Text = ""; b6.BackColor = Color.DarkSalmon; // Botón 6.
            b7.Enabled = true; b7.Text = ""; b7.BackColor = Color.DarkRed; // Botón 7.
            b8.Enabled = true; b8.Text = ""; b8.BackColor = Color.DarkSalmon; // Botón 8.
            b9.Enabled = true; b9.Text = ""; b9.BackColor = Color.DarkRed; // Botón 9.
            tableLayoutPanel1.Enabled = true; // Cuando está activado el tablero del juego.
        }

        // Método para redireccionar a la parte de información del juego.
        private void informaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Le agregaremos los derechos de autor en este método.

            MessageBox.Show(" Copyright 2023© Todos los derechos Reservados ");
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

                // Ahora probaremos con todos los botones funcionando en el juego.

                if ((b1.Text == b2.Text && b2.Text == b3.Text && b2.Text != "") ||
                     (b4.Text == b5.Text && b5.Text == b6.Text && b5.Text != "") ||
                     (b7.Text == b8.Text && b8.Text == b9.Text && b8.Text != "") ||
                     (b1.Text == b4.Text && b4.Text == b7.Text && b4.Text != "") ||
                     (b2.Text == b5.Text && b5.Text == b8.Text && b5.Text != "") ||
                     (b3.Text == b6.Text && b6.Text == b9.Text && b6.Text != "") ||
                     (b1.Text == b5.Text && b5.Text == b9.Text && b5.Text != "") ||
                     (b3.Text == b5.Text && b5.Text == b7.Text && b5.Text != ""))
                {
                    MessageBox.Show(($"El ganador es {who.ToString().ToUpper()} !!!!!")); // Anuncia a un ganador mediante una ventana de mensaje.
                    tableLayoutPanel1.Enabled = false; // Finaliza la ejecución del juego.
                }
                else if (movement == 8) // Cuando no hay espacios disponibles del tablero.
                {
                    MessageBox.Show(" EMPATE !!!!!");
                }

                who = 'x'; // No es una X.
            }
            else if (who == 'x') // En caso contrario cuando es una X...
            {
                bt.Text = "x"; // Se escribe lo mismo pero con una X.

                // Ahora haremos lo mismo pero con otro elemento (X).

                if ((b1.Text == b2.Text && b2.Text == b3.Text && b2.Text != "") ||
                     (b4.Text == b5.Text && b5.Text == b6.Text && b5.Text != "") ||
                     (b7.Text == b8.Text && b8.Text == b9.Text && b8.Text != "") ||
                     (b1.Text == b4.Text && b4.Text == b7.Text && b4.Text != "") ||
                     (b2.Text == b5.Text && b5.Text == b8.Text && b5.Text != "") ||
                     (b3.Text == b6.Text && b6.Text == b9.Text && b6.Text != "") ||
                     (b1.Text == b5.Text && b5.Text == b9.Text && b5.Text != "") ||
                     (b3.Text == b5.Text && b5.Text == b7.Text && b5.Text != ""))
                {
                    MessageBox.Show(($"El ganador es {who.ToString().ToUpper()} !!!!!")); // Anuncia a un ganador mediante una ventana de mensaje.
                    tableLayoutPanel1.Enabled = false; // Finaliza la ejecución del juego.
                }
                else if (movement == 8) // Cuando no hay espacios disponibles del tablero.
                {
                    MessageBox.Show(" EMPATE !!!!!");
                }

                who = 'o'; // No es un círculo.
            }
            movement++;
        }
    }
}
