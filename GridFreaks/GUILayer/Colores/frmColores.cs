using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GridFreaks.BusinessLayer;
using GridFreaks.Entities;

namespace GridFreaks.GUILayer.Colores
{
    public partial class frmColores : Form
    {
        private ColorService oColorService;

        public frmColores()
        {
            InitializeComponent();
            InitializeDataGridView();
            Location = new Point(600, 300);

            oColorService = new ColorService();
        }

        private void frmColores_Load(object sender, EventArgs e)
        {
            CargarGrilla(dgvColores, oColorService.ObtenerTodos());
            btnEliminar.Enabled = false;
            btnEditar.Enabled = false;
            
        }

        private void CargarGrilla(DataGridView grilla, IList<ColorPrenda> lista)
        {
            dgvColores.DataSource = oColorService.ObtenerTodos();
        }

        private void InitializeDataGridView()
        {
            // Cree un DataGridView no vinculado declarando un recuento de columnas.
            dgvColores.ColumnCount = 1;
            dgvColores.ColumnHeadersVisible = true;

            // Configuramos la AutoGenerateColumns en false para que no se autogeneren las columnas
            dgvColores.AutoGenerateColumns = false;

            // Cambia el estilo de la cabecera de la grilla.
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = System.Drawing.Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 8, FontStyle.Bold);
            dgvColores.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            // Definimos el nombre de la columnas y el DataPropertyName que se asocia a DataSource
            dgvColores.Columns[0].Name = "Color";
            dgvColores.Columns[0].DataPropertyName = "Nombre";

            // Cambia el tamaño de la altura de los encabezados de columna.
            dgvColores.AutoResizeColumnHeadersHeight();

            // Cambia el tamaño de todas las alturas de fila para ajustar el contenido de todas las celdas que no sean de encabezado.
            dgvColores.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);
        }

        private void dgvColores_CellClick(object sender, DataGridViewCellEventArgs e)
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
                filters.Add("Color", txtBusqueda.Text);
                condiciones += "AND nombre LIKE" + "'%" + txtBusqueda.Text + "%'";
            }

            if (filters.Count > 0)
                //SIN PARAMETROS
                dgvColores.DataSource = oColorService.ConsultarConFiltrosSinParametros(condiciones);

            //CON PARAMETROS
            //dgvUsers.DataSource = oUsuarioService.ConsultarConFiltrosConParametros(filters);
            else
                dgvColores.DataSource = oColorService.ObtenerTodos();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            frmABMColores ventanaABM = new frmABMColores();
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
            frmABMColores ventanaABM = new frmABMColores();
            ColorPrenda colorSeleccionado = (ColorPrenda)dgvColores.CurrentRow.DataBoundItem;
            ventanaABM.SeleccionarColor(frmABMColores.FormMode.delete, colorSeleccionado);
            ventanaABM.ShowDialog();
            btnConsultar_Click(sender, e);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmABMColores ventanaABM = new frmABMColores();
            ColorPrenda colorSeleccionado = (ColorPrenda)dgvColores.CurrentRow.DataBoundItem;
            ventanaABM.SeleccionarColor(frmABMColores.FormMode.update, colorSeleccionado);
            ventanaABM.ShowDialog();
            btnConsultar_Click(sender, e);
        }
    }
}
