namespace finalZoo
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRegAnimales = new System.Windows.Forms.Button();
            this.btnAnimalesEnf = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegAnimales
            // 
            this.btnRegAnimales.Location = new System.Drawing.Point(40, 57);
            this.btnRegAnimales.Name = "btnRegAnimales";
            this.btnRegAnimales.Size = new System.Drawing.Size(75, 23);
            this.btnRegAnimales.TabIndex = 0;
            this.btnRegAnimales.Text = "Registro de animales";
            this.btnRegAnimales.UseVisualStyleBackColor = true;
            this.btnRegAnimales.Click += new System.EventHandler(this.btnRegAnimales_Click);
            // 
            // btnAnimalesEnf
            // 
            this.btnAnimalesEnf.Location = new System.Drawing.Point(153, 57);
            this.btnAnimalesEnf.Name = "btnAnimalesEnf";
            this.btnAnimalesEnf.Size = new System.Drawing.Size(75, 23);
            this.btnAnimalesEnf.TabIndex = 1;
            this.btnAnimalesEnf.Text = "Enfermeria";
            this.btnAnimalesEnf.UseVisualStyleBackColor = true;
            this.btnAnimalesEnf.Click += new System.EventHandler(this.btnAnimalesEnf_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(92, 118);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 190);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAnimalesEnf);
            this.Controls.Add(this.btnRegAnimales);
            this.Name = "Inicio";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegAnimales;
        private System.Windows.Forms.Button btnAnimalesEnf;
        private System.Windows.Forms.Button btnSalir;
    }
}

