using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Evaluacion.Models;

namespace Evaluacion
{
    public partial class Form1 : Form
    {
        Operacion operacion = new Operacion(); // Instancia de Operacion

        public Form1()
        {
            InitializeComponent();
        }

        // Evento del botón para agregar un número
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddElement();
        }

        // Agregar un elemento
        private void AddElement()
        {
            try
            {
                int number = Convert.ToInt32(tbNumber.Text);

                // Llamar al método que agrega el número
                operacion.AddElements(number);

                ShowNumbers(); // Mostrar los números en el ListBox
                tbNumber.Clear(); // Limpiar el campo de entrada
                tbNumber.Focus(); // Poner el foco nuevamente en el campo de entrada
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("No se permiten números negativos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("El array está lleno.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para mostrar los números en el ListBox
        private void ShowNumbers()
        {
            try
            {
                lbNumbers.Items.Clear(); // Limpiar la lista antes de mostrar los números
                int[] numbers = operacion.GetElements(); // Obtener los elementos ingresados

                foreach (var num in numbers)
                {
                    lbNumbers.Items.Add(num); // Agregar los números al ListBox
                }

                // Mostrar la suma de los números
                int sum = numbers.Sum();
                lblAddition.Text = "Suma: " + sum;

                // Mostrar el número mayor y menor
                lblMayor.Text = "Mayor: " + operacion.ObtenerMayor();
                lblMenor.Text = "Menor: " + operacion.ObtenerMenor();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbNumbers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblAddition_Click(object sender, EventArgs e)
        {

        }

        private void lblMayor_Click(object sender, EventArgs e)
        {

        }

        private void lblMenor_Click(object sender, EventArgs e)
        {

        }
    }
}
