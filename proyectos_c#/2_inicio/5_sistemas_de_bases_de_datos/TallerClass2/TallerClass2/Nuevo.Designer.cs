namespace TallerClass2
{
    partial class Nuevo
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
            this.lbEstudiantes = new System.Windows.Forms.ListBox();
            this.lbSeleccionados = new System.Windows.Forms.ListBox();
            this.btnAgregsr = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbEstudiantes
            // 
            this.lbEstudiantes.FormattingEnabled = true;
            this.lbEstudiantes.Location = new System.Drawing.Point(27, 100);
            this.lbEstudiantes.Name = "lbEstudiantes";
            this.lbEstudiantes.Size = new System.Drawing.Size(168, 160);
            this.lbEstudiantes.TabIndex = 0;
            this.lbEstudiantes.SelectedIndexChanged += new System.EventHandler(this.lbEstudiantes_SelectedIndexChanged);
            // 
            // lbSeleccionados
            // 
            this.lbSeleccionados.FormattingEnabled = true;
            this.lbSeleccionados.Location = new System.Drawing.Point(298, 100);
            this.lbSeleccionados.Name = "lbSeleccionados";
            this.lbSeleccionados.Size = new System.Drawing.Size(180, 160);
            this.lbSeleccionados.TabIndex = 1;
            // 
            // btnAgregsr
            // 
            this.btnAgregsr.Location = new System.Drawing.Point(215, 148);
            this.btnAgregsr.Name = "btnAgregsr";
            this.btnAgregsr.Size = new System.Drawing.Size(53, 23);
            this.btnAgregsr.TabIndex = 2;
            this.btnAgregsr.Text = ">";
            this.btnAgregsr.UseVisualStyleBackColor = true;
            this.btnAgregsr.Click += new System.EventHandler(this.btnAgregsr_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(215, 204);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(53, 23);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "<";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // Nuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 324);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregsr);
            this.Controls.Add(this.lbSeleccionados);
            this.Controls.Add(this.lbEstudiantes);
            this.Name = "Nuevo";
            this.Text = "Nuevo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbEstudiantes;
        private System.Windows.Forms.ListBox lbSeleccionados;
        private System.Windows.Forms.Button btnAgregsr;
        private System.Windows.Forms.Button btnEliminar;
    }
}