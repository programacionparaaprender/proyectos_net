namespace TallerClass2
{
    partial class Form1
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
            this.btnLeerD = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLeerD
            // 
            this.btnLeerD.Location = new System.Drawing.Point(112, 67);
            this.btnLeerD.Name = "btnLeerD";
            this.btnLeerD.Size = new System.Drawing.Size(100, 55);
            this.btnLeerD.TabIndex = 8;
            this.btnLeerD.Text = "leer datos empleado";
            this.btnLeerD.UseVisualStyleBackColor = true;
            this.btnLeerD.Click += new System.EventHandler(this.btnLeerD_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(112, 143);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(100, 60);
            this.btnMostrar.TabIndex = 9;
            this.btnMostrar.Text = "ver datos empleado";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(112, 221);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(100, 66);
            this.btnNuevo.TabIndex = 10;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 376);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnLeerD);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLeerD;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnNuevo;
    }
}

