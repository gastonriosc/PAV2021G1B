using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        private void habilitarCampos(bool x)
        {
            comboTipoPrenda.Enabled = x;
            comboColor.Enabled = x;
            comboTemporada.Enabled = x;
            comboMarca.Enabled = x;
            nudPrecioMin.Enabled = x;
            nudPrecioMax.Enabled = x;
        }

        private void chkTodos_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkTodos.Checked)
            {
                habilitarCampos(false);
            }
            else
            {
                habilitarCampos(true);
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Size = new Size(685, 508);
            Location = new Point(617, 266);

            String condiciones = "";
            var filters = new Dictionary<string, object>();

            if (!chkTodos.Checked)
            {
                // Validar si el combo 'Perfiles' esta seleccionado.
                if (comboTipoPrenda.Text != string.Empty)
                {
                    // Si el cbo tiene un texto no vacìo entonces recuperamos el valor de la propiedad ValueMember
                    filters.Add("TipoPrenda", comboTipoPrenda.SelectedValue);
                    condiciones += " AND P.idTipoPrenda=" + comboTipoPrenda.SelectedValue.ToString();
                }

                // Validar si el textBox 'Nombre' esta vacio.
                if (comboColor.Text != string.Empty)
                {
                    // Si el textBox tiene un texto no vacìo entonces recuperamos el valor del texto
                    filters.Add("Color", comboColor.SelectedValue);
                    condiciones += "AND P.idColor=" + comboColor.SelectedValue.ToString();
                }

                // Validar si el textBox 'Nombre' esta vacio.
                if (comboMarca.Text != string.Empty)
                {
                    // Si el textBox tiene un texto no vacìo entonces recuperamos el valor del texto
                    filters.Add("Marca", comboMarca.SelectedValue);
                    condiciones += "AND P.idMarca=" + comboMarca.SelectedValue.ToString();
                }

                // Validar si el textBox 'Nombre' esta vacio.
                if (comboTemporada.Text != string.Empty)
                {
                    // Si el textBox tiene un texto no vacìo entonces recuperamos el valor del texto
                    filters.Add("Temporada", comboTemporada.SelectedValue);
                    condiciones += "AND P.Temporada= '" + comboTemporada.SelectedItem.ToString() + "'";
                }

                if (nudPrecioMax.Value > 0 && (nudPrecioMin.Value < nudPrecioMax.Value))
                {
                    filters.Add("Precio", nudPrecioMax.Value);
                    condiciones += "AND P.Precio BETWEEN " + nudPrecioMin.Value + " AND " + nudPrecioMax.Value;
                }

                if (filters.Count > 0)
                    //SIN PARAMETROS
                    dgvPrendas.DataSource = oPrendaService.ConsultarConFiltrosSinParametros(condiciones);
                else
                    MessageBox.Show("Debe ingresar al menos un criterio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                dgvPrendas.DataSource = oPrendaService.ObtenerTodos();


            limpiarCombos();
        }

        private void limpiarCombos()
        {
            comboTipoPrenda.SelectedIndex = -1;
            comboColor.SelectedIndex = -1;
            comboMarca.SelectedIndex = -1;
            comboTemporada.SelectedIndex = -1;;
            chkTodos.Checked = true;
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

        private void dgvPrendas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // habilita los botones de modificar y eliminar prenda.
            this.btnModificar.Enabled = true;
            this.btnEliminar.Enabled = true;

            cargarFotoPrenda();

            Size = new Size(1168, 508);
            Location = new Point(360, 266);

            pbPrenda.Visible = true;
        }

        private void cargarFotoPrenda()
        {
            // no repetir imagen con id de producto
            // obtengo mi ruta de ejecucion y le agrego el nombre de la imagen para buscarla
            string directorioEjecucion = Directory.GetCurrentDirectory();
            string toRemove = "\\bin\\Debug";
            string result = string.Empty;
            int i = directorioEjecucion.IndexOf(toRemove);
            if (i >= 0)
            {
                result = directorioEjecucion.Remove(i, toRemove.Length);
            }
            string direccionImagenes = result + "\\ImagenesPrendas";

            string resultado = direccionImagenes + "\\" + ((Prenda)dgvPrendas.CurrentRow.DataBoundItem).NombreImagen;
            pbPrenda.Image = Image.FromFile(resultado);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            frmABMPrendas ventanaABMprendas = new frmABMPrendas();
            ventanaABMprendas.ShowDialog();
            btnConsultar_Click(sender, e);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmABMPrendas formulario = new frmABMPrendas();
            Prenda prendaSeleccionada = (Prenda)dgvPrendas.CurrentRow.DataBoundItem;
            formulario.SeleccionarPrenda(frmABMPrendas.FormMode.update, prendaSeleccionada);
            formulario.ShowDialog();
            btnConsultar_Click(sender, e);

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            frmABMPrendas formulario = new frmABMPrendas();
            Prenda prendaSeleccionada = (Prenda)dgvPrendas.CurrentRow.DataBoundItem;
            formulario.SeleccionarPrenda(frmABMPrendas.FormMode.delete, prendaSeleccionada);
            formulario.ShowDialog();
            btnConsultar_Click(sender, e);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvPrendas_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}
