using GridFreaks.GUILayer;
using GridFreaks.GUILayer.Colores;
using GridFreaks.GUILayer.Marcas;
using GridFreaks.GUILayer.Prendas;
using GridFreaks.GUILayer.Usuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GridFreaks
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void iniciarSesionTSMI_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.ShowDialog();
            habilitarTodosCampos();
            this.Text = "Inicio - Logueado";
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

        }

        private void habilitarTodosCampos()
        {
            this.cerrarSesionTSMI.Enabled = true;
            this.usuariosTSMI.Enabled = true;
            this.prendasTSMI.Enabled = true;
            this.coloresTSMI.Enabled = true;
            this.marcasTSMI.Enabled = true;
        }

        private void frmInicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Está seguro de abandorar la aplicación...",
                "SALIENDO",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1)
                == DialogResult.Yes)

                e.Cancel = false;
            else
                e.Cancel = true;
        }

        private void usuariosTSMI_Click(object sender, EventArgs e)
        {
            frmUsuarios ventanaUsuarios = new frmUsuarios();
            ventanaUsuarios.ShowDialog();
        }

        private void salirTSMI_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void prendasTSMI_Click(object sender, EventArgs e)
        {
            frmPrendas ventanaPrendas = new frmPrendas();
            ventanaPrendas.ShowDialog();
        }

        private void coloresTSMI_Click(object sender, EventArgs e)
        {
            frmColores ventanaColores = new frmColores();
            ventanaColores.ShowDialog();
        }

        private void sesionTSMI_Click(object sender, EventArgs e)
        {

        }

        private void marcasTSMI_Click(object sender, EventArgs e)
        {
            frmMarcas ventanaMarcas = new frmMarcas();
            ventanaMarcas.ShowDialog();

        }
    }
}
