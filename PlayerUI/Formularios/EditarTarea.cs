using PlayerUI.Clases;
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
            string rutaArchivo = @"C:\Users\User\Documents\Tareas.dat";
            LeerDatos(rutaArchivo);
        }

        public void LeerDatos(string rutaArchivo)
        {
            TareaArchivo archivo = new TareaArchivo();
            try
            {
                List<eltTareas> tareas = archivo.LeerArchivoDat(rutaArchivo);

                tareas.Sort((x, y) => x.TituloTarea.CompareTo(y.TituloTarea));
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = tareas;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer el archivo: " + ex.Message);
            }
        }

        public void EditarDatos()
        {
            string rutaArchivo = @"C:\Users\User\Documents\Tareas.dat";
            TareaArchivo tareaEdit = new TareaArchivo();

            string Titulo = tbTitulo.Text;
            string NuevaDescripcion = tbDescripcion.Text;
            DateTime NuevaFecha = DateTime.Parse(dtpFecha.Text);
            string NuevaPrioridad = LbPrioridad.Text;

            tareaEdit.EditarTarea(rutaArchivo, Titulo, NuevaDescripcion, NuevaFecha, NuevaPrioridad);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            string tituloBusqueda = tbTitulo.Text;

            // Verificar que el título no esté vacío
            if (string.IsNullOrEmpty(tituloBusqueda))
            {
                MessageBox.Show("Por favor ingrese un título válido para buscar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Buscar la fila que contiene el título en el DataGridView
            bool tareaEncontrada = false;

            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                if (fila.Cells["TituloTarea"].Value != null && fila.Cells["TituloTarea"].Value.ToString() == tituloBusqueda)
                {
                    tbDescripcion.Text = fila.Cells["Descripcion"].Value.ToString();
                    dtpFecha.Value = Convert.ToDateTime(fila.Cells["FechaEntrega"].Value); 
                    LbPrioridad.Text = fila.Cells["Prioridad"].Value.ToString();

                    tareaEncontrada = true;
                    break;
                }
            }

            // Si no se encontró la tarea
            if (!tareaEncontrada)
            {
                MessageBox.Show("No se encontró una tarea con ese título.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardarEdit_Click(object sender, EventArgs e)
        {
            EditarDatos();

        }
    }
}
