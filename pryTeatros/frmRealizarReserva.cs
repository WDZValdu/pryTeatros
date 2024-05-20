using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace pryTeatros
{
    public partial class frmRealizarReserva : Form
    {
        public frmRealizarReserva()
        {
            InitializeComponent();
        }

        private void cmbTeatro_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbTeatro.SelectedIndex)
            {
                case 0:
                    this.pnlPrincipal.Controls.Clear();
                    ucReservaQueaken ucReservaQueaken = new ucReservaQueaken();
                    this.pnlPrincipal.Controls.Add(ucReservaQueaken);
                    ucReservaQueaken.Show();
                    break;
                    
            }
        }
    }
}
