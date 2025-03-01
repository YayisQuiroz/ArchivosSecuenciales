using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace ArchivosSecuenciales
{
    public partial class DialogBoxConsulta : Form
    {
        private bool Numero=false;
        private bool EsEspecialidad= false;
        public DialogBoxConsulta()
        {
            InitializeComponent();
            textBox1.KeyPress += TextBox1;
            CMespecialidad.Visible = false;
        }
        public string Parametro
        {
            get
            {
                return EsEspecialidad?CMespecialidad.SelectedItem?.ToString():textBox1.Text;
            }
        }
        public string TextoLabel
        {
            get { return lblBusqueda.Text; }
            set { lblBusqueda.Text = value; }
        }
        public bool SoloNumeros
        {
            get { return Numero; }
            set { Numero = value; }
        }
        public bool Especialidades
        {
            set 
            {
                EsEspecialidad = value;
                textBox1.Visible = !value;
                CMespecialidad.Visible=value;
            }
        }

        public void TextBox1(object sender, KeyPressEventArgs e)
        {
            if (SoloNumeros == true)
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }


        private void DialogBoxConsulta_Load(object sender, EventArgs e)
        {
            

        }
    }
}
