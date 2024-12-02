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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PlayerUI
{
    public partial class CrearTarea : Form
    {
        private List<eltTareas> tareas;
        

        public CrearTarea()
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
            if (string.IsNullOrWhiteSpace(tbTitulo.Text) || string.IsNullOrWhiteSpace(tbDescripcion.Text) || string.IsNullOrWhiteSpace(LbPrioridad.Text))
            {
                const string message = "Por favor rellene todos los parametros para poder continuar";
                MessageBox.Show(message, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                eltTareas tarea = new eltTareas();
                tarea.TituloTarea = tbTitulo.Text;
                tarea.Descripcion = tbDescripcion.Text;
                tarea.Prioridad = LbPrioridad.Text;
                tarea.HoraEntrega = dtpHora.Value;

                if( dtpFecha.Value < DateTime.Now && dtpHora.Value < DateTime.Now)
                {
                    MessageBox.Show("No puedes crear una Tarea con fecha anterior a la de hoy", "", MessageBoxButtons.OK, MessageBoxIcon.Error);                    
                }
                else
                {
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

                        MessageBox.Show("La tarea ha sido creada exitosamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        tbTitulo.Clear();
                        tbDescripcion.Clear();
                        tbTitulo.Focus();
                    }
                    catch (Exception ex)
                    {
                        // Mostrar mensaje de error en caso de excepción
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
