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
        // Variables para guardar toda la información del automata
        private int numeroEstados;
        private string estadoInicial;
        //Coleccion de cadenas de texto (Estados finales)
        private HashSet<string> estadosFinales;
        //Diccionario que almacena todas las transiciones del automata, utiliza una tupla de la forma (string, char)
        private Dictionary<Tuple<string, char>, HashSet<string>> transiciones;

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
               transiciones = new Dictionary<Tuple<string, char>, HashSet<string>>();

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
                    var key = new Tuple<string, char>(estadoActual, simbolo);
                    if (!transiciones.ContainsKey(key))
                    {
                        transiciones[key] = new HashSet<string>();
                    }
                    transiciones[key].Add(estadoSiguiente);

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
            cadena = cadena.Trim();

            string estadoActual = estadoInicial;
            transicionesDeValidacion.Clear();

            foreach (char simbolo in cadena)
            {
                // Verifica si existe una transición válida desde el estado actual con el símbolo actual
                var key = new Tuple<string, char>(estadoActual, simbolo);
                if (!transiciones.TryGetValue(key, out HashSet<string> estadosSiguientes))
                {
                    // Si no hay una transición definida para el estado y símbolo actual, entonces devolverá falso
                    return false;
                }

                // Agrega las transiciones que va a tener el autómata, y esas transiciones se mandan 
                // por medio de la lista transicionesDeValidacion al RichTextBox para que puedan aparecer 
                // todas las transiciones de manera escrita y ordenada
                foreach (string estadoSiguiente in estadosSiguientes)
                {
                    transicionesDeValidacion.Add($"{estadoActual},{simbolo},{estadoSiguiente}");
                }

                // Mueve el autómata a los siguientes estados basados en las transiciones
                // Esto puede implicar múltiples transiciones para un mismo símbolo
                estadoActual = string.Join(",", estadosSiguientes);
            }

            // Verifica si alguno de los estados en los que finalizó el recorrido es un estado final
            return estadoActual.Split(',').Any(est => estadosFinales.Contains(est));
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }





        //FASE AFN





        //Boton Para Abrir Archivos
        private void BtnAbrirN_Click(object sender, EventArgs e)
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
                    //Obtener nombre del archivo
                    string filePath = openFileDialog.FileName;
                    // Lee el contenido del archivo
                    string content = File.ReadAllText(filePath);

                    // Lee el contenido del archivo

                    RchMostrarN.Text = content;
                    TxtCadenaN.Text = "";

                      // Cargar el autómata desde el archivo
                    CargarAFNDesdeArchivo(filePath); 
                    MessageBox.Show("Autómata cargado exitosamente.");
                }
            }
            catch (IOException ex)
            {
                // Muestra error al encontrar una excepcion mediante el catch
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

        // Carga un automata del archivo a este programa
        private void CargarAFNDesdeArchivo(string filePath)
        {
            //StreamReader para leer el contenido del archivo
            using (StreamReader reader = new StreamReader(filePath))
            {
                //Datos iniciales del automata
                numeroEstados = int.Parse(reader.ReadLine());
                estadoInicial = reader.ReadLine();
                //Se agregan los estados finales en un hash
                estadosFinales = new HashSet<string>(reader.ReadLine().Split(','));
                //Se coloca en el diccionario las transiciones
                transiciones = new Dictionary<Tuple<string, char>, HashSet<string>>();

                string line;
                //Se ejecuta mientras haya mas lineas en el archivo. Lee cada línea del archivo una por una.
                while ((line = reader.ReadLine()) != null)
                {
                    //Divide cada linea, utilizando la coma como delimitador, creando un arreglo de cadenas
                    string[] parts = line.Split(',');
                    //La primera parte de la linea dividida, será el estado actual
                    string estadoActual = parts[0];
                    //La segunda parte de la linea sera el simbolo/alfabeto que se esta leyendo en la cadena
                    char simbolo = parts[1][0];
                    //La tercera parte de la lineaa es el estado siguiente (hacia donde se va a dirigir)
                    string estadoSiguiente = parts[2];
                    //Entrada a diccionario, esta es una tupla que contiene el estado actual y el símbolo, y el valor es el estado siguiente lo cual se entiende como una transicion
                    var key = new Tuple<string, char>(estadoActual, simbolo);
                    //Si la clave no existe, se procede a la siguiente línea.
                    if (!transiciones.ContainsKey(key))
                    {
                        transiciones[key] = new HashSet<string>();
                    }
                    //Si la clave key no existe, se crea una nueva entrada en el diccionario donde el valor asociado a key es un nuevo hash
                    transiciones[key].Add(estadoSiguiente);
                }
            }
        }

        private void BtnValidarN_Click(object sender, EventArgs e)
        {
            // Verifica la cantidad de numero de estados, si en dado caso es cero, tendremos que cargar un txt con una cantidad superior a uno
            if (numeroEstados == 0)
            {
                MessageBox.Show("Primero carga un autómata antes de validar una cadena.");
                return;
            }
            // Obtiene la cadena para validar
            string cadena = TxtCadenaN.Text.Trim();
            if (string.IsNullOrEmpty(cadena))
            {
                MessageBox.Show("Ingresa una cadena para validar.");
                return;
            }
            // Creamos una lista en donde se van a almacenar todas las transiciones realizadas
            List<string> transicionesRealizadas = new List<string>();
            // En este, llamamos al metodo de validar la cadena, con sus respectivos valores
            if (ValidarCadenaAFN(cadena, estadoInicial, transicionesRealizadas))
            {
                // Al tener la cadena se muestran todas las transiciones realizadas en RichTextBox y nos tira el mensaje de cadena valida
                MessageBox.Show("La cadena es válida para el autómata.");
                MostrarTransicionesEnRichTextBox(transicionesRealizadas);

            }
            else
            {
                //Si la cadena no es valida, nos tirará el mensaje de cadena no valida
                MessageBox.Show("La cadena NO es válida para el autómata.");
                MostrarTransicionesEnRichTextBox(transicionesRealizadas);

            }


        }

        //Metodo que nos agrupan todas las transicione y se muestran en un richtextbox
        private void MostrarTransicionesEnRichTextBox(List<string> transicionesRealizadas)
        {
            //El string builder para crear todo el contenido del texto
            StringBuilder sb = new StringBuilder();

            //El foreach nos sirve para iterar cada transicion sobre la lista de transicionesRealizadas
            foreach (string transicion in transicionesRealizadas)
            {
                // El apendline es para agregar una transicion a una nueva linea
                sb.AppendLine(transicion); 
            }
            //Se muestran todas las transiciones en el richtextBox
            RchValidarN.Text = sb.ToString(); 
        }


        //Metodo para validar las cadenas ingresadas en el AFN
        private bool ValidarCadenaAFN(string cadena, string estadoActual, List<string> transicionesRealizadas)
        {
            // Comprobar si la cadena esta vacia
            if (cadena.Length == 0)
            {
                // Si es que esta vacia, se verifica si el estado actual es final
                return estadosFinales.Contains(estadoActual);
            }
            // Se busca el primer simbolo
            char simbolo = cadena[0];
            bool cadenaValida = false;

            // Por medio del foreach se buscan las transiciones del estado en el que se encuentra con el simbolo actual. kvp representa KeyValuePart que es cada elemento del diccionario
            foreach (var kvp in transiciones)
            {
                //Se accede al primer elemento, basicamente se representa el estado de origen
                string estadoOrigen = kvp.Key.Item1;
                // Se accede al segundo elemento, que en este caso serian los simbolos de transiciones
                char simboloTransicion = kvp.Key.Item2;
                //Y aqui se accede a los estados siguiente que se encuentran en un hash
                HashSet<string> estadosSiguientes = kvp.Value;
                // Aqui basicamente se comprueba que la transicion y estado sean validos desde el estado actual con el simbolo actual
                if (estadoOrigen == estadoActual && simboloTransicion == simbolo)
                {
                    // Con el foreach se realiza la transición
                    foreach (string estadoSiguiente in estadosSiguientes)
                    {
                        //Se registra la transicion que fue realizada
                        transicionesRealizadas.Add($"{estadoActual},{simbolo},{estadoSiguiente}");

                        // Se validan de manera recursiva con el resto de la cadena, esto con la funcion de subcadena
                        cadenaValida = ValidarCadenaAFN(cadena.Substring(1), estadoSiguiente, transicionesRealizadas);

                        //Si en dado caso la cadena es completamente valida, se finaliza la transicion y se devuelve un true
                        if (cadenaValida)
                        {
                            return true; 
                        }

                        // Si en dado caso la cadena no es válida, se elimina la última transición
                        transicionesRealizadas.RemoveAt(transicionesRealizadas.Count - 1);
                    }
                }
            }
          // Se retorna el resultado de la validación
            return cadenaValida; 
        }

    }
}

  

