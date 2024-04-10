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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Txtcadena = new System.Windows.Forms.TextBox();
            this.BtnValidarCadena = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RchTransicion = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnAbrir
            // 
            this.BtnAbrir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAbrir.Location = new System.Drawing.Point(70, 95);
            this.BtnAbrir.Name = "BtnAbrir";
            this.BtnAbrir.Size = new System.Drawing.Size(75, 23);
            this.BtnAbrir.TabIndex = 0;
            this.BtnAbrir.Text = "Abrir archivo";
            this.BtnAbrir.UseVisualStyleBackColor = true;
            this.BtnAbrir.Click += new System.EventHandler(this.BtnAbrir_Click);
            // 
            // RchMostrar
            // 
            this.RchMostrar.Location = new System.Drawing.Point(61, 148);
            this.RchMostrar.Name = "RchMostrar";
            this.RchMostrar.Size = new System.Drawing.Size(226, 255);
            this.RchMostrar.TabIndex = 1;
            this.RchMostrar.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccione un archivo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(396, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingrese una cadena";
            // 
            // Txtcadena
            // 
            this.Txtcadena.Location = new System.Drawing.Point(399, 107);
            this.Txtcadena.Name = "Txtcadena";
            this.Txtcadena.Size = new System.Drawing.Size(264, 20);
            this.Txtcadena.TabIndex = 4;
            // 
            // BtnValidarCadena
            // 
            this.BtnValidarCadena.Location = new System.Drawing.Point(398, 133);
            this.BtnValidarCadena.Name = "BtnValidarCadena";
            this.BtnValidarCadena.Size = new System.Drawing.Size(111, 23);
            this.BtnValidarCadena.TabIndex = 5;
            this.BtnValidarCadena.Text = "Validar cadena";
            this.BtnValidarCadena.UseVisualStyleBackColor = true;
            this.BtnValidarCadena.Click += new System.EventHandler(this.BtnValidarCadena_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(192, 14);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(355, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "Automatas Finitos Deterministas";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::ProyectoLenguajes.Properties.Resources.clouds_gradient_minimalist_desktop_wallpaper_preview;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.RchTransicion);
            this.panel1.Controls.Add(this.BtnValidarCadena);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 448);
            this.panel1.TabIndex = 7;
            // 
            // RchTransicion
            // 
            this.RchTransicion.Location = new System.Drawing.Point(398, 162);
            this.RchTransicion.Name = "RchTransicion";
            this.RchTransicion.Size = new System.Drawing.Size(252, 240);
            this.RchTransicion.TabIndex = 6;
            this.RchTransicion.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(779, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txtcadena);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RchMostrar);
            this.Controls.Add(this.BtnAbrir);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAbrir;
        private System.Windows.Forms.RichTextBox RchMostrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txtcadena;
        private System.Windows.Forms.Button BtnValidarCadena;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox RchTransicion;
    }
}

