namespace ArchivosSecuenciales
{
    partial class DialogBoxAltas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApaterno = new System.Windows.Forms.TextBox();
            this.Amaterno = new System.Windows.Forms.TextBox();
            this.CbBxEspecialidad = new System.Windows.Forms.ComboBox();
            this.CbBSemestre = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matricula";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre de Alumno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido Paterno del Alumno";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Apellido Materno del Alumno";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(100, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Especialidad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(122, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Semestre";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(206, 37);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(159, 22);
            this.txtMatricula.TabIndex = 6;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(206, 87);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(159, 22);
            this.txtNombre.TabIndex = 7;
            // 
            // txtApaterno
            // 
            this.txtApaterno.Location = new System.Drawing.Point(206, 135);
            this.txtApaterno.Name = "txtApaterno";
            this.txtApaterno.Size = new System.Drawing.Size(159, 22);
            this.txtApaterno.TabIndex = 8;
            // 
            // Amaterno
            // 
            this.Amaterno.Location = new System.Drawing.Point(206, 184);
            this.Amaterno.Name = "Amaterno";
            this.Amaterno.Size = new System.Drawing.Size(159, 22);
            this.Amaterno.TabIndex = 9;
            // 
            // CbBxEspecialidad
            // 
            this.CbBxEspecialidad.FormattingEnabled = true;
            this.CbBxEspecialidad.Items.AddRange(new object[] {
            "Ing Informatica",
            "Ing Industrial",
            "Ing Mecanica",
            "Ing Electronica",
            "Ing Gestion Empresarial",
            "Ing Energias Renovables"});
            this.CbBxEspecialidad.Location = new System.Drawing.Point(206, 225);
            this.CbBxEspecialidad.Name = "CbBxEspecialidad";
            this.CbBxEspecialidad.Size = new System.Drawing.Size(159, 24);
            this.CbBxEspecialidad.TabIndex = 10;
            // 
            // CbBSemestre
            // 
            this.CbBSemestre.FormattingEnabled = true;
            this.CbBSemestre.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.CbBSemestre.Location = new System.Drawing.Point(206, 273);
            this.CbBSemestre.Name = "CbBSemestre";
            this.CbBSemestre.Size = new System.Drawing.Size(159, 24);
            this.CbBSemestre.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(32, 361);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 40);
            this.button1.TabIndex = 12;
            this.button1.Text = "Regresar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button2.Location = new System.Drawing.Point(274, 361);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 40);
            this.button2.TabIndex = 13;
            this.button2.Text = "Guardar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // DialogBoxAltas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 433);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CbBSemestre);
            this.Controls.Add(this.CbBxEspecialidad);
            this.Controls.Add(this.Amaterno);
            this.Controls.Add(this.txtApaterno);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DialogBoxAltas";
            this.Text = "Altas";
            this.Load += new System.EventHandler(this.DialogBoxAltas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApaterno;
        private System.Windows.Forms.TextBox Amaterno;
        private System.Windows.Forms.ComboBox CbBxEspecialidad;
        private System.Windows.Forms.ComboBox CbBSemestre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}