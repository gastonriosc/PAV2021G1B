using BugTracker.GUILayer.Usuarios;
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
            InitializeDataGridView();
            pictureBox1.SendToBack();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            CargarGrilla(dgvUsuarios, oUsuarioService.ObtenerTodos());
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            btnRegistrar.Enabled = false;
        }

        private void CargarGrilla(DataGridView grilla, IList<User> lista)
        {
            //grilla.Rows.Clear();
            dgvUsuarios.DataSource = oUsuarioService.ObtenerTodos();
        }


        private void InitializeDataGridView()
        {
            // Cree un DataGridView no vinculado declarando un recuento de columnas.
            dgvUsuarios.ColumnCount = 4;
            dgvUsuarios.ColumnHeadersVisible = true;

            // Configuramos la AutoGenerateColumns en false para que no se autogeneren las columnas
            dgvUsuarios.AutoGenerateColumns = false;

            // Cambia el estilo de la cabecera de la grilla.
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = System.Drawing.Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 8, FontStyle.Bold);
            dgvUsuarios.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            // Definimos el nombre de la columnas y el DataPropertyName que se asocia a DataSource
            dgvUsuarios.Columns[0].Name = "Usuario";
            dgvUsuarios.Columns[0].DataPropertyName = "Usuario";
           
            // Definimos el ancho de la columna.

            dgvUsuarios.Columns[1].Name = "Nombre";
            dgvUsuarios.Columns[1].DataPropertyName = "Nombre";

            dgvUsuarios.Columns[2].Name = "Apellido";
            dgvUsuarios.Columns[2].DataPropertyName = "Apellido";

            dgvUsuarios.Columns[3].Name = "Mail";
            dgvUsuarios.Columns[3].DataPropertyName = "Mail";

            // Cambia el tamaño de la altura de los encabezados de columna.
            dgvUsuarios.AutoResizeColumnHeadersHeight();

            // Cambia el tamaño de todas las alturas de fila para ajustar el contenido de todas las celdas que no sean de encabezado.
            dgvUsuarios.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEliminar.Enabled = true;
            btnModificar.Enabled = true;
            btnRegistrar.Enabled = true;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            
            String condiciones = "";
            var filters = new Dictionary<string, object>();


            // Validar si el textBox 'Nombre' esta vacio.
            if (txtUsuario.Text != string.Empty)
                {
                // Si el textBox tiene un texto no vacìo entonces recuperamos el valor del texto
                filters.Add("usuario", txtUsuario.Text);
                condiciones += "AND u.usuario LIKE" + "'%" + txtUsuario.Text + "%'";
                }

                if (txtNombre.Text != string.Empty)
                {
                // Si el textBox tiene un texto no vacìo entonces recuperamos el valor del texto
                filters.Add("nombre", txtNombre.Text);
                condiciones += "AND u.nombre LIKE" + "'%" + txtNombre.Text + "%'";
                }

                if (txtApellido.Text != string.Empty)
                {
                // Si el textBox tiene un texto no vacìo entonces recuperamos el valor del texto
                filters.Add("apellido", txtApellido.Text);
                condiciones += "AND u.apellido LIKE" + "'%" + txtApellido.Text + "%'";
                }

                if (filters.Count > 0)
                    //SIN PARAMETROS
                    dgvUsuarios.DataSource = oUsuarioService.ConsultarConFiltrosSinParametros(condiciones);

                //CON PARAMETROS
                //dgvUsers.DataSource = oUsuarioService.ConsultarConFiltrosConParametros(filters);
                else
                dgvUsuarios.DataSource = oUsuarioService.ObtenerTodos();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            frmABMUsuario formulario = new frmABMUsuario();
            formulario.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmABMUsuario formulario = new frmABMUsuario();
            User usuario = (User)dgvUsuarios.CurrentRow.DataBoundItem;
            formulario.SeleccionarUsuario(frmABMUsuario.FormMode.update, usuario);
            formulario.ShowDialog();
            btnConsultar_Click(sender, e);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            frmABMUsuario formulario = new frmABMUsuario();
            var usuario = (User)dgvUsuarios.CurrentRow.DataBoundItem;
            formulario.SeleccionarUsuario(frmABMUsuario.FormMode.delete, usuario);
            formulario.ShowDialog();
            btnConsultar_Click(sender, e);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
