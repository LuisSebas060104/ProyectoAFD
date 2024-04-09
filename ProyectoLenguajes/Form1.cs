using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoLenguajes
{
    public partial class Form1 : Form
    {
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
    }
    }

