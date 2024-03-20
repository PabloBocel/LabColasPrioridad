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
            this.label1.Location = new System.Drawing.Point(346, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informacion pacientes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre paciente";
            // 
            // TBnombre
            // 
            this.TBnombre.Location = new System.Drawing.Point(38, 82);
            this.TBnombre.Name = "TBnombre";
            this.TBnombre.Size = new System.Drawing.Size(100, 20);
            this.TBnombre.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(313, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(218, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Enfermedad de paciente";
            // 
            // TBSangre
            // 
            this.TBSangre.Location = new System.Drawing.Point(38, 185);
            this.TBSangre.Name = "TBSangre";
            this.TBSangre.Size = new System.Drawing.Size(100, 20);
            this.TBSangre.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tipo de sangre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(77, 424);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 24);
            this.label6.TabIndex = 9;
            this.label6.Text = "Siguiente paciente";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(288, 424);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(274, 24);
            this.label7.TabIndex = 11;
            this.label7.Text = "Orden de pacientes priorizados";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // BTsiguiente
            // 
            this.BTsiguiente.Location = new System.Drawing.Point(121, 459);
            this.BTsiguiente.Name = "BTsiguiente";
            this.BTsiguiente.Size = new System.Drawing.Size(75, 23);
            this.BTsiguiente.TabIndex = 13;
            this.BTsiguiente.Text = "Siguiente";
            this.BTsiguiente.UseVisualStyleBackColor = true;
            this.BTsiguiente.Click += new System.EventHandler(this.BTsiguiente_Click);
            // 
            // BTorden
            // 
            this.BTorden.Location = new System.Drawing.Point(382, 459);
            this.BTorden.Name = "BTorden";
            this.BTorden.Size = new System.Drawing.Size(75, 23);
            this.BTorden.TabIndex = 14;
            this.BTorden.Text = "Mostrar";
            this.BTorden.UseVisualStyleBackColor = true;
            this.BTorden.Click += new System.EventHandler(this.BTorden_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(626, 424);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(157, 24);
            this.label8.TabIndex = 15;
            this.label8.Text = "Orden de llegada";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // btnOrdenOriginal
            // 
            this.btnOrdenOriginal.Location = new System.Drawing.Point(676, 462);
            this.btnOrdenOriginal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOrdenOriginal.Name = "btnOrdenOriginal";
            this.btnOrdenOriginal.Size = new System.Drawing.Size(56, 19);
            this.btnOrdenOriginal.TabIndex = 16;
            this.btnOrdenOriginal.Text = "Mostrar";
            this.btnOrdenOriginal.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CBEnfermedades);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TBnombre);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TBSangre);
            this.groupBox1.Location = new System.Drawing.Point(23, 94);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(843, 266);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Formulario";
            // 
            // CBEnfermedades
            // 
            this.CBEnfermedades.FormattingEnabled = true;
            this.CBEnfermedades.Location = new System.Drawing.Point(316, 82);
            this.CBEnfermedades.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CBEnfermedades.Name = "CBEnfermedades";
            this.CBEnfermedades.Size = new System.Drawing.Size(100, 21);
            this.CBEnfermedades.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Location = new System.Drawing.Point(607, 59);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 183);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 531);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOrdenOriginal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BTorden);
            this.Controls.Add(this.BTsiguiente);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
    }
}

