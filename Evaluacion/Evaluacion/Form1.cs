using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluacion
{
    public partial class Form1 : Form
    {
        private ManejadorNumeros manejador;  // Declaracion de la variable manejador

        public Form1()
        {
            InitializeComponent();
            manejador = new ManejadorNumeros();  // Inicializacion de la variable manejador
        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int numero;

            // Validar si el numero ingresado es valido
            if (int.TryParse(txtNumero.Text, out numero))
            {
                if (numero < 0)
                {
                    // Mostrar los resultados cuando el numero ingresado sea negativo
                    MostrarResultados();
                }
                else
                {
                    // Agregar el numero a la lista
                    manejador.AgregarNumero(numero);
                    txtNumero.Clear();
                    txtNumero.Focus();
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un numero válido.");
                txtNumero.Clear();
                txtNumero.Focus();
            }
        }
        private void MostrarResultados()
        {
            if (manejador.HayNumeros())
            {
                int suma = manejador.ObtenerSuma();
                int mayor = manejador.ObtenerMayor();
                int menor = manejador.ObtenerMenor();

                lblResultados.Text = $"Suma: {suma}\nMayor: {mayor}\nMenor: {menor}";
            }
            else
            {
                lblResultados.Text = "No se ingresaron numeros.";
            }

        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {

        }
    }
}