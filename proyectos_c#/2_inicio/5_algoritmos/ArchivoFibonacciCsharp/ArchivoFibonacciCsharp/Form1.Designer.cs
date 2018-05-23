namespace ArchivoFibonacciCsharp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bcalcular = new System.Windows.Forms.Button();
            this.blimpiar = new System.Windows.Forms.Button();
            this.Lienzo1 = new ArchivoFibonacciCsharp.AreaDibujo();
            this.Lienzo2 = new ArchivoFibonacciCsharp.AreaDibujo();
            this.SuspendLayout();
            // 
            // bcalcular
            // 
            this.bcalcular.Location = new System.Drawing.Point(46, 60);
            this.bcalcular.Name = "bcalcular";
            this.bcalcular.Size = new System.Drawing.Size(75, 23);
            this.bcalcular.TabIndex = 0;
            this.bcalcular.Text = "Calcular";
            this.bcalcular.UseVisualStyleBackColor = true;
            this.bcalcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // blimpiar
            // 
            this.blimpiar.Location = new System.Drawing.Point(46, 101);
            this.blimpiar.Name = "blimpiar";
            this.blimpiar.Size = new System.Drawing.Size(75, 23);
            this.blimpiar.TabIndex = 3;
            this.blimpiar.Text = "Limpiar";
            this.blimpiar.UseVisualStyleBackColor = true;
            this.blimpiar.Click += new System.EventHandler(this.button2_Click);
            // 
            // Lienzo1
            // 
            this.Lienzo1.BackColor = System.Drawing.SystemColors.Window;
            this.Lienzo1.Location = new System.Drawing.Point(46, 141);
            this.Lienzo1.Name = "Lienzo1";
            this.Lienzo1.Size = new System.Drawing.Size(400, 400);
            this.Lienzo1.TabIndex = 4;
            this.Lienzo1.Paint += new System.Windows.Forms.PaintEventHandler(this.Lienzo1.paint);
            // 
            // Lienzo2
            // 
            this.Lienzo2.BackColor = System.Drawing.SystemColors.Window;
            this.Lienzo2.Location = new System.Drawing.Point(453, 141);
            this.Lienzo2.Name = "Lienzo2";
            this.Lienzo2.Size = new System.Drawing.Size(400, 400);
            this.Lienzo2.TabIndex = 5;
            this.Lienzo2.Paint += new System.Windows.Forms.PaintEventHandler(this.Lienzo2.paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(884, 562);
            this.Controls.Add(this.blimpiar);
            this.Controls.Add(this.bcalcular);
            this.Controls.Add(this.Lienzo1);
            this.Controls.Add(this.Lienzo2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bcalcular;
        private System.Windows.Forms.Button blimpiar;
        private AreaDibujo Lienzo1;
        private AreaDibujo Lienzo2;
    }
}

