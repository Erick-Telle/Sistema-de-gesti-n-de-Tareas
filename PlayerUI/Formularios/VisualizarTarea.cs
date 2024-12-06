using PlayerUI.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayerUI.Formularios
{
    public partial class Form4 : Form
    {

        public Form4()
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
                dgvTareas.DataSource = null;
                dgvTareas.DataSource = tareas;

                if (!dgvTareas.Columns.Contains(""))
                {
                    // Crear la columna de botón
                    DataGridViewButtonColumn columnaEstado = new DataGridViewButtonColumn
                    {
                        Name = "Estado",
                        HeaderText = "Estado",
                        Text = "Pendiente", // Texto por defecto del botón
                        UseColumnTextForButtonValue = true
                    };

                    // Agregar la columna de botón al DataGridView
                    dgvTareas.Columns.Add(columnaEstado);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer el archivo: " + ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool isReloading = false;
        private void dgvTareas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (isReloading) return;
            try
            {
                if (e.RowIndex >= 0 && dgvTareas.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
                {
                    // Obtener los datos de la fila seleccionada
                    string tarea = dgvTareas.Rows[e.RowIndex].Cells["TituloTarea"].Value.ToString();
                    string Descripcionp = dgvTareas.Rows[e.RowIndex].Cells["Descripcion"].Value.ToString();
                    string FechaEntregap = dgvTareas.Rows[e.RowIndex].Cells["FechaEntrega"].Value.ToString();
                    string HoraEntregap = dgvTareas.Rows[e.RowIndex].Cells["HoraEntrega"].Value.ToString();
                    string Prioridadp = dgvTareas.Rows[e.RowIndex].Cells["Prioridad"].Value.ToString();

                    // Mostrar el formulario EstadoTarea
                    EstadoTarea estadoTarea = new EstadoTarea(tarea, Descripcionp, HoraEntregap, FechaEntregap, Prioridadp);
                    estadoTarea.Show();

                    isReloading = true;
                    RecargarDataGridView();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en CellClick: " + ex.Message);
            }
            finally
            {
                isReloading = false;
            }
        }


        private void RecargarDataGridView()
        {
            string rutaArchivo = @"C:\Users\User\Documents\Tareas.dat";
            TareaArchivo archivo = new TareaArchivo();

            try
            {
                // Leer datos del archivo
                List<eltTareas> tareas = archivo.LeerArchivoDat(rutaArchivo);

                // Ordenar las tareas alfabéticamente
                tareas.Sort((x, y) => x.TituloTarea.CompareTo(y.TituloTarea));

                // Recargar el DataGridView
                dgvTareas.DataSource = null;
                dgvTareas.DataSource = tareas;

                // Verificar si ya existe la columna de botón antes de agregarla
                if (!dgvTareas.Columns.Contains("Estado"))
                {
                    DataGridViewButtonColumn columnaEstado = new DataGridViewButtonColumn
                    {
                        Name = "Estado",
                        HeaderText = "Estado",
                        Text = "Pendiente", // Texto por defecto del botón
                        UseColumnTextForButtonValue = true
                    };

                    dgvTareas.Columns.Add(columnaEstado);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al recargar el DataGridView: " + ex.Message);
            }
        }

    }
}
