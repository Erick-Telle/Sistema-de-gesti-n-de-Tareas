using PlayerUI.Clases;
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

namespace PlayerUI
{
    public partial class Form2 : Form
    {
        private List<eltTareas> tareas;
        public eltTareas Tareas = new eltTareas();
        public Form2()
        {
            InitializeComponent();
            tareas = new List<eltTareas>();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            eltTareas tarea = new eltTareas();
            tarea.TituloTarea = tbTitulo.Text;
            tarea.Descripcion = tbDescripcion.Text;
            tarea.Prioridad = LbPrioridad.Text;
            tarea.FechaEntrega = dtpFecha.Value;

            tareas.Add(tarea);

            try
            {
                // Ruta de guardado predeterminada los documentos del usuario
                string rutaArchivo = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Tareas.dat");

                // Instancia de la clase para guardar
                TareaArchivo archivo = new TareaArchivo();

                // Guardar el archivo en la ubicación predeterminada
                archivo.GuardarArchivo(tareas, rutaArchivo);

                // Confirmación de guardado exitoso
                MessageBox.Show("La tarea ha sido creada exitosamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Mostrar mensaje de error en caso de excepción
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
