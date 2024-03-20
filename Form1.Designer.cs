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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TBnombre = new System.Windows.Forms.TextBox();
            this.TBhora = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TBEnfermedad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TBSangre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BTsiguiente = new System.Windows.Forms.Button();
            this.BTorden = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(291, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informacion pacientes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre paciente";
            // 
            // TBnombre
            // 
            this.TBnombre.Location = new System.Drawing.Point(16, 121);
            this.TBnombre.Name = "TBnombre";
            this.TBnombre.Size = new System.Drawing.Size(100, 20);
            this.TBnombre.TabIndex = 2;
            // 
            // TBhora
            // 
            this.TBhora.Location = new System.Drawing.Point(16, 208);
            this.TBhora.Name = "TBhora";
            this.TBhora.Size = new System.Drawing.Size(100, 20);
            this.TBhora.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Hora de llegada";
            // 
            // TBEnfermedad
            // 
            this.TBEnfermedad.Location = new System.Drawing.Point(295, 121);
            this.TBEnfermedad.Name = "TBEnfermedad";
            this.TBEnfermedad.Size = new System.Drawing.Size(100, 20);
            this.TBEnfermedad.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(291, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(218, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Enfermedad de paciente";
            // 
            // TBSangre
            // 
            this.TBSangre.Location = new System.Drawing.Point(295, 208);
            this.TBSangre.Name = "TBSangre";
            this.TBSangre.Size = new System.Drawing.Size(100, 20);
            this.TBSangre.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(291, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tipo de sangre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(341, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 24);
            this.label6.TabIndex = 9;
            this.label6.Text = "Siguiente paciente";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(565, 308);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 24);
            this.label7.TabIndex = 11;
            this.label7.Text = "Orden de pacientes";
            // 
            // BTsiguiente
            // 
            this.BTsiguiente.Location = new System.Drawing.Point(385, 343);
            this.BTsiguiente.Name = "BTsiguiente";
            this.BTsiguiente.Size = new System.Drawing.Size(75, 23);
            this.BTsiguiente.TabIndex = 13;
            this.BTsiguiente.Text = "next";
            this.BTsiguiente.UseVisualStyleBackColor = true;
            // 
            // BTorden
            // 
            this.BTorden.Location = new System.Drawing.Point(620, 343);
            this.BTorden.Name = "BTorden";
            this.BTorden.Size = new System.Drawing.Size(75, 23);
            this.BTorden.TabIndex = 14;
            this.BTorden.Text = "orden";
            this.BTorden.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTorden);
            this.Controls.Add(this.BTsiguiente);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TBSangre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TBEnfermedad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TBhora);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TBnombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBnombre;
        private System.Windows.Forms.TextBox TBhora;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBEnfermedad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBSangre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BTsiguiente;
        private System.Windows.Forms.Button BTorden;
    }
}

