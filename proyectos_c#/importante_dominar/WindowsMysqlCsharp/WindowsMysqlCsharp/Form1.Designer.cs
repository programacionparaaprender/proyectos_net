namespace WindowsMysqlCsharp
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
            this.aceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcontrasenia = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // aceptar
            // 
            this.aceptar.Location = new System.Drawing.Point(15, 168);
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(75, 23);
            this.aceptar.TabIndex = 0;
            this.aceptar.Text = "aceptar";
            this.aceptar.UseVisualStyleBackColor = true;
            this.aceptar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "usuario\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(101, 103);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(100, 20);
            this.txtusuario.TabIndex = 2;
            this.txtusuario.TextChanged += new System.EventHandler(this.txtusuario_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "contraseña";
            // 
            // txtcontrasenia
            // 
            this.txtcontrasenia.Location = new System.Drawing.Point(101, 137);
            this.txtcontrasenia.Name = "txtcontrasenia";
            this.txtcontrasenia.Size = new System.Drawing.Size(100, 20);
            this.txtcontrasenia.TabIndex = 4;
            this.txtcontrasenia.TextChanged += new System.EventHandler(this.txtcontrasenia_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.txtcontrasenia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aceptar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button aceptar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcontrasenia;
    }
}

