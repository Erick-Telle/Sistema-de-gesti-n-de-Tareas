using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerUI.Clases
{
    public struct eltTareas
    {
        public string TituloTarea {  get; set; }
        public string Descripcion { get; set;}
        public string Prioridad { get; set;}    
        public DateTime FechaEntrega { get; set;}
    }
}
