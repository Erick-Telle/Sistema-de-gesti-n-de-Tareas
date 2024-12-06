using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayerUI.Clases
{
    internal class TareaPendiente
    {
        public bool Recarga {  get; set; }
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

                            string descripcion = lector.ReadString();
                            string horaEntrega = lector.ReadString();



                            // Leer la fecha (como string en formato "yyyy-MM-dd")
                            string fechaString = lector.ReadString();
                            DateTime fechaEntrega = DateTime.ParseExact(fechaString, "yyyy-MM-dd", null);

                            string prioridad = lector.ReadString();

                            // Crear un objeto Tarea y agregarlo a la lista
                            eltTareas tarea = new eltTareas
                            {
                                TituloTarea = titulo,
                                Descripcion = descripcion,
                                HoraEntrega = horaEntrega,
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
                MessageBox.Show("Error al leer el archivo:/ " + ex.Message);
            }
            return tareas;
        }

        public void EliminarTarea(string rutaArchivo, string tituloTarea)
        {
            // Paso 1: Leer las tareas desde el archivo
            List<eltTareas> tareas = LeerArchivoDat(rutaArchivo);

            // Paso 2: Buscar la tarea a eliminar
            int indice = tareas.FindIndex(t => t.TituloTarea == tituloTarea);
            eltTareas tareaAEliminar = tareas.FirstOrDefault(t => t.TituloTarea == tituloTarea);

            if (indice != -1)
            {
                // Paso 3: Eliminar la tarea de la lista
                tareas.Remove(tareaAEliminar);

                // Paso 4: Guardar la lista actualizada en el archivo
                GuardarArchivoEdit(tareas, rutaArchivo);

                
            }
            else
            {
                MessageBox.Show("No se encontró la tarea con el título especificado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void GuardarArchivoEdit(List<eltTareas> tareas, string rutaArchivo)
        {
            using (FileStream archivo = new FileStream(rutaArchivo, FileMode.Create, FileAccess.Write))
            {
                using (BinaryWriter escritor = new BinaryWriter(archivo))
                {
                    foreach (eltTareas c in tareas)
                    {
                        escritor.Write(c.TituloTarea.Length);
                        escritor.Write(c.TituloTarea.ToCharArray());
                        escritor.Write(c.Descripcion);
                        escritor.Write(c.HoraEntrega.ToString());
                        escritor.Write(c.FechaEntrega.ToString("yyyy-MM-dd"));
                        escritor.Write(c.Prioridad);
                    }
                }
            }
        }
    }
}
