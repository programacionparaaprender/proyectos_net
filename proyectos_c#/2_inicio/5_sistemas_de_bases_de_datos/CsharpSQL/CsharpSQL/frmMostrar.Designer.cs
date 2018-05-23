namespace CsharpSQL
{
    partial class frmMostrar
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
            this.dgvMostrar = new System.Windows.Forms.DataGridView();
            this.btnEstudiante = new System.Windows.Forms.Button();
            this.btnProfesores = new System.Windows.Forms.Button();
            this.btnDepartamento = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMostrar
            // 
            this.dgvMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrar.Location = new System.Drawing.Point(248, 12);
            this.dgvMostrar.Name = "dgvMostrar";
            this.dgvMostrar.Size = new System.Drawing.Size(452, 329);
            this.dgvMostrar.TabIndex = 0;
            // 
            // btnEstudiante
            // 
            this.btnEstudiante.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnEstudiante.Location = new System.Drawing.Point(23, 12);
            this.btnEstudiante.Name = "btnEstudiante";
            this.btnEstudiante.Size = new System.Drawing.Size(110, 48);
            this.btnEstudiante.TabIndex = 1;
            this.btnEstudiante.Text = "Mostrar estudiantes";
            this.btnEstudiante.UseVisualStyleBackColor = false;
            this.btnEstudiante.Click += new System.EventHandler(this.btnEstudiante_Click);
            // 
            // btnProfesores
            // 
            this.btnProfesores.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnProfesores.Location = new System.Drawing.Point(23, 82);
            this.btnProfesores.Name = "btnProfesores";
            this.btnProfesores.Size = new System.Drawing.Size(110, 48);
            this.btnProfesores.TabIndex = 2;
            this.btnProfesores.Text = "Mostrar profesores";
            this.btnProfesores.UseVisualStyleBackColor = false;
            this.btnProfesores.Click += new System.EventHandler(this.btnProfesores_Click);
            // 
            // btnDepartamento
            // 
            this.btnDepartamento.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnDepartamento.Location = new System.Drawing.Point(23, 151);
            this.btnDepartamento.Name = "btnDepartamento";
            this.btnDepartamento.Size = new System.Drawing.Size(110, 48);
            this.btnDepartamento.TabIndex = 3;
            this.btnDepartamento.Text = "Mostrar departamentos";
            this.btnDepartamento.UseVisualStyleBackColor = false;
            this.btnDepartamento.Click += new System.EventHandler(this.btnDepartamento_Click);
            // 
            // frmMostrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(722, 366);
            this.Controls.Add(this.btnDepartamento);
            this.Controls.Add(this.btnProfesores);
            this.Controls.Add(this.btnEstudiante);
            this.Controls.Add(this.dgvMostrar);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "frmMostrar";
            this.Text = "frmMostrar";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMostrar;
        private System.Windows.Forms.Button btnEstudiante;
        private System.Windows.Forms.Button btnProfesores;
        private System.Windows.Forms.Button btnDepartamento;
    }
}