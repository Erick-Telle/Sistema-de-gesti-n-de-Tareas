using PlayerUI.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayerUI.Formularios
{
    public partial class EliminarTarea : Form
    {
        public EliminarTarea()
        {
            InitializeComponent();
        }

        private void EliminarTarea_Load(object sender, EventArgs e)
        {
            string rutaArchivo = @"C:\Users\User\Documents\Tareas.dat";
            TareaArchivo tareaArchivo = new TareaArchivo();
            List<eltTareas> tareas = tareaArchivo.LeerArchivoDat(rutaArchivo);

            // Mostrar los títulos en el ComboBox
            foreach (var tarea in tareas)
            {
                comboBoxTarea.Items.Add(tarea.TituloTarea);
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
                tbPrioridad.Text = tarea.Prioridad;
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string tituloSeleccionado = comboBoxTarea.SelectedItem?.ToString();
            string rutaArchivo = @"C:\Users\User\Documents\Tareas.dat";

            TareaArchivo tareaArchivo = new TareaArchivo();

            if (string.IsNullOrEmpty(tituloSeleccionado))
            {
                MessageBox.Show("Por favor selecciona una tarea para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Confirmación antes de eliminar
            DialogResult resultado = MessageBox.Show($"¿Estás seguro de eliminar la tarea '{tituloSeleccionado}'?",
                                                     "Confirmar Eliminación",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                // Eliminar la tarea
                List<eltTareas> tareas = tareaArchivo.LeerArchivoDat(rutaArchivo);
                tareas.RemoveAll(t => t.TituloTarea == tituloSeleccionado);

                // Guardar los cambios en el archivo
                tareaArchivo.GuardarArchivoEdit(tareas, rutaArchivo);

                // Actualizar la UI
                comboBoxTarea.Items.Remove(tituloSeleccionado);
                MessageBox.Show("La tarea fue eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
