using GridFreaks.BusinessLayer;
using GridFreaks.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GridFreaks.GUILayer.Usuarios
{
    public partial class frmUsuarios : Form
    {
        UserService oUsuarioService = new UserService();

        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            CargarGrilla(dgvUsuarios, oUsuarioService.ObtenerTodos());
        }

        private void CargarGrilla(DataGridView grilla, IList<User> lista)
        {
            //grilla.Rows.Clear();
            dgvUsuarios.DataSource = oUsuarioService.ObtenerTodos();
        }

    }
}
