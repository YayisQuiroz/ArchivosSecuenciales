using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArchivosSecuenciales
{
    public partial class DialogBoxAltas : Form
    {
        public DialogBoxAltas()
        {
            InitializeComponent();
        }
        
        public string matricula
        {
            get { return (txtMatricula.Text); }
            set { txtMatricula.Text = value; }
        }
        public string nombre
        {
            get { return (txtNombre.Text); }
            set { txtNombre.Text = value; }
        }
        public string apaterno
        {
            get { return (txtApaterno.Text); }
            set { txtApaterno.Text = value; }
        }
        public string amaterno
        {
            get { return (Amaterno.Text); }
            set {  Amaterno.Text = value; }
        }
        public string especialidad
        {
            get { return (CbBxEspecialidad.Text); }
            set { CbBxEspecialidad.Text = value; }
        }
        public string semestre
        {
            get { return (CbBSemestre.Text); }
            set { CbBSemestre.Text = value; }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DialogBoxAltas_Load(object sender, EventArgs e)
        {

        }
    }
}
