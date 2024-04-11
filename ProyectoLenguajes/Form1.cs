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
        private string estadoInicial;
        private HashSet<string> estadosFinales;
        private Dictionary<Tuple<string, char>, string> transiciones;

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
                    //Obtener nombre del archivo
                    string fileName = openFileDialog.SafeFileName;

                    // Lee el contenido del archivo
                    string content = File.ReadAllText(filePath);

                    CargarAutomataDesdeArchivo(filePath);
                    RchMostrar.Text = content;
                    MessageBox.Show("Autómata cargado exitosamente.");
                    Txtcadena.Text = "";
                    RchTransicion.Text = "";
                    label5.Text = fileName;

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
        
        public void CargarAutomataDesdeArchivo(string filePath)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                numeroEstados = int.Parse(reader.ReadLine());
                estadoInicial = reader.ReadLine();
                estadosFinales = new HashSet<string>(reader.ReadLine().Split(',').Select(s => s.Trim()));
                transiciones = new Dictionary<Tuple<string, char>, string>();

                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    string estadoActual = parts[0].Trim();
                    char simbolo = parts[1].Trim()[0];
                    string estadoSiguiente = parts[2].Trim();
                    transiciones[new Tuple<string, char>(estadoActual, simbolo)] = estadoSiguiente;
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

            

            List<string> transicionesDeValidacion = new List<string>();

            if (ValidarCadena(cadena, transicionesDeValidacion))
            {
                MessageBox.Show("La cadena es válida para el autómata.");
            }
            else
            {
                MessageBox.Show("La cadena NO es válida para el autómata.");
            }

            RchTransicion.Text = string.Join(Environment.NewLine, transicionesDeValidacion);
            
        }

        private static string TrimString(string cadena)
        {
            // Reemplazar todos los espacios en blanco por una cadena vacía.
            return cadena.Replace(" ", string.Empty);
        }


        public bool ValidarCadena(string cadena, List<string> transicionesDeValidacion)
        {

            // Eliminar los espacios de la cadena antes de validarla.
            cadena = TrimString(Txtcadena.Text);


            string estadoActual = estadoInicial;
            transicionesDeValidacion.Clear();

            foreach (char simbolo in cadena)
            {
                if (!transiciones.TryGetValue(new Tuple<string, char>(estadoActual, simbolo), out string estadoSiguiente))
                {
                    return false; 
                }
                transicionesDeValidacion.Add($"{estadoActual},{simbolo},{estadoSiguiente}");
                estadoActual = estadoSiguiente;
            }

            return estadosFinales.Contains(estadoActual); 
        }

      

    }
}
  

