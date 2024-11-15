using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayerUI.Clases
{
    internal class TareaArchivo
    {
        public void GuardarArchivo(List<eltTareas> tareas, string rutaArchivo)
        {

            using (FileStream archivo = new FileStream(rutaArchivo, FileMode.Append, FileAccess.Write))
            {
                using (BinaryWriter escritor = new BinaryWriter(archivo))
                {
                    foreach (eltTareas c in tareas)
                    {
                        escritor.Write(c.TituloTarea.Length);
                        escritor.Write(c.TituloTarea.ToCharArray());
                        escritor.Write(c.Descripcion);
                        escritor.Write(c.FechaEntrega.ToString("yyyy-MM-dd"));
                        escritor.Write(c.Prioridad);
                    }
                }
            }

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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer el archivo: " + ex.Message);
            }

            return tareas;
        }
    }
}
