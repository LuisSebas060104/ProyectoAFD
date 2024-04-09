using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoLenguajes
{
    public partial class Form1 : Form
    {
        // Variables para almacenar la definición del autómata
        private int numeroEstados;
        private int estadoInicial;
        private HashSet<int> estadosFinales;
        private Dictionary<Tuple<int, char>, int> transiciones;

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAbrir_Click(object sender, EventArgs e)
        {
            try
            {
                // Crea un objeto OpenFileDialog
                OpenFileDialog openFileDialog = new OpenFileDialog();

                // Establece los filtros para mostrar solo archivos de texto (.txt)
                openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
                openFileDialog.FilterIndex = 1;

                // Muestra el diálogo para que el usuario seleccione un archivo
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Obtiene la ruta del archivo seleccionado por el usuario
                    string filePath = openFileDialog.FileName;

                    // Lee el contenido del archivo
                    string content = File.ReadAllText(filePath);

                    CargarAutomataDesdeArchivo(filePath);

                    MessageBox.Show("Autómata cargado exitosamente.");

                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error al leer el archivo: " + ex.Message);
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("No tienes permiso para acceder al archivo.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message);
            }
        }

        private void CargarAutomataDesdeArchivo(string filePath)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                numeroEstados = int.Parse(reader.ReadLine());
                estadoInicial = int.Parse(reader.ReadLine());
                estadosFinales = new HashSet<int>(reader.ReadLine().Split(',').Select(int.Parse));
                transiciones = new Dictionary<Tuple<int, char>, int>();

                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    int estadoActual = int.Parse(parts[0]);
                    char simbolo = parts[1][0];
                    int estadoSiguiente = int.Parse(parts[2]);
                    transiciones[new Tuple<int, char>(estadoActual, simbolo)] = estadoSiguiente;
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnValidarCadena_Click(object sender, EventArgs e)
        {
            if (numeroEstados == 0)
            {
                MessageBox.Show("Primero carga un autómata antes de validar una cadena.");
                return;
            }

            string cadena = Txtcadena.Text.Trim();
            if (string.IsNullOrEmpty(cadena))
            {
                MessageBox.Show("Ingresa una cadena para validar.");
                return;
            }

            if (ValidarCadena(cadena))
            {
                MessageBox.Show("La cadena es válida para el autómata.");
            }
            else
            {
                MessageBox.Show("La cadena NO es válida para el autómata.");
            }
        }

        private bool ValidarCadena(string cadena)
        {
            int estadoActual = estadoInicial;

            foreach (char simbolo in cadena)
            {
                if (!transiciones.TryGetValue(new Tuple<int, char>(estadoActual, simbolo), out int estadoSiguiente))
                {
                    return false; // No existe transición para el símbolo en el estado actual
                }
                estadoActual = estadoSiguiente;
            }

            return estadosFinales.Contains(estadoActual); // Verifica si el estado actual es final
        }

    }
}
  

