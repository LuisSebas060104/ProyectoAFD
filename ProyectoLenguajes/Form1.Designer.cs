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
            this.label3 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RchTransicion = new System.Windows.Forms.RichTextBox();
            this.Txtcadena = new System.Windows.Forms.TextBox();
            this.BtnValidarCadena = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.BtnAbrirN = new System.Windows.Forms.Button();
            this.RchMostrarN = new System.Windows.Forms.RichTextBox();
            this.RchValidarN = new System.Windows.Forms.RichTextBox();
            this.BtnValidarN = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnAbrir
            // 
            this.BtnAbrir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAbrir.Location = new System.Drawing.Point(23, 100);
            this.BtnAbrir.Name = "BtnAbrir";
            this.BtnAbrir.Size = new System.Drawing.Size(75, 23);
            this.BtnAbrir.TabIndex = 0;
            this.BtnAbrir.Text = "Abrir archivo";
            this.BtnAbrir.UseVisualStyleBackColor = true;
            this.BtnAbrir.Click += new System.EventHandler(this.BtnAbrir_Click);
            // 
            // RchMostrar
            // 
            this.RchMostrar.Location = new System.Drawing.Point(23, 157);
            this.RchMostrar.Name = "RchMostrar";
            this.RchMostrar.Size = new System.Drawing.Size(226, 226);
            this.RchMostrar.TabIndex = 1;
            this.RchMostrar.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccione un archivo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(232, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Automatas Finitos Deterministas";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::ProyectoLenguajes.Properties.Resources.clouds_gradient_minimalist_desktop_wallpaper_preview;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 448);
            this.panel1.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 72);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Archivo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(234, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Transiciones de la cadena ingresada:\r\n";
            // 
            // RchTransicion
            // 
            this.RchTransicion.Location = new System.Drawing.Point(399, 157);
            this.RchTransicion.Name = "RchTransicion";
            this.RchTransicion.Size = new System.Drawing.Size(264, 226);
            this.RchTransicion.TabIndex = 6;
            this.RchTransicion.Text = "";
            // 
            // Txtcadena
            // 
            this.Txtcadena.Location = new System.Drawing.Point(399, 86);
            this.Txtcadena.Name = "Txtcadena";
            this.Txtcadena.Size = new System.Drawing.Size(264, 24);
            this.Txtcadena.TabIndex = 4;
            // 
            // BtnValidarCadena
            // 
            this.BtnValidarCadena.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnValidarCadena.Location = new System.Drawing.Point(399, 122);
            this.BtnValidarCadena.Name = "BtnValidarCadena";
            this.BtnValidarCadena.Size = new System.Drawing.Size(109, 23);
            this.BtnValidarCadena.TabIndex = 5;
            this.BtnValidarCadena.Text = "Validar cadena";
            this.BtnValidarCadena.UseVisualStyleBackColor = true;
            this.BtnValidarCadena.Click += new System.EventHandler(this.BtnValidarCadena_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(396, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingrese una cadena";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(27, 11);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(721, 426);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.RchMostrar);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.BtnAbrir);
            this.tabPage1.Controls.Add(this.RchTransicion);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.Txtcadena);
            this.tabPage1.Controls.Add(this.BtnValidarCadena);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(713, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "AFD";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.BtnValidarN);
            this.tabPage2.Controls.Add(this.RchValidarN);
            this.tabPage2.Controls.Add(this.RchMostrarN);
            this.tabPage2.Controls.Add(this.BtnAbrirN);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(713, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "AFN";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(248, 20);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(243, 38);
            this.label6.TabIndex = 7;
            this.label6.Text = "Automatas Finitos no deterministas\r\n\r\n";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Seleccione un archivo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(234, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "Transiciones de la cadena ingresada:\r\n";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(369, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 16);
            this.label9.TabIndex = 10;
            this.label9.Text = "Ingrese una cadena";
            // 
            // BtnAbrirN
            // 
            this.BtnAbrirN.Location = new System.Drawing.Point(9, 93);
            this.BtnAbrirN.Name = "BtnAbrirN";
            this.BtnAbrirN.Size = new System.Drawing.Size(75, 23);
            this.BtnAbrirN.TabIndex = 11;
            this.BtnAbrirN.Text = "Abrir\r\n";
            this.BtnAbrirN.UseVisualStyleBackColor = true;
            // 
            // RchMostrarN
            // 
            this.RchMostrarN.Location = new System.Drawing.Point(9, 158);
            this.RchMostrarN.Name = "RchMostrarN";
            this.RchMostrarN.Size = new System.Drawing.Size(231, 223);
            this.RchMostrarN.TabIndex = 12;
            this.RchMostrarN.Text = "";
            // 
            // RchValidarN
            // 
            this.RchValidarN.Location = new System.Drawing.Point(372, 158);
            this.RchValidarN.Name = "RchValidarN";
            this.RchValidarN.Size = new System.Drawing.Size(234, 223);
            this.RchValidarN.TabIndex = 13;
            this.RchValidarN.Text = "";
            // 
            // BtnValidarN
            // 
            this.BtnValidarN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnValidarN.Location = new System.Drawing.Point(372, 121);
            this.BtnValidarN.Name = "BtnValidarN";
            this.BtnValidarN.Size = new System.Drawing.Size(136, 23);
            this.BtnValidarN.TabIndex = 14;
            this.BtnValidarN.Text = "Validar Cadena";
            this.BtnValidarN.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(372, 93);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(234, 20);
            this.textBox1.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(779, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox RchValidarN;
        private System.Windows.Forms.RichTextBox RchMostrarN;
        private System.Windows.Forms.Button BtnAbrirN;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BtnValidarN;
    }
}

