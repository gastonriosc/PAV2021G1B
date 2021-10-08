using GridFreaks.BusinessLayer;
using GridFreaks.Entities;
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

namespace GridFreaks.GUILayer.Facturas
{
    public partial class frmPrendasSelec : Form
    {
        private Prenda oPrendaSelected;
        private PrendaService oPrendaService;
        private TipoPrendaService oTipoPrendaService;

        public frmPrendasSelec()
        {
            oPrendaSelected = new Prenda();
            oPrendaService = new PrendaService();
            oTipoPrendaService = new TipoPrendaService();
            InitializeComponent();
            InitializeDataGridView();
            Size = new Size(419, 514);
        }

        private void InitializeDataGridView()
        {
            // Cree un DataGridView no vinculado declarando un recuento de columnas.
            dgvPrendas.ColumnCount = 4;
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

            //dgvPrendas.Columns[3].Name = "Stock";
            //dgvPrendas.Columns[3].DataPropertyName = "Stock";

            //dgvPrendas.Columns[4].Name = "Precio";
            //dgvPrendas.Columns[4].DataPropertyName = "Precio";

            dgvPrendas.Columns[3].Name = "Marca";
            dgvPrendas.Columns[3].DataPropertyName = "Marca";

            // Cambia el tamaño de la altura de los encabezados de columna.
            dgvPrendas.AutoResizeColumnHeadersHeight();

            // Cambia el tamaño de todas las alturas de fila para ajustar el contenido de todas las celdas que no sean de encabezado.
            dgvPrendas.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);
        }

        private void cargarFotoPrenda()
        {
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
            pbFotoPrenda.Image = Image.FromFile(resultado);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cmbTipoPrenda.SelectedIndex == -1)
            {
                dgvPrendas.DataSource = oPrendaService.ObtenerTodos();
            }
            else
            {
                string tipoPrenda = " AND P.idTipoPrenda=" + cmbTipoPrenda.SelectedValue.ToString();
                dgvPrendas.DataSource = oPrendaService.ConsultarConFiltrosSinParametros(tipoPrenda);
            }
        }

        private void dgvPrendas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.btnAceptar.Enabled = true;
            Size = new Size(889, 514);
            cargarFotoPrenda();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            frmFacturas.GetfrmFacturas().setPrenda((Prenda)dgvPrendas.CurrentRow.DataBoundItem);
            this.Close();
        }

        private void frmPrendasSelec_Load(object sender, EventArgs e)
        {
            LlenarCombo(cmbTipoPrenda, oTipoPrendaService.ObtenerTodos(), "Nombre", "Id");
        }

        private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.DataSource = source;
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.SelectedIndex = -1;
        }
    }
}
