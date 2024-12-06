namespace PlayerUI.Formularios
{
    partial class EstadoTarea
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btTareaPendien = new System.Windows.Forms.Button();
            this.btTareaFinalis = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbDescripcion = new System.Windows.Forms.ListBox();
            this.lbFechaHora = new System.Windows.Forms.ListBox();
            this.lbPrioriti = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbTarea = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(20, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tarea:";
            // 
            // btTareaPendien
            // 
            this.btTareaPendien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btTareaPendien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.btTareaPendien.FlatAppearance.BorderSize = 0;
            this.btTareaPendien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTareaPendien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTareaPendien.ForeColor = System.Drawing.Color.White;
            this.btTareaPendien.Location = new System.Drawing.Point(266, 230);
            this.btTareaPendien.Name = "btTareaPendien";
            this.btTareaPendien.Size = new System.Drawing.Size(150, 40);
            this.btTareaPendien.TabIndex = 7;
            this.btTareaPendien.Text = "Tarea Pendiente";
            this.btTareaPendien.UseVisualStyleBackColor = false;
            this.btTareaPendien.Click += new System.EventHandler(this.btTareaPendien_Click);
            // 
            // btTareaFinalis
            // 
            this.btTareaFinalis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btTareaFinalis.BackColor = System.Drawing.Color.LimeGreen;
            this.btTareaFinalis.FlatAppearance.BorderSize = 0;
            this.btTareaFinalis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTareaFinalis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTareaFinalis.ForeColor = System.Drawing.Color.White;
            this.btTareaFinalis.Location = new System.Drawing.Point(431, 230);
            this.btTareaFinalis.Name = "btTareaFinalis";
            this.btTareaFinalis.Size = new System.Drawing.Size(150, 40);
            this.btTareaFinalis.TabIndex = 8;
            this.btTareaFinalis.Text = "Tarea Finalizada";
            this.btTareaFinalis.UseVisualStyleBackColor = false;
            this.btTareaFinalis.Click += new System.EventHandler(this.btTareaFinalis_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.LightGray;
            this.btnCancelar.Location = new System.Drawing.Point(100, 230);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(150, 40);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(20, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Descripcion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(186, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Fecha y Hora de entrega:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(406, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Prioridad:";
            // 
            // lbDescripcion
            // 
            this.lbDescripcion.FormattingEnabled = true;
            this.lbDescripcion.Location = new System.Drawing.Point(24, 63);
            this.lbDescripcion.Name = "lbDescripcion";
            this.lbDescripcion.Size = new System.Drawing.Size(138, 95);
            this.lbDescripcion.TabIndex = 2;
            // 
            // lbFechaHora
            // 
            this.lbFechaHora.FormattingEnabled = true;
            this.lbFechaHora.Location = new System.Drawing.Point(190, 64);
            this.lbFechaHora.Name = "lbFechaHora";
            this.lbFechaHora.Size = new System.Drawing.Size(185, 95);
            this.lbFechaHora.TabIndex = 3;
            // 
            // lbPrioriti
            // 
            this.lbPrioriti.FormattingEnabled = true;
            this.lbPrioriti.Location = new System.Drawing.Point(404, 64);
            this.lbPrioriti.Name = "lbPrioriti";
            this.lbPrioriti.Size = new System.Drawing.Size(120, 95);
            this.lbPrioriti.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbTarea);
            this.panel1.Controls.Add(this.lbPrioriti);
            this.panel1.Controls.Add(this.lbFechaHora);
            this.panel1.Controls.Add(this.lbDescripcion);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(26, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(553, 187);
            this.panel1.TabIndex = 3;
            // 
            // lbTarea
            // 
            this.lbTarea.AutoSize = true;
            this.lbTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTarea.ForeColor = System.Drawing.SystemColors.Control;
            this.lbTarea.Location = new System.Drawing.Point(80, 11);
            this.lbTarea.Name = "lbTarea";
            this.lbTarea.Size = new System.Drawing.Size(39, 20);
            this.lbTarea.TabIndex = 5;
            this.lbTarea.Text = "Text";
            // 
            // EstadoTarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(612, 295);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btTareaFinalis);
            this.Controls.Add(this.btTareaPendien);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EstadoTarea";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EstadoTarea";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btTareaPendien;
        private System.Windows.Forms.Button btTareaFinalis;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbDescripcion;
        private System.Windows.Forms.ListBox lbFechaHora;
        private System.Windows.Forms.ListBox lbPrioriti;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbTarea;
    }
}