namespace LenguajePOO
{
    partial class Ventana
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventana));
            this.bcalcular = new System.Windows.Forms.Button();
            this.lRectangulo = new System.Windows.Forms.Label();
            this.lTriangulo = new System.Windows.Forms.Label();
            this.lbase = new System.Windows.Forms.Label();
            this.laltura = new System.Windows.Forms.Label();
            this.tbaserec = new System.Windows.Forms.TextBox();
            this.talturarec = new System.Windows.Forms.TextBox();
            this.tbasetri = new System.Windows.Forms.TextBox();
            this.talturatri = new System.Windows.Forms.TextBox();
            this.larea = new System.Windows.Forms.Label();
            this.larearec = new System.Windows.Forms.Label();
            this.lareatri = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bcalcular
            // 
            this.bcalcular.Location = new System.Drawing.Point(39, 296);
            this.bcalcular.Name = "bcalcular";
            this.bcalcular.Size = new System.Drawing.Size(75, 23);
            this.bcalcular.TabIndex = 0;
            this.bcalcular.Text = "Calcular";
            this.bcalcular.UseVisualStyleBackColor = true;
            this.bcalcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // lRectangulo
            // 
            this.lRectangulo.AutoSize = true;
            this.lRectangulo.Location = new System.Drawing.Point(175, 33);
            this.lRectangulo.Name = "lRectangulo";
            this.lRectangulo.Size = new System.Drawing.Size(62, 13);
            this.lRectangulo.TabIndex = 1;
            this.lRectangulo.Text = "Rectangulo";
            // 
            // lTriangulo
            // 
            this.lTriangulo.AutoSize = true;
            this.lTriangulo.Location = new System.Drawing.Point(288, 33);
            this.lTriangulo.Name = "lTriangulo";
            this.lTriangulo.Size = new System.Drawing.Size(51, 13);
            this.lTriangulo.TabIndex = 2;
            this.lTriangulo.Text = "Triangulo";
            // 
            // lbase
            // 
            this.lbase.AutoSize = true;
            this.lbase.Location = new System.Drawing.Point(36, 104);
            this.lbase.Name = "lbase";
            this.lbase.Size = new System.Drawing.Size(30, 13);
            this.lbase.TabIndex = 3;
            this.lbase.Text = "base";
            // 
            // laltura
            // 
            this.laltura.AutoSize = true;
            this.laltura.Location = new System.Drawing.Point(39, 172);
            this.laltura.Name = "laltura";
            this.laltura.Size = new System.Drawing.Size(33, 13);
            this.laltura.TabIndex = 4;
            this.laltura.Text = "altura";
            // 
            // tbaserec
            // 
            this.tbaserec.Location = new System.Drawing.Point(178, 97);
            this.tbaserec.Name = "tbaserec";
            this.tbaserec.Size = new System.Drawing.Size(100, 20);
            this.tbaserec.TabIndex = 5;
            // 
            // talturarec
            // 
            this.talturarec.Location = new System.Drawing.Point(178, 165);
            this.talturarec.Name = "talturarec";
            this.talturarec.Size = new System.Drawing.Size(100, 20);
            this.talturarec.TabIndex = 6;
            // 
            // tbasetri
            // 
            this.tbasetri.Location = new System.Drawing.Point(291, 97);
            this.tbasetri.Name = "tbasetri";
            this.tbasetri.Size = new System.Drawing.Size(100, 20);
            this.tbasetri.TabIndex = 7;
            // 
            // talturatri
            // 
            this.talturatri.Location = new System.Drawing.Point(291, 165);
            this.talturatri.Name = "talturatri";
            this.talturatri.Size = new System.Drawing.Size(100, 20);
            this.talturatri.TabIndex = 8;
            // 
            // larea
            // 
            this.larea.AutoSize = true;
            this.larea.Location = new System.Drawing.Point(39, 228);
            this.larea.Name = "larea";
            this.larea.Size = new System.Drawing.Size(29, 13);
            this.larea.TabIndex = 9;
            this.larea.Text = "Area";
            // 
            // larearec
            // 
            this.larearec.AutoSize = true;
            this.larearec.Location = new System.Drawing.Point(178, 228);
            this.larearec.Name = "larearec";
            this.larearec.Size = new System.Drawing.Size(52, 13);
            this.larearec.TabIndex = 10;
            this.larearec.Text = "aun nada";
            // 
            // lareatri
            // 
            this.lareatri.AutoSize = true;
            this.lareatri.Location = new System.Drawing.Point(291, 228);
            this.lareatri.Name = "lareatri";
            this.lareatri.Size = new System.Drawing.Size(52, 13);
            this.lareatri.TabIndex = 11;
            this.lareatri.Text = "aun nada";
            // 
            // Ventana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(492, 385);
            this.Controls.Add(this.lareatri);
            this.Controls.Add(this.larearec);
            this.Controls.Add(this.larea);
            this.Controls.Add(this.talturatri);
            this.Controls.Add(this.tbasetri);
            this.Controls.Add(this.talturarec);
            this.Controls.Add(this.tbaserec);
            this.Controls.Add(this.laltura);
            this.Controls.Add(this.lbase);
            this.Controls.Add(this.lTriangulo);
            this.Controls.Add(this.lRectangulo);
            this.Controls.Add(this.bcalcular);
            this.Name = "Ventana";
            this.Text = "Ventana";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bcalcular;
        private System.Windows.Forms.Label lRectangulo;
        private System.Windows.Forms.Label lTriangulo;
        private System.Windows.Forms.Label lbase;
        private System.Windows.Forms.Label laltura;
        private System.Windows.Forms.TextBox tbaserec;
        private System.Windows.Forms.TextBox talturarec;
        private System.Windows.Forms.TextBox tbasetri;
        private System.Windows.Forms.TextBox talturatri;
        private System.Windows.Forms.Label larea;
        private System.Windows.Forms.Label larearec;
        private System.Windows.Forms.Label lareatri;
    }
}