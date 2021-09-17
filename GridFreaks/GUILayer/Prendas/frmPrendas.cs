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

namespace GridFreaks.GUILayer.Prendas
{
    public partial class frmPrendas : Form
    {
        private TipoPrendaService oTipoPrendaService;
        private ColorService oColorService;
        private MarcaService oMarcaService;
        private PrendaService oPrendaService;

        public frmPrendas()
        {
            InitializeComponent();
            InitializeDataGridView();
            oTipoPrendaService = new TipoPrendaService();
            oMarcaService = new MarcaService();
            oColorService = new ColorService();
            oPrendaService = new PrendaService();
        }

        private void frmPrendas_Load(object sender, EventArgs e)
        {
            LlenarCombo(comboMarca, oMarcaService.ObtenerTodos(), "Nombre", "Id");
            LlenarCombo(comboColor, oColorService.ObtenerTodos(), "Nombre", "Id");
            LlenarCombo(comboTipoPrenda, oTipoPrendaService.ObtenerTodos(), "Nombre", "Id");
            comboTemporada.Items.Add("Invierno");
            comboTemporada.Items.Add("Verano");
            this.CenterToParent();
        }

        private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.DataSource = source;
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.SelectedIndex = -1;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(comboTemporada.SelectedItem.ToString());

            String condiciones = "";
            var filters = new Dictionary<string, object>();

            if (!chkTodos.Checked)
            {
                //// Validar si el combo 'Perfiles' esta seleccionado.
                //if (cboPerfiles.Text != string.Empty)
                //{
                //    // Si el cbo tiene un texto no vacìo entonces recuperamos el valor de la propiedad ValueMember
                //    filters.Add("idPerfil", cboPerfiles.SelectedValue);
                //    condiciones += " AND u.idperfil=" + cboPerfiles.SelectedValue.ToString();

                //}

                //// Validar si el textBox 'Nombre' esta vacio.
                //if (txtNombre.Text != string.Empty)
                //{
                //    // Si el textBox tiene un texto no vacìo entonces recuperamos el valor del texto
                //    filters.Add("usuario", txtNombre.Text);
                //    condiciones += "AND u.usuario=" + "'" + txtNombre.Text + "'";
                //}

                //if (filters.Count > 0)
                //    //SIN PARAMETROS
                //    dgvUsers.DataSource = oUsuarioService.ConsultarConFiltrosSinParametros(condiciones);

                ////CON PARAMETROS
                ////dgvUsers.DataSource = oUsuarioService.ConsultarConFiltrosConParametros(filters);

                //else
                //    MessageBox.Show("Debe ingresar al menos un criterio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                dgvPrendas.DataSource = oPrendaService.ObtenerTodos();
        }

        private void InitializeDataGridView()
        {
            // Cree un DataGridView no vinculado declarando un recuento de columnas.
            dgvPrendas.ColumnCount = 6;
            dgvPrendas.ColumnHeadersVisible = true;

            // Configuramos la AutoGenerateColumns en false para que no se autogeneren las columnas
            dgvPrendas.AutoGenerateColumns = false;

            // Cambia el estilo de la cabecera de la grilla.
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = System.Drawing.Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 8, FontStyle.Bold);
            dgvPrendas.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            // Definimos el nombre de la columnas y el DataPropertyName que se asocia a DataSource
            dgvPrendas.Columns[0].Name = "Prenda";
            dgvPrendas.Columns[0].DataPropertyName = "TipoPrenda";

            dgvPrendas.Columns[1].Name = "Color";
            dgvPrendas.Columns[1].DataPropertyName = "Color";

            dgvPrendas.Columns[2].Name = "Temporada";
            dgvPrendas.Columns[2].DataPropertyName = "Temporada";

            dgvPrendas.Columns[3].Name = "Stock";
            dgvPrendas.Columns[3].DataPropertyName = "Stock";

            dgvPrendas.Columns[4].Name = "Precio";
            dgvPrendas.Columns[4].DataPropertyName = "Precio";

            dgvPrendas.Columns[5].Name = "Marca";
            dgvPrendas.Columns[5].DataPropertyName = "Marca";

            // Cambia el tamaño de la altura de los encabezados de columna.
            dgvPrendas.AutoResizeColumnHeadersHeight();

            // Cambia el tamaño de todas las alturas de fila para ajustar el contenido de todas las celdas que no sean de encabezado.
            dgvPrendas.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);
        }
    }
}
