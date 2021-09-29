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

namespace GridFreaks.GUILayer.Marcas
{
    public partial class frmMarcas : Form
    {
        private MarcaService oMarcaService;

        public frmMarcas()
        {
            InitializeComponent();
            InitializeDataGridView();
            Location = new Point(600, 300);

            oMarcaService = new MarcaService();
        }

        

        private void frmMarcas_Load(object sender, EventArgs e)
        {
            CargarGrilla(dgvMarcas, oMarcaService.ObtenerTodos());
            btnEliminar.Enabled = false;
            btnEditar.Enabled = false;
        }

        private void CargarGrilla(DataGridView grilla, IList<Marca> lista)
        {
            dgvMarcas.DataSource = oMarcaService.ObtenerTodos();
        }


        private void InitializeDataGridView()
        {
            // Cree un DataGridView no vinculado declarando un recuento de columnas.
            dgvMarcas.ColumnCount = 1;
            dgvMarcas.ColumnHeadersVisible = true;

            // Configuramos la AutoGenerateColumns en false para que no se autogeneren las columnas
            dgvMarcas.AutoGenerateColumns = false;

            // Cambia el estilo de la cabecera de la grilla.
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = System.Drawing.Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 8, FontStyle.Bold);
            dgvMarcas.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            // Definimos el nombre de la columnas y el DataPropertyName que se asocia a DataSource
            dgvMarcas.Columns[0].Name = "Marca";
            dgvMarcas.Columns[0].DataPropertyName = "Nombre";

            // Cambia el tamaño de la altura de los encabezados de columna.
            dgvMarcas.AutoResizeColumnHeadersHeight();

            // Cambia el tamaño de todas las alturas de fila para ajustar el contenido de todas las celdas que no sean de encabezado.
            dgvMarcas.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);
        }

        private void dgvMarcas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEliminar.Enabled = true;
            btnEditar.Enabled = true;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            String condiciones = "";
            var filters = new Dictionary<string, object>();


            // Validar si el textBox 'Nombre' esta vacio.
            if (txtBusqueda.Text != string.Empty)
            {
                // Si el textBox tiene un texto no vacìo entonces recuperamos el valor del texto
                filters.Add("Marca", txtBusqueda.Text);
                condiciones += "AND nombre LIKE" + "'%" + txtBusqueda.Text + "%'";
            }

            if (filters.Count > 0)
                //SIN PARAMETROS
                dgvMarcas.DataSource = oMarcaService.ConsultarConFiltrosSinParametros(condiciones);

            //CON PARAMETROS
            //dgvUsers.DataSource = oUsuarioService.ConsultarConFiltrosConParametros(filters);
            else
                dgvMarcas.DataSource = oMarcaService.ObtenerTodos();
        }

        

        private void btnRegistrar_Click_1(object sender, EventArgs e)
        {
            frmABMCMarcas ventanaABM = new frmABMCMarcas();
            ventanaABM.ShowDialog();
            txtBusqueda.Text = "";
            btnConsultar_Click(sender, e);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            frmABMCMarcas ventanaABM = new frmABMCMarcas();
            Marca marcaSeleccionada = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
            ventanaABM.SeleccionarMarca(frmABMCMarcas.FormMode.delete, marcaSeleccionada);
            ventanaABM.ShowDialog();
            btnConsultar_Click(sender, e);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmABMCMarcas ventanaABM = new frmABMCMarcas();
            Marca marcaSeleccionado = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
            ventanaABM.SeleccionarMarca(frmABMCMarcas.FormMode.update, marcaSeleccionado);
            ventanaABM.ShowDialog();
            btnConsultar_Click(sender, e);
        }
    }



}
