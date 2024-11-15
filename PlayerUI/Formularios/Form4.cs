using PlayerUI.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayerUI.Formularios
{
    public partial class Form4 : Form
    {

        public Form4()
        {
            InitializeComponent();
            string rutaArchivo = @"C:\Users\User\Documents\Tareas.dat";  // Cambia la ruta por la que desees
            List<eltTareas> tareas = LeerArchivoDat(rutaArchivo);
        }
        public List<eltTareas> LeerArchivoDat(string rutaArchivo)
        {
            var tareas = new List<eltTareas>();

            try
            {
                using (FileStream archivo = new FileStream(rutaArchivo, FileMode.Open, FileAccess.Read))
                {
                    using (BinaryReader lector = new BinaryReader(archivo))
                    {
                        while (lector.BaseStream.Position < lector.BaseStream.Length)
                        {
                            // Leer el tamaño del título y luego el título
                            int tamañoTitulo = lector.ReadInt32();
                            char[] tituloArray = lector.ReadChars(tamañoTitulo);
                            string titulo = new string(tituloArray);

                            // Leer la descripción
                            string descripcion = lector.ReadString();

                            // Leer la fecha (como string en formato "yyyy-MM-dd")
                            string fechaString = lector.ReadString();
                            DateTime fechaEntrega = DateTime.ParseExact(fechaString, "yyyy-MM-dd", null);

                            // Leer la prioridad
                            string prioridad = lector.ReadString();

                            // Crear un objeto Tarea y agregarlo a la lista
                            eltTareas tarea = new eltTareas
                            {
                                TituloTarea = titulo,
                                Descripcion = descripcion,
                                FechaEntrega = fechaEntrega,
                                Prioridad = prioridad
                            };
                            tareas.Add(tarea);
                        }
                    }
                }

                tareas.Sort((x, y) => x.TituloTarea.CompareTo(y.TituloTarea));
                dgvTareas.DataSource = null;
                dgvTareas.DataSource = tareas;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer el archivo: " + ex.Message);
            }

            return tareas;
        }
    }
}
