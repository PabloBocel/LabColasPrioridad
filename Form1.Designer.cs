namespace LabColasPrioridad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TBnombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TBSangre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BTsiguiente = new System.Windows.Forms.Button();
            this.BTorden = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnOrdenOriginal = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.LBListaPacientes = new System.Windows.Forms.ListBox();
            this.CBEnfermedades = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(789, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informacion pacientes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre paciente";
            // 
            // TBnombre
            // 
            this.TBnombre.Location = new System.Drawing.Point(13, 101);
            this.TBnombre.Margin = new System.Windows.Forms.Padding(4);
            this.TBnombre.Name = "TBnombre";
            this.TBnombre.Size = new System.Drawing.Size(132, 22);
            this.TBnombre.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(226, 55);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(277, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "Enfermedad de paciente";
            // 
            // TBSangre
            // 
            this.TBSangre.Location = new System.Drawing.Point(13, 228);
            this.TBSangre.Margin = new System.Windows.Forms.Padding(4);
            this.TBSangre.Name = "TBSangre";
            this.TBSangre.Size = new System.Drawing.Size(132, 22);
            this.TBSangre.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 182);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tipo de sangre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(508, 529);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(213, 29);
            this.label6.TabIndex = 9;
            this.label6.Text = "Siguiente paciente";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(789, 529);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(351, 29);
            this.label7.TabIndex = 11;
            this.label7.Text = "Orden de pacientes priorizados";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // BTsiguiente
            // 
            this.BTsiguiente.Location = new System.Drawing.Point(566, 572);
            this.BTsiguiente.Margin = new System.Windows.Forms.Padding(4);
            this.BTsiguiente.Name = "BTsiguiente";
            this.BTsiguiente.Size = new System.Drawing.Size(100, 28);
            this.BTsiguiente.TabIndex = 13;
            this.BTsiguiente.Text = "Mostrar";
            this.BTsiguiente.UseVisualStyleBackColor = true;
            this.BTsiguiente.Click += new System.EventHandler(this.BTsiguiente_Click);
            // 
            // BTorden
            // 
            this.BTorden.Location = new System.Drawing.Point(914, 572);
            this.BTorden.Margin = new System.Windows.Forms.Padding(4);
            this.BTorden.Name = "BTorden";
            this.BTorden.Size = new System.Drawing.Size(100, 28);
            this.BTorden.TabIndex = 14;
            this.BTorden.Text = "Mostrar";
            this.BTorden.UseVisualStyleBackColor = true;
            this.BTorden.Click += new System.EventHandler(this.BTorden_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1240, 529);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(201, 29);
            this.label8.TabIndex = 15;
            this.label8.Text = "Orden de llegada";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // btnOrdenOriginal
            // 
            this.btnOrdenOriginal.Location = new System.Drawing.Point(1306, 576);
            this.btnOrdenOriginal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOrdenOriginal.Name = "btnOrdenOriginal";
            this.btnOrdenOriginal.Size = new System.Drawing.Size(75, 23);
            this.btnOrdenOriginal.TabIndex = 16;
            this.btnOrdenOriginal.Text = "Mostrar";
            this.btnOrdenOriginal.UseVisualStyleBackColor = true;
            this.btnOrdenOriginal.Click += new System.EventHandler(this.btnOrdenOriginal_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRegistrar);
            this.groupBox1.Controls.Add(this.LBListaPacientes);
            this.groupBox1.Controls.Add(this.CBEnfermedades);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TBnombre);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TBSangre);
            this.groupBox1.Location = new System.Drawing.Point(31, 116);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1511, 327);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Formulario";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(287, 199);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 12;
            this.btnRegistrar.Text = "Guardar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // LBListaPacientes
            // 
            this.LBListaPacientes.FormattingEnabled = true;
            this.LBListaPacientes.ItemHeight = 16;
            this.LBListaPacientes.Location = new System.Drawing.Point(523, 36);
            this.LBListaPacientes.Name = "LBListaPacientes";
            this.LBListaPacientes.Size = new System.Drawing.Size(982, 244);
            this.LBListaPacientes.TabIndex = 11;
            // 
            // CBEnfermedades
            // 
            this.CBEnfermedades.FormattingEnabled = true;
            this.CBEnfermedades.Location = new System.Drawing.Point(230, 101);
            this.CBEnfermedades.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CBEnfermedades.Name = "CBEnfermedades";
            this.CBEnfermedades.Size = new System.Drawing.Size(218, 24);
            this.CBEnfermedades.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Location = new System.Drawing.Point(1567, 171);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(211, 225);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1830, 654);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnOrdenOriginal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BTorden);
            this.Controls.Add(this.BTsiguiente);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Centro medico";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBnombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBSangre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BTsiguiente;
        private System.Windows.Forms.Button BTorden;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnOrdenOriginal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox CBEnfermedades;
        private System.Windows.Forms.ListBox LBListaPacientes;
        private System.Windows.Forms.Button btnRegistrar;
    }
}

