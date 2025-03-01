namespace ArchivosSecuenciales
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altasDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeDatosPorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matriculaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apellidoPaternoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.especialidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.semestreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.todosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificacionesDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(968, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altasDeDatosToolStripMenuItem,
            this.consultaDeDatosPorToolStripMenuItem,
            this.modificacionesDeDatosToolStripMenuItem,
            this.eliminarDatosToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // altasDeDatosToolStripMenuItem
            // 
            this.altasDeDatosToolStripMenuItem.Name = "altasDeDatosToolStripMenuItem";
            this.altasDeDatosToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.altasDeDatosToolStripMenuItem.Text = "Altas de Datos";
            this.altasDeDatosToolStripMenuItem.Click += new System.EventHandler(this.altasDeDatosToolStripMenuItem_Click);
            // 
            // consultaDeDatosPorToolStripMenuItem
            // 
            this.consultaDeDatosPorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.matriculaToolStripMenuItem,
            this.apellidoPaternoToolStripMenuItem,
            this.especialidadToolStripMenuItem,
            this.semestreToolStripMenuItem,
            this.todosToolStripMenuItem});
            this.consultaDeDatosPorToolStripMenuItem.Name = "consultaDeDatosPorToolStripMenuItem";
            this.consultaDeDatosPorToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.consultaDeDatosPorToolStripMenuItem.Text = "Consulta de Datos por:";
            // 
            // matriculaToolStripMenuItem
            // 
            this.matriculaToolStripMenuItem.Name = "matriculaToolStripMenuItem";
            this.matriculaToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.matriculaToolStripMenuItem.Text = "Matricula";
            this.matriculaToolStripMenuItem.Click += new System.EventHandler(this.matriculaToolStripMenuItem_Click);
            // 
            // apellidoPaternoToolStripMenuItem
            // 
            this.apellidoPaternoToolStripMenuItem.Name = "apellidoPaternoToolStripMenuItem";
            this.apellidoPaternoToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.apellidoPaternoToolStripMenuItem.Text = "Apellido Paterno";
            this.apellidoPaternoToolStripMenuItem.Click += new System.EventHandler(this.apellidoPaternoToolStripMenuItem_Click);
            // 
            // especialidadToolStripMenuItem
            // 
            this.especialidadToolStripMenuItem.Name = "especialidadToolStripMenuItem";
            this.especialidadToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.especialidadToolStripMenuItem.Text = "Especialidad";
            this.especialidadToolStripMenuItem.Click += new System.EventHandler(this.especialidadToolStripMenuItem_Click);
            // 
            // semestreToolStripMenuItem
            // 
            this.semestreToolStripMenuItem.Name = "semestreToolStripMenuItem";
            this.semestreToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.semestreToolStripMenuItem.Text = "Semestre";
            this.semestreToolStripMenuItem.Click += new System.EventHandler(this.semestreToolStripMenuItem_Click);
            // 
            // todosToolStripMenuItem
            // 
            this.todosToolStripMenuItem.Name = "todosToolStripMenuItem";
            this.todosToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.todosToolStripMenuItem.Text = "Todos";
            this.todosToolStripMenuItem.Click += new System.EventHandler(this.todosToolStripMenuItem_Click);
            // 
            // modificacionesDeDatosToolStripMenuItem
            // 
            this.modificacionesDeDatosToolStripMenuItem.Name = "modificacionesDeDatosToolStripMenuItem";
            this.modificacionesDeDatosToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.modificacionesDeDatosToolStripMenuItem.Text = "Modificaciones de Datos";
            this.modificacionesDeDatosToolStripMenuItem.Click += new System.EventHandler(this.modificacionesDeDatosToolStripMenuItem_Click);
            // 
            // eliminarDatosToolStripMenuItem
            // 
            this.eliminarDatosToolStripMenuItem.Name = "eliminarDatosToolStripMenuItem";
            this.eliminarDatosToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.eliminarDatosToolStripMenuItem.Text = "Eliminar Datos";
            this.eliminarDatosToolStripMenuItem.Click += new System.EventHandler(this.eliminarDatosToolStripMenuItem_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(41, 31);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(843, 187);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Matricula";
            this.columnHeader1.Width = 70;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nombre de Alumno";
            this.columnHeader2.Width = 130;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Apellido Paterno";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Apellido Materno";
            this.columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Especialidad";
            this.columnHeader5.Width = 120;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Semestre";
            this.columnHeader6.Width = 120;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 500);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altasDeDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeDatosPorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matriculaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apellidoPaternoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem especialidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem semestreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem todosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificacionesDeDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarDatosToolStripMenuItem;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}

