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

namespace GridFreaks.GUILayer.Facturas
{
    public partial class frmListadoFacturas : Form
    {
        private FacturaService oFacturaService;

        public frmListadoFacturas()
        {
            InitializeComponent();
            oFacturaService = new FacturaService();
            InitializeDataGridView();
        }

        private void ListadoReportes_Load(object sender, EventArgs e)
        {
            dtpFechaDesde.Value = DateTime.Today.AddMonths(-1);
            dtpFechaHasta.Value = DateTime.Today;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InitializeDataGridView()
        {
            dgvFacturas.ColumnCount = 6;
            dgvFacturas.ColumnHeadersVisible = true;

            dgvFacturas.AutoGenerateColumns = false;

            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = System.Drawing.Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 8, FontStyle.Bold);
            dgvFacturas.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            dgvFacturas.Columns[0].Name = "Nro Factura";
            dgvFacturas.Columns[0].DataPropertyName = "NroFactura";

            dgvFacturas.Columns[1].Name = "Fecha";
            dgvFacturas.Columns[1].DataPropertyName = "Fecha";

            dgvFacturas.Columns[2].Name = "Cliente";
            dgvFacturas.Columns[2].DataPropertyName = "Cliente";

            dgvFacturas.Columns[3].Name = "Tipo Factura";
            dgvFacturas.Columns[3].DataPropertyName = "TipoFactura";

            dgvFacturas.Columns[4].Name = "Total";
            dgvFacturas.Columns[4].DataPropertyName = "Total";

            dgvFacturas.Columns[5].Name = "Anulado";
            dgvFacturas.Columns[5].DataPropertyName = "Anulado";

            // Cambia el tamaño de la altura de los encabezados de columna.
            dgvFacturas.AutoResizeColumnHeadersHeight();

            // Cambia el tamaño de todas las alturas de fila para ajustar el contenido de todas las celdas que no sean de encabezado.
            dgvFacturas.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            String condiciones = " AND F.fecha BETWEEN '" + dtpFechaDesde.Value.ToString("yyyy-MM-dd") + "' AND '" + dtpFechaHasta.Value.ToString("yyyy-MM-dd") + "'";
            var filters = new Dictionary<string, object>();

            dgvFacturas.DataSource = oFacturaService.RecuperarFacturas(condiciones);
        }

        private void dgvFacturas_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea anular la factura seleccionada?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (oFacturaService.AnularFactura((Factura)dgvFacturas.CurrentRow.DataBoundItem))
                {
                    MessageBox.Show("Factura anulada correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show("Error al anular la factura.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            btnConsultar_Click(sender, e);
        }


        private void dgvFacturas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAnular.Enabled = true;
        }
    }
}
