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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.RchTransicion = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Txtcadena = new System.Windows.Forms.TextBox();
            this.BtnValidarCadena = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtCadenaN = new System.Windows.Forms.TextBox();
            this.BtnValidarN = new System.Windows.Forms.Button();
            this.RchValidarN = new System.Windows.Forms.RichTextBox();
            this.RchMostrarN = new System.Windows.Forms.RichTextBox();
            this.BtnAbrirN = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnAbrir
            // 
            this.BtnAbrir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAbrir.Location = new System.Drawing.Point(31, 123);
            this.BtnAbrir.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAbrir.Name = "BtnAbrir";
            this.BtnAbrir.Size = new System.Drawing.Size(100, 28);
            this.BtnAbrir.TabIndex = 0;
            this.BtnAbrir.Text = "Abrir archivo";
            this.BtnAbrir.UseVisualStyleBackColor = true;
            this.BtnAbrir.Click += new System.EventHandler(this.BtnAbrir_Click);
            // 
            // RchMostrar
            // 
            this.RchMostrar.Location = new System.Drawing.Point(31, 193);
            this.RchMostrar.Margin = new System.Windows.Forms.Padding(4);
            this.RchMostrar.Name = "RchMostrar";
            this.RchMostrar.Size = new System.Drawing.Size(300, 277);
            this.RchMostrar.TabIndex = 1;
            this.RchMostrar.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccione un archivo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(309, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(288, 24);
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
            this.panel1.Location = new System.Drawing.Point(3, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1229, 551);
            this.panel1.TabIndex = 7;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(36, 14);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(961, 524);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
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
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(953, 495);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "AFD";
            // 
            // RchTransicion
            // 
            this.RchTransicion.Location = new System.Drawing.Point(532, 193);
            this.RchTransicion.Margin = new System.Windows.Forms.Padding(4);
            this.RchTransicion.Name = "RchTransicion";
            this.RchTransicion.Size = new System.Drawing.Size(351, 277);
            this.RchTransicion.TabIndex = 6;
            this.RchTransicion.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 159);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(288, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Transiciones de la cadena ingresada:\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Archivo";
            // 
            // Txtcadena
            // 
            this.Txtcadena.Location = new System.Drawing.Point(532, 106);
            this.Txtcadena.Margin = new System.Windows.Forms.Padding(4);
            this.Txtcadena.Name = "Txtcadena";
            this.Txtcadena.Size = new System.Drawing.Size(351, 29);
            this.Txtcadena.TabIndex = 4;
            // 
            // BtnValidarCadena
            // 
            this.BtnValidarCadena.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnValidarCadena.Location = new System.Drawing.Point(532, 150);
            this.BtnValidarCadena.Margin = new System.Windows.Forms.Padding(4);
            this.BtnValidarCadena.Name = "BtnValidarCadena";
            this.BtnValidarCadena.Size = new System.Drawing.Size(145, 28);
            this.BtnValidarCadena.TabIndex = 5;
            this.BtnValidarCadena.Text = "Validar cadena";
            this.BtnValidarCadena.UseVisualStyleBackColor = true;
            this.BtnValidarCadena.Click += new System.EventHandler(this.BtnValidarCadena_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(528, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingrese una cadena";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.TxtCadenaN);
            this.tabPage2.Controls.Add(this.BtnValidarN);
            this.tabPage2.Controls.Add(this.RchValidarN);
            this.tabPage2.Controls.Add(this.RchMostrarN);
            this.tabPage2.Controls.Add(this.BtnAbrirN);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(953, 495);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "AFN";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(496, 194);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(163, 16);
            this.label10.TabIndex = 16;
            this.label10.Text = "Recorrido Cadena Valida:";
            // 
            // TxtCadenaN
            // 
            this.TxtCadenaN.Location = new System.Drawing.Point(496, 114);
            this.TxtCadenaN.Margin = new System.Windows.Forms.Padding(4);
            this.TxtCadenaN.Name = "TxtCadenaN";
            this.TxtCadenaN.Size = new System.Drawing.Size(311, 22);
            this.TxtCadenaN.TabIndex = 15;
            // 
            // BtnValidarN
            // 
            this.BtnValidarN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnValidarN.Location = new System.Drawing.Point(496, 149);
            this.BtnValidarN.Margin = new System.Windows.Forms.Padding(4);
            this.BtnValidarN.Name = "BtnValidarN";
            this.BtnValidarN.Size = new System.Drawing.Size(181, 28);
            this.BtnValidarN.TabIndex = 14;
            this.BtnValidarN.Text = "Validar Cadena";
            this.BtnValidarN.UseVisualStyleBackColor = true;
            this.BtnValidarN.Click += new System.EventHandler(this.BtnValidarN_Click);
            // 
            // RchValidarN
            // 
            this.RchValidarN.Location = new System.Drawing.Point(496, 222);
            this.RchValidarN.Margin = new System.Windows.Forms.Padding(4);
            this.RchValidarN.Name = "RchValidarN";
            this.RchValidarN.Size = new System.Drawing.Size(311, 220);
            this.RchValidarN.TabIndex = 13;
            this.RchValidarN.Text = "";
            // 
            // RchMostrarN
            // 
            this.RchMostrarN.Location = new System.Drawing.Point(12, 194);
            this.RchMostrarN.Margin = new System.Windows.Forms.Padding(4);
            this.RchMostrarN.Name = "RchMostrarN";
            this.RchMostrarN.Size = new System.Drawing.Size(307, 274);
            this.RchMostrarN.TabIndex = 12;
            this.RchMostrarN.Text = "";
            // 
            // BtnAbrirN
            // 
            this.BtnAbrirN.Location = new System.Drawing.Point(12, 114);
            this.BtnAbrirN.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAbrirN.Name = "BtnAbrirN";
            this.BtnAbrirN.Size = new System.Drawing.Size(100, 28);
            this.BtnAbrirN.TabIndex = 11;
            this.BtnAbrirN.Text = "Abrir\r\n";
            this.BtnAbrirN.UseVisualStyleBackColor = true;
            this.BtnAbrirN.Click += new System.EventHandler(this.BtnAbrirN_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(492, 79);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "Ingrese una cadena";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 158);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(288, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Transiciones de la cadena ingresada:\r\n";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 79);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Seleccione un archivo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(331, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(313, 48);
            this.label6.TabIndex = 7;
            this.label6.Text = "Automatas Finitos no deterministas\r\n\r\n";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(973, 546);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1056, 578);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.TextBox TxtCadenaN;
        private System.Windows.Forms.Button BtnValidarN;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
    }
}

