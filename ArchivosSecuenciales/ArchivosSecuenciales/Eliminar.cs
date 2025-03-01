using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ArchivosSecuenciales
{
    public partial class DialogBoxEliminar : Form
    {
        public DialogBoxEliminar()
        {
            InitializeComponent();
        }
        public string Parametro
        {
            get
            {
                return txtEmatricula.Text;
            }
        }

        private void DialogBoxEliminar_Load(object sender, EventArgs e)
        {

        }
    }
}
