using PlayerUI.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayerUI.Formularios
{
    public partial class EstadoTarea : Form
    {
        public EstadoTarea(string tarea,string Descripcionp,string HoraEntregap,string FechaEntregap,string Prioridadp)
        {   
            InitializeComponent();
            lbTarea.Text = tarea;
            lbDescripcion.Items.Add(Descripcionp);
            lbFechaHora.Items.Add(FechaEntregap+HoraEntregap);

            lbPrioriti.Items.Add(Prioridadp);
        }

        public void mostrarDatos(string tarea) 
        {
            TareaPendiente tareaPendiente = new TareaPendiente();
            string rutaArchivo = @"C:\Users\User\Documents\Tareas.dat";
            tareaPendiente.EliminarTarea(rutaArchivo, tarea);
        }
        
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btTareaFinalis_Click(object sender, EventArgs e)
        {
            string tarea = lbTarea.Text;
            mostrarDatos(tarea);
            
            this.Close();
        }

        private void btTareaPendien_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
