using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GridFreaks.GUILayer.Colores
{
    public partial class frmColores : Form
    {
        public frmColores()
        {
            InitializeComponent();
            Location = new Point(600, 300);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            frmABMColores ventanaABM = new frmABMColores();
            ventanaABM.ShowDialog();
        }
    }
}
