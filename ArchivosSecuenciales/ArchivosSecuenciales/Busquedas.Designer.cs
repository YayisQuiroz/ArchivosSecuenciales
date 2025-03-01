namespace ArchivosSecuenciales
{
    partial class DialogBoxConsulta
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
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.CMespecialidad = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Location = new System.Drawing.Point(31, 53);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(154, 16);
            this.lblBusqueda.TabIndex = 0;
            this.lblBusqueda.Text = "Parametro de Busqueda";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(240, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(207, 22);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(337, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(49, 95);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 40);
            this.button2.TabIndex = 3;
            this.button2.Text = "Regresar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // CMespecialidad
            // 
            this.CMespecialidad.FormattingEnabled = true;
            this.CMespecialidad.Items.AddRange(new object[] {
            "Ing Informatica",
            "Ing Industrial",
            "Ing Mecanica",
            "Ing Electronica",
            "Ing Gestion Empresarial",
            "Ing Energias Renovables"});
            this.CMespecialidad.Location = new System.Drawing.Point(240, 51);
            this.CMespecialidad.Name = "CMespecialidad";
            this.CMespecialidad.Size = new System.Drawing.Size(207, 24);
            this.CMespecialidad.TabIndex = 4;
            // 
            // DialogBoxConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 197);
            this.ControlBox = false;
            this.Controls.Add(this.CMespecialidad);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblBusqueda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DialogBoxConsulta";
            this.Text = "Busquedas";
            this.Load += new System.EventHandler(this.DialogBoxConsulta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox CMespecialidad;
    }
}