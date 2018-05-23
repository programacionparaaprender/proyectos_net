namespace TallerBaseDatos
{
    partial class Ventana
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lNombre = new System.Windows.Forms.Label();
            this.lApellido = new System.Windows.Forms.Label();
            this.lCedula = new System.Windows.Forms.Label();
            this.lFecha = new System.Windows.Forms.Label();
            this.tNombre = new System.Windows.Forms.TextBox();
            this.tApellido = new System.Windows.Forms.TextBox();
            this.tCedula = new System.Windows.Forms.TextBox();
            this.tFecha = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.Location = new System.Drawing.Point(46, 48);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(47, 13);
            this.lNombre.TabIndex = 0;
            this.lNombre.Text = "Nombre:";
            // 
            // lApellido
            // 
            this.lApellido.AutoSize = true;
            this.lApellido.Location = new System.Drawing.Point(46, 79);
            this.lApellido.Name = "lApellido";
            this.lApellido.Size = new System.Drawing.Size(47, 13);
            this.lApellido.TabIndex = 1;
            this.lApellido.Text = "Apellido:";
            // 
            // lCedula
            // 
            this.lCedula.AutoSize = true;
            this.lCedula.Location = new System.Drawing.Point(46, 112);
            this.lCedula.Name = "lCedula";
            this.lCedula.Size = new System.Drawing.Size(23, 13);
            this.lCedula.TabIndex = 2;
            this.lCedula.Text = "C.I.";
            // 
            // lFecha
            // 
            this.lFecha.AutoSize = true;
            this.lFecha.Location = new System.Drawing.Point(46, 140);
            this.lFecha.Name = "lFecha";
            this.lFecha.Size = new System.Drawing.Size(106, 13);
            this.lFecha.TabIndex = 3;
            this.lFecha.Text = "Fecha de nacimiento";
            // 
            // tNombre
            // 
            this.tNombre.Location = new System.Drawing.Point(177, 45);
            this.tNombre.Name = "tNombre";
            this.tNombre.Size = new System.Drawing.Size(132, 20);
            this.tNombre.TabIndex = 4;
            // 
            // tApellido
            // 
            this.tApellido.Location = new System.Drawing.Point(177, 76);
            this.tApellido.Name = "tApellido";
            this.tApellido.Size = new System.Drawing.Size(132, 20);
            this.tApellido.TabIndex = 5;
            // 
            // tCedula
            // 
            this.tCedula.Location = new System.Drawing.Point(177, 112);
            this.tCedula.Name = "tCedula";
            this.tCedula.Size = new System.Drawing.Size(132, 20);
            this.tCedula.TabIndex = 6;
            // 
            // tFecha
            // 
            this.tFecha.Location = new System.Drawing.Point(177, 140);
            this.tFecha.Name = "tFecha";
            this.tFecha.Size = new System.Drawing.Size(132, 20);
            this.tFecha.TabIndex = 7;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(123, 183);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // Ventana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 370);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.tFecha);
            this.Controls.Add(this.tCedula);
            this.Controls.Add(this.tApellido);
            this.Controls.Add(this.tNombre);
            this.Controls.Add(this.lFecha);
            this.Controls.Add(this.lCedula);
            this.Controls.Add(this.lApellido);
            this.Controls.Add(this.lNombre);
            this.Name = "Ventana";
            this.Text = "Ventana";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.Label lApellido;
        private System.Windows.Forms.Label lCedula;
        private System.Windows.Forms.Label lFecha;
        private System.Windows.Forms.TextBox tNombre;
        private System.Windows.Forms.TextBox tApellido;
        private System.Windows.Forms.TextBox tCedula;
        private System.Windows.Forms.TextBox tFecha;
        private System.Windows.Forms.Button btnAceptar;
    }
}

