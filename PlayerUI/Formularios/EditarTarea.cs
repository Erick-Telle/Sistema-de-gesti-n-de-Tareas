using PlayerUI.Clases;
using PlayerUI.FormulatiosAyuda;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayerUI
{
    public partial class EditarTarea : Form
    {
        public EditarTarea()
        {
            InitializeComponent();
        }

        public void EditarDatos()
        {
            string rutaArchivo = @"C:\Users\User\Documents\Tareas.dat";
            TareaArchivo tareaEdit = new TareaArchivo();

            string Titulo = comboBoxTarea.Text;
            string NuevoTitulo = tbTitulo.Text;
            string NuevaDescripcion = tbDescripcion.Text;
            string NuevaHora = dtpHora.Text;
            DateTime NuevaFecha = DateTime.Parse(dtpFecha.Text);
            string NuevaPrioridad = LbPrioridad.Text;

            tareaEdit.EditarTarea(rutaArchivo, Titulo,NuevoTitulo, NuevaDescripcion, NuevaFecha, NuevaPrioridad);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardarEdit_Click(object sender, EventArgs e)
        {
            EditarDatos();
        }

        private void EditarTarea_Load(object sender, EventArgs e)
        {
            string rutaArchivo = @"C:\Users\User\Documents\Tareas.dat";
            TareaArchivo tareaArchivo = new TareaArchivo();
            List<eltTareas> tareas = tareaArchivo.LeerArchivoDat(rutaArchivo);

            // Mostrar los títulos en el ComboBox
            foreach (var tarea in tareas)
            {
                comboBoxTarea.Items.Add(tarea.TituloTarea);
            }

            foreach (var tarea in tareas)
            {
                listBox1.Items.Add(tarea.TituloTarea);
            }
        }

        private void comboBoxTarea_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tituloSeleccionado = comboBoxTarea.SelectedItem.ToString();
            string rutaArchivo = @"C:\Users\User\Documents\Tareas.dat";

            TareaArchivo tareaArchivo = new TareaArchivo();
            List<eltTareas> tareas = tareaArchivo.LeerArchivoDat(rutaArchivo);
            var tarea = tareas.FirstOrDefault(t => t.TituloTarea == tituloSeleccionado);

            if (!Object.ReferenceEquals(tarea, null))
            {
                tbTitulo.Text = tarea.TituloTarea;
                tbDescripcion.Text = tarea.Descripcion;
                dtpFecha.Value = tarea.FechaEntrega;
                LbPrioridad.Text = tarea.Prioridad;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            EditarAyuda editarAyuda = new EditarAyuda();
            editarAyuda.Show();
        }
    }
}