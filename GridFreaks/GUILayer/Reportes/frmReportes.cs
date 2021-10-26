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
    }
}
