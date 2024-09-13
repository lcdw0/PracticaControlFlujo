using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluacion2

    public partial class Form1 : Form
    {
        // Declara listaPersonas aquí, para que sea accesible desde todos los métodos de la clase Form1
        private List<Persona> listaPersonas = new List<Persona>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Validar entradas con control de flujo
            if (string.IsNullOrEmpty(txtNombres.Text))
            {
                MessageBox.Show("Por favor, ingresa el nombre.");
                return;
            }

            if (string.IsNullOrEmpty(txtApellidos.Text))
            {
                MessageBox.Show("Por favor, ingresa el apellido.");
                return;
            }

            DateTime fechaNacimiento;
            bool esFechaValida = DateTime.TryParse(txtFechaNacimiento.Text, out fechaNacimiento);
            if (!esFechaValida)
            {
                MessageBox.Show("Por favor, ingresa una fecha de nacimiento válida (MM/DD/YYYY).");
                return;
            }

            if (fechaNacimiento > DateTime.Now)
            {
                MessageBox.Show("La fecha de nacimiento no puede ser en el futuro.");
                return;
            }

            // Crear una nueva persona y agregarla a la lista
            Persona nuevaPersona = new Persona(txtNombres.Text, txtApellidos.Text, fechaNacimiento);
            listaPersonas.Add(nuevaPersona);

            // Mostrar la lista de personas
            ActualizarListaPersonas();

            // Limpiar los TextBoxes
            txtNombres.Clear();
            txtApellidos.Clear();
            txtFechaNacimiento.Clear();
        }

        private void ActualizarListaPersonas()
        {
            lstPersonas.Items.Clear();

            // Estructura de control "for" para recorrer la lista
            for (int i = 0; i < listaPersonas.Count; i++)
            {
                lstPersonas.Items.Add(listaPersonas[i].ToString());
            }
        }
    }
}
