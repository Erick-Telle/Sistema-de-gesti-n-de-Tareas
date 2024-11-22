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
    }
}
