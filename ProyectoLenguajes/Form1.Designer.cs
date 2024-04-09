namespace ProyectoLenguajes
{
    partial class Form1
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
            this.BtnAbrir = new System.Windows.Forms.Button();
            this.RchMostrar = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // BtnAbrir
            // 
            this.BtnAbrir.Location = new System.Drawing.Point(70, 80);
            this.BtnAbrir.Name = "BtnAbrir";
            this.BtnAbrir.Size = new System.Drawing.Size(75, 23);
            this.BtnAbrir.TabIndex = 0;
            this.BtnAbrir.Text = "Abrir archivo";
            this.BtnAbrir.UseVisualStyleBackColor = true;
            this.BtnAbrir.Click += new System.EventHandler(this.BtnAbrir_Click);
            // 
            // RchMostrar
            // 
            this.RchMostrar.Location = new System.Drawing.Point(61, 134);
            this.RchMostrar.Name = "RchMostrar";
            this.RchMostrar.Size = new System.Drawing.Size(100, 96);
            this.RchMostrar.TabIndex = 1;
            this.RchMostrar.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RchMostrar);
            this.Controls.Add(this.BtnAbrir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnAbrir;
        private System.Windows.Forms.RichTextBox RchMostrar;
    }
}

