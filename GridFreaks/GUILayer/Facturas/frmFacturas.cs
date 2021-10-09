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
    public partial class frmFacturas : Form
    {
        private static frmFacturas instance = new frmFacturas();

        private TipoFacturaService oTipoFacturaService;
        private ClienteService oClienteService;
        private FacturaService oFacturaService;
        private Prenda oPrendaSelected;

        private frmFacturas()
        {
            InitializeComponent();
            oTipoFacturaService = new TipoFacturaService();
            oClienteService = new ClienteService();
            oFacturaService = new FacturaService();
        }

        public static frmFacturas GetfrmFacturas()
        {
            if (instance == null)
                instance = new frmFacturas();
            return instance;
        }

        private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.DataSource = source;
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.SelectedIndex = -1;
        }

        private void frmFacturas_Load(object sender, EventArgs e)
        {
            LlenarCombo(cmbTipoFactura, oTipoFacturaService.ObtenerTodos(), "Id", "Id");
            LlenarCombo(cmbCliente, oClienteService.ObtenerTodos(), "Nombre", "Id");
            txtNroFactura.Text = (oFacturaService.ObtenerUltimoIdFactura()+1).ToString();

            this.cmbCliente.SelectedIndexChanged += new System.EventHandler(this.cmbCliente_SelectedIndexChanged);
        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCliente.SelectedItem != null)
            {
                var cliente = (Cliente)cmbCliente.SelectedItem;

                txtDireccion.Text = string.Concat(cliente.DomicilioCalle, " ", cliente.DomicilioNro);
                txtCUIT.Text = cliente.CUIT;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelecPrenda_Click(object sender, EventArgs e)
        {
            frmPrendasSelec ventana = new frmPrendasSelec();
            ventana.ShowDialog();
            nudCantidad.Enabled = true;

            if (oPrendaSelected != null)
            {
                txtPrendaSelected.Text = oPrendaSelected.TipoPrenda.Nombre + " " + oPrendaSelected.Color.Nombre + " " + oPrendaSelected.Marca.Nombre;
                txtPrecio.Text = oPrendaSelected.Precio.ToString();
                int importe = (int)oPrendaSelected.Precio * (int)nudCantidad.Value;
                txtImporte.Text = importe.ToString();
            }
        }


        public void setPrenda(Prenda oPrenda)
        {
            oPrendaSelected = oPrenda;
        }

        private void nudCantidad_ValueChanged(object sender, EventArgs e)
        {
            int importe = (int)oPrendaSelected.Precio * (int)nudCantidad.Value;
            txtImporte.Text = importe.ToString();
        }
    }
}
