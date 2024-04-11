﻿using System;
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
        // Variables para guardar toda la información del automata
        private int numeroEstados;
        private string estadoInicial;
        //Coleccion de cadenas de texto (Estados finales)
        private HashSet<string> estadosFinales;
        //Diccionario que almacena todas las transiciones del automata, utiliza una tupla de la forma (string, char)
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
                openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Archivos JSON (*.json)|*.json|Todos los archivos (*.*)|*.*";
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
        //Carga un automata del archivo a este programa
        public void CargarAutomataDesdeArchivo(string filePath)
        {
            //StreamReader para leer el contenido del archivo
            using (StreamReader reader = new StreamReader(filePath))
            {
                //Datos iniciales del automata
                numeroEstados = int.Parse(reader.ReadLine());
                estadoInicial = reader.ReadLine();
                //Se agregan los estados finales en un hash
                estadosFinales = new HashSet<string>(reader.ReadLine().Split(',').Select(s => s.Trim()));
                //Se coloca en el diccionario las transiciones
                transiciones = new Dictionary<Tuple<string, char>, string>();

                string line;
                //Se ejecuta mientras haya mas lineas en el archivo. Lee cada línea del archivo una por una.
                while ((line = reader.ReadLine()) != null)
                {
                    //Divide cada linea, utilizando la coma como delimitador, creando un arreglo de cadenas
                    string[] parts = line.Split(',');
                    //La primera parte de la linea dividida, será el estado actual
                    string estadoActual = parts[0].Trim();
                    //La segunda parte de la linea sera el simbolo/alfabeto que se esta leyendo en la cadena
                    char simbolo = parts[1].Trim()[0];
                    //La tercera parte de la lineaa es el estado siguiente (hacia donde se va a dirigir)
                    string estadoSiguiente = parts[2].Trim();
                    //Entrada a diccionario, esta es una tupla que contiene el estado actual y el símbolo, y el valor es el estado siguiente
                    //Esto representa una transición en el autómata.
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


        public bool ValidarCadena(string cadena, List<string> transicionesDeValidacion)
        {

            // Eliminar los espacios de la cadena antes de validarla.
            cadena = TrimString(Txtcadena.Text);


            string estadoActual = estadoInicial;
            transicionesDeValidacion.Clear();

            foreach (char simbolo in cadena)
            {
                //Verifica si existe una transición válida desde el estado actual con el símbolo actual, 
                //utiliza el método TryGetValue del diccionario transiciones para intentar obtener el estado siguiente asociado con la tupla de estado actual y símbolo actual.

                if (!transiciones.TryGetValue(new Tuple<string, char>(estadoActual, simbolo), out string estadoSiguiente))
                {
                    //Si no hay una transicion definidia para el estado y simbolo actual, entonces devolvera falso
                    return false;
                }
                //Agrega las transiciones que va a tener el autonama, y esas transicions se mandan por medio de la lista transicionesDeValidacion
                //Al richTextBox para que puedan aparecer todas las transiciones de manera escrita y ordenada
                transicionesDeValidacion.Add($"{estadoActual},{simbolo},{estadoSiguiente}");
                //Mueve el autómata al siguiente estado basado en la transición.
                estadoActual = estadoSiguiente;
            }
            //Verifica si el estado en el que finalizo el recorrido es un estado final
            return estadosFinales.Contains(estadoActual);
        }


        private void BtnValidarCadena_Click(object sender, EventArgs e)
        {

            //Se verifica que se haya ingresado un automata, esto verificando que en el archivo se lea la cantidad de estados
            //Si la cantidad de estados es igual a cero significa que no se detectó ningun automata


            if (numeroEstados == 0)
            {
                MessageBox.Show("Primero carga un autómata antes de validar una cadena.");
                return;
            }

            //Verifica que se ingrese una cadena en el txt, si esta nulo, tira error
            string cadena = Txtcadena.Text.Trim();
            if (string.IsNullOrEmpty(cadena))
            {
                MessageBox.Show("Ingresa una cadena para validar.");
                return;
            }

            //Se crea la lista en donde se van a almacenar todas las transiciones
            List<string> transicionesDeValidacion = new List<string>();

            //Con el metodo booleano de ValidarCadena, se comprueba si la cadena es valida o no
            if (ValidarCadena(cadena, transicionesDeValidacion))
            {
                MessageBox.Show("La cadena es válida para el autómata.");
            }
            else
            {
                MessageBox.Show("La cadena NO es válida para el autómata.");
            }
            //En el richBox de transicion se agregan todas las transiciones que se realizaron en el automata, mediante el metodo
            //de transiciones de validacion y se le pone un salto de linea (Enviroment.NewLine) mas que todo para mantener el orden
            RchTransicion.Text = string.Join(Environment.NewLine, transicionesDeValidacion);
            
        }

        private static string TrimString(string cadena)
        {
            // Se reemplaza todos los espacios en blanco por una cadena vacía.
            return cadena.Replace(" ", string.Empty);
        }

    }
}
  

