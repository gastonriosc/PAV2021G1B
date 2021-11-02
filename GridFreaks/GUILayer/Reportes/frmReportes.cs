using GridFreaks.BusinessLayer;
using GridFreaks.Entities;
using GridFreaks.GUILayer.Facturas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GridFreaks.GUILayer.Reportes
{
    public partial class frmReportes : Form
    {
        private static frmReportes instance;
        private TipoFacturaService oTipoFacturaService;
        private ClienteService oClienteService;
        private FacturaService oFacturaService;
        private MarcaService oMarcaService;
        private Prenda oPrendaSelected;

        public frmReportes()
        {
            InitializeComponent();
            oTipoFacturaService = new TipoFacturaService();
            oClienteService = new ClienteService();
            oFacturaService = new FacturaService();
            oMarcaService = new MarcaService();
            oPrendaSelected = new Prenda();

        }
        public static frmReportes GetfrmReportes()
        {
            if (instance == null)
                instance = new frmReportes();
            return instance;
        }

        private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.DataSource = source;
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.SelectedIndex = -1;
        }

        private void frmReportes_Load(object sender, EventArgs e)
        {      
            LlenarCombo(cmbTipoFactura, oTipoFacturaService.ObtenerTodos(), "Id", "Id");
            LlenarCombo(cmbCliente, oClienteService.ObtenerTodos(), "Nombre", "Id");
            LlenarCombo(cmbMarca, oMarcaService.ObtenerTodos(), "Nombre", "Id");
            dtpFechaDesde.Value = DateTime.Today.AddMonths(-1);
            dtpFechaHasta.Value = DateTime.Today;
            this.dtFacturasBindingSource.DataSource = oFacturaService.ObtenerFacturas(" AND F.fecha BETWEEN '" + dtpFechaDesde.Value.ToString("yyyy-MM-dd") + "' AND '" + dtpFechaHasta.Value.ToString("yyyy-MM-dd") + "'");
            this.reportViewer1.RefreshReport();
        }

        public void setPrenda(Prenda oPrenda)
        {
            oPrendaSelected = oPrenda;
        }

        private void btnPrendaSelec_Click(object sender, EventArgs e)
        {
            frmPrendasSelec ventana = new frmPrendasSelec();
            ventana.ShowDialog();
            if (oPrendaSelected != null)
            {
                txtPrendaSelected.Text = oPrendaSelected.ToString();
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            String condiciones = " AND F.fecha BETWEEN '" + dtpFechaDesde.Value.ToString("yyyy-MM-dd") + "' AND '" + dtpFechaHasta.Value.ToString("yyyy-MM-dd") + "'";
            var filters = new Dictionary<string, object>();

            if (cmbCliente.Text != string.Empty)
            {
                filters.Add("Cliente", cmbCliente.SelectedValue);
                condiciones += " AND C.nombre= '" + cmbCliente.SelectedItem.ToString() + "'";
            }
            if (cmbMarca.Text != string.Empty)
            {
                filters.Add("Marca", cmbMarca.SelectedValue);
                condiciones += " AND M.nombre= '" + cmbMarca.SelectedItem.ToString() + "'";
            }
            if (cmbTipoFactura.Text != string.Empty)
            {
                filters.Add("TipoFactura", cmbTipoFactura.SelectedValue);
                condiciones += " AND F.tipoFactura='" + cmbTipoFactura.SelectedValue.ToString() + "'";
            }
            if (nudPrecioMax.Value > 0 && (nudPrecioMin.Value < nudPrecioMax.Value))
            {
                filters.Add("Precio", nudPrecioMax.Value);
                condiciones += " AND F.total BETWEEN " + nudPrecioMin.Value + " AND " + nudPrecioMax.Value;
            }
            if (oPrendaSelected.Id != 0)
            {
                filters.Add("Prenda", oPrendaSelected);
                condiciones += " AND P.id=" + oPrendaSelected.Id;
            }

            this.dtFacturasBindingSource.DataSource = oFacturaService.ObtenerFacturas(condiciones);
            this.reportViewer1.RefreshReport();

            limpiarCombos();
        }


        private void limpiarCombos()
        {
            dtpFechaDesde.Value = DateTime.Today.AddMonths(-1);
            dtpFechaHasta.Value = DateTime.Today;
            cmbTipoFactura.SelectedIndex = -1;
            cmbMarca.SelectedIndex = -1;
            cmbCliente.SelectedIndex = -1;
            nudPrecioMin.Value = 0;
            nudPrecioMax.Value = 0;
            txtPrendaSelected.Text = "";
            oPrendaSelected.Id = 0;

        }
    }
}
