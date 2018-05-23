namespace TallerClass2
{
    partial class FrmLeerD
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
            this.lNombre = new System.Windows.Forms.Label();
            this.lApellido = new System.Windows.Forms.Label();
            this.lCedula = new System.Windows.Forms.Label();
            this.lFecha = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.tNombre = new System.Windows.Forms.TextBox();
            this.tApellido = new System.Windows.Forms.TextBox();
            this.tFecha = new System.Windows.Forms.TextBox();
            this.tCedula = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.Location = new System.Drawing.Point(52, 59);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(44, 13);
            this.lNombre.TabIndex = 0;
            this.lNombre.Text = "Nombre";
            // 
            // lApellido
            // 
            this.lApellido.AutoSize = true;
            this.lApellido.Location = new System.Drawing.Point(52, 98);
            this.lApellido.Name = "lApellido";
            this.lApellido.Size = new System.Drawing.Size(44, 13);
            this.lApellido.TabIndex = 1;
            this.lApellido.Text = "Apellido";
            // 
            // lCedula
            // 
            this.lCedula.AutoSize = true;
            this.lCedula.Location = new System.Drawing.Point(52, 172);
            this.lCedula.Name = "lCedula";
            this.lCedula.Size = new System.Drawing.Size(40, 13);
            this.lCedula.TabIndex = 2;
            this.lCedula.Text = "Cedula";
            // 
            // lFecha
            // 
            this.lFecha.AutoSize = true;
            this.lFecha.Location = new System.Drawing.Point(52, 138);
            this.lFecha.Name = "lFecha";
            this.lFecha.Size = new System.Drawing.Size(90, 13);
            this.lFecha.TabIndex = 3;
            this.lFecha.Text = "FechaNacimiento";
            this.lFecha.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnGuardar.Location = new System.Drawing.Point(86, 236);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(108, 64);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // tNombre
            // 
            this.tNombre.Location = new System.Drawing.Point(148, 56);
            this.tNombre.Name = "tNombre";
            this.tNombre.Size = new System.Drawing.Size(100, 20);
            this.tNombre.TabIndex = 5;
            // 
            // tApellido
            // 
            this.tApellido.Location = new System.Drawing.Point(148, 91);
            this.tApellido.Name = "tApellido";
            this.tApellido.Size = new System.Drawing.Size(100, 20);
            this.tApellido.TabIndex = 6;
            // 
            // tFecha
            // 
            this.tFecha.Location = new System.Drawing.Point(148, 131);
            this.tFecha.Name = "tFecha";
            this.tFecha.Size = new System.Drawing.Size(100, 20);
            this.tFecha.TabIndex = 7;
            // 
            // tCedula
            // 
            this.tCedula.Location = new System.Drawing.Point(148, 169);
            this.tCedula.Name = "tCedula";
            this.tCedula.Size = new System.Drawing.Size(100, 20);
            this.tCedula.TabIndex = 8;
            // 
            // FrmLeerD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 351);
            this.Controls.Add(this.tCedula);
            this.Controls.Add(this.tFecha);
            this.Controls.Add(this.tApellido);
            this.Controls.Add(this.tNombre);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lFecha);
            this.Controls.Add(this.lCedula);
            this.Controls.Add(this.lApellido);
            this.Controls.Add(this.lNombre);
            this.Name = "FrmLeerD";
            this.Text = "FrmLeerD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.Label lApellido;
        private System.Windows.Forms.Label lCedula;
        private System.Windows.Forms.Label lFecha;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox tNombre;
        private System.Windows.Forms.TextBox tApellido;
        private System.Windows.Forms.TextBox tFecha;
        private System.Windows.Forms.TextBox tCedula;
    }
}