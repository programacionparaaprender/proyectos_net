namespace TallerClass2
{
    partial class FrmVerDatosEmp
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
            this.cbxLista = new System.Windows.Forms.ComboBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lNombre = new System.Windows.Forms.Label();
            this.lApellido = new System.Windows.Forms.Label();
            this.lEdad = new System.Windows.Forms.Label();
            this.lbSeleccionados = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cbxLista
            // 
            this.cbxLista.FormattingEnabled = true;
            this.cbxLista.Location = new System.Drawing.Point(57, 40);
            this.cbxLista.Name = "cbxLista";
            this.cbxLista.Size = new System.Drawing.Size(163, 21);
            this.cbxLista.TabIndex = 0;
            this.cbxLista.SelectionChangeCommitted += new System.EventHandler(this.cbxLista_SelectionChangeCommitted);
            this.cbxLista.SelectedIndexChanged += new System.EventHandler(this.cbxLista_SelectedIndexChanged);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(88, 180);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(114, 64);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.Location = new System.Drawing.Point(123, 81);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(44, 13);
            this.lNombre.TabIndex = 2;
            this.lNombre.Text = "Nombre";
            // 
            // lApellido
            // 
            this.lApellido.AutoSize = true;
            this.lApellido.Location = new System.Drawing.Point(123, 106);
            this.lApellido.Name = "lApellido";
            this.lApellido.Size = new System.Drawing.Size(44, 13);
            this.lApellido.TabIndex = 3;
            this.lApellido.Text = "Apellido";
            // 
            // lEdad
            // 
            this.lEdad.AutoSize = true;
            this.lEdad.Location = new System.Drawing.Point(123, 130);
            this.lEdad.Name = "lEdad";
            this.lEdad.Size = new System.Drawing.Size(32, 13);
            this.lEdad.TabIndex = 4;
            this.lEdad.Text = "Edad";
            // 
            // lbSeleccionados
            // 
            this.lbSeleccionados.FormattingEnabled = true;
            this.lbSeleccionados.Location = new System.Drawing.Point(286, 40);
            this.lbSeleccionados.Name = "lbSeleccionados";
            this.lbSeleccionados.Size = new System.Drawing.Size(177, 160);
            this.lbSeleccionados.TabIndex = 5;
            // 
            // FrmVerDatosEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 273);
            this.Controls.Add(this.lbSeleccionados);
            this.Controls.Add(this.lEdad);
            this.Controls.Add(this.lApellido);
            this.Controls.Add(this.lNombre);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.cbxLista);
            this.Name = "FrmVerDatosEmp";
            this.Text = "FrmVerDatosEmp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        public System.Windows.Forms.ComboBox cbxLista;
        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.Label lApellido;
        private System.Windows.Forms.Label lEdad;
        private System.Windows.Forms.ListBox lbSeleccionados;
    }
}