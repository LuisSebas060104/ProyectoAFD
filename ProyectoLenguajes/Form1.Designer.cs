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
            this.components = new System.ComponentModel.Container();
            this.BtnAbrir = new System.Windows.Forms.Button();
            this.RchMostrar = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Txtcadena = new System.Windows.Forms.TextBox();
            this.BtnValidarCadena = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.RchTransicion = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnAbrir
            // 
            this.BtnAbrir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAbrir.Location = new System.Drawing.Point(93, 117);
            this.BtnAbrir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnAbrir.Name = "BtnAbrir";
            this.BtnAbrir.Size = new System.Drawing.Size(100, 28);
            this.BtnAbrir.TabIndex = 0;
            this.BtnAbrir.Text = "Abrir archivo";
            this.BtnAbrir.UseVisualStyleBackColor = true;
            this.BtnAbrir.Click += new System.EventHandler(this.BtnAbrir_Click);
            // 
            // RchMostrar
            // 
            this.RchMostrar.Location = new System.Drawing.Point(81, 182);
            this.RchMostrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RchMostrar.Name = "RchMostrar";
            this.RchMostrar.Size = new System.Drawing.Size(300, 313);
            this.RchMostrar.TabIndex = 1;
            this.RchMostrar.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccione un archivo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(525, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingrese una cadena";
            // 
            // Txtcadena
            // 
            this.Txtcadena.Location = new System.Drawing.Point(529, 119);
            this.Txtcadena.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txtcadena.Name = "Txtcadena";
            this.Txtcadena.Size = new System.Drawing.Size(351, 22);
            this.Txtcadena.TabIndex = 4;
            // 
            // BtnValidarCadena
            // 
            this.BtnValidarCadena.Location = new System.Drawing.Point(529, 151);
            this.BtnValidarCadena.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnValidarCadena.Name = "BtnValidarCadena";
            this.BtnValidarCadena.Size = new System.Drawing.Size(148, 28);
            this.BtnValidarCadena.TabIndex = 5;
            this.BtnValidarCadena.Text = "Validar cadena";
            this.BtnValidarCadena.UseVisualStyleBackColor = true;
            this.BtnValidarCadena.Click += new System.EventHandler(this.BtnValidarCadena_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(256, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(444, 36);
            this.label3.TabIndex = 6;
            this.label3.Text = "Automatas Finitos Deterministas";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::ProyectoLenguajes.Properties.Resources.clouds_gradient_minimalist_desktop_wallpaper_preview;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.RchTransicion);
            this.panel1.Controls.Add(this.Txtcadena);
            this.panel1.Controls.Add(this.BtnValidarCadena);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(3, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1043, 551);
            this.panel1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(525, 199);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(288, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Transiciones de la cadena ingresada:\r\n";
            // 
            // RchTransicion
            // 
            this.RchTransicion.Location = new System.Drawing.Point(531, 234);
            this.RchTransicion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RchTransicion.Name = "RchTransicion";
            this.RchTransicion.Size = new System.Drawing.Size(335, 260);
            this.RchTransicion.TabIndex = 6;
            this.RchTransicion.Text = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(96, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Archivo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1039, 554);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RchMostrar);
            this.Controls.Add(this.BtnAbrir);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label5;
    }
}

