namespace ConectaClase
{
    partial class Agregar
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
            this.tbSalario = new System.Windows.Forms.TextBox();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbidEmpleado = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lbSalario = new System.Windows.Forms.Label();
            this.lbDireccion = new System.Windows.Forms.Label();
            this.lbApellido = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbidEmpleado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbSalario
            // 
            this.tbSalario.Location = new System.Drawing.Point(151, 245);
            this.tbSalario.Name = "tbSalario";
            this.tbSalario.Size = new System.Drawing.Size(100, 20);
            this.tbSalario.TabIndex = 21;
            // 
            // tbDireccion
            // 
            this.tbDireccion.Location = new System.Drawing.Point(151, 201);
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(100, 20);
            this.tbDireccion.TabIndex = 20;
            // 
            // tbApellido
            // 
            this.tbApellido.Location = new System.Drawing.Point(151, 158);
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(100, 20);
            this.tbApellido.TabIndex = 19;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(150, 121);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(101, 20);
            this.tbNombre.TabIndex = 18;
            // 
            // tbidEmpleado
            // 
            this.tbidEmpleado.Location = new System.Drawing.Point(150, 74);
            this.tbidEmpleado.Name = "tbidEmpleado";
            this.tbidEmpleado.Size = new System.Drawing.Size(100, 20);
            this.tbidEmpleado.TabIndex = 17;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(100, 299);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(270, 23);
            this.btnAgregar.TabIndex = 16;
            this.btnAgregar.Text = "Agregar empleado";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lbSalario
            // 
            this.lbSalario.AutoSize = true;
            this.lbSalario.Location = new System.Drawing.Point(61, 248);
            this.lbSalario.Name = "lbSalario";
            this.lbSalario.Size = new System.Drawing.Size(39, 13);
            this.lbSalario.TabIndex = 15;
            this.lbSalario.Text = "Salario";
            // 
            // lbDireccion
            // 
            this.lbDireccion.AutoSize = true;
            this.lbDireccion.Location = new System.Drawing.Point(61, 201);
            this.lbDireccion.Name = "lbDireccion";
            this.lbDireccion.Size = new System.Drawing.Size(52, 13);
            this.lbDireccion.TabIndex = 14;
            this.lbDireccion.Text = "Direccion";
            // 
            // lbApellido
            // 
            this.lbApellido.AutoSize = true;
            this.lbApellido.Location = new System.Drawing.Point(61, 158);
            this.lbApellido.Name = "lbApellido";
            this.lbApellido.Size = new System.Drawing.Size(44, 13);
            this.lbApellido.TabIndex = 13;
            this.lbApellido.Text = "Apellido";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(61, 121);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(44, 13);
            this.lbNombre.TabIndex = 12;
            this.lbNombre.Text = "Nombre";
            // 
            // lbidEmpleado
            // 
            this.lbidEmpleado.AutoSize = true;
            this.lbidEmpleado.Location = new System.Drawing.Point(61, 74);
            this.lbidEmpleado.Name = "lbidEmpleado";
            this.lbidEmpleado.Size = new System.Drawing.Size(62, 13);
            this.lbidEmpleado.TabIndex = 11;
            this.lbidEmpleado.Text = "idEmpleado";
            // 
            // Agregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 401);
            this.Controls.Add(this.tbSalario);
            this.Controls.Add(this.tbDireccion);
            this.Controls.Add(this.tbApellido);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.tbidEmpleado);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lbSalario);
            this.Controls.Add(this.lbDireccion);
            this.Controls.Add(this.lbApellido);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.lbidEmpleado);
            this.Name = "Agregar";
            this.Text = "Agregar";
            this.Load += new System.EventHandler(this.Agregar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSalario;
        private System.Windows.Forms.TextBox tbDireccion;
        private System.Windows.Forms.TextBox tbApellido;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbidEmpleado;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lbSalario;
        private System.Windows.Forms.Label lbDireccion;
        private System.Windows.Forms.Label lbApellido;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbidEmpleado;
    }
}