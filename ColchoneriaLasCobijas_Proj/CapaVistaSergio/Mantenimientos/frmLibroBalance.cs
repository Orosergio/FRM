using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControladorSergio;

namespace CapaVistaSergio.Mantenimientos
{
    public partial class frmLibroBalance : Form
    {
        Controlador cn = new Controlador();

        public frmLibroBalance()
        {
            InitializeComponent();
        }

     
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            cn.parametros(txtNombre.Text.ToString(), cmbMes.SelectedItem.ToString(), cmbYear.SelectedItem.ToString());
        }
    }
}
