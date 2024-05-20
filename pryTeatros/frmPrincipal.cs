using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryTeatros
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
            clsBD clsBD = new clsBD();
            clsBD.conexionBD(label1);
        }

        private void realizarReservaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRealizarReserva frmRealizarReserva = new frmRealizarReserva();
            frmRealizarReserva.Show();
        }
    }
}
