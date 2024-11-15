using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    }
}
