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
        private static frmFacturas instance;

        private readonly BindingList<DetalleFactura> listaDetalleFactura;

        private TipoFacturaService oTipoFacturaService;
        private ClienteService oClienteService;
        private FacturaService oFacturaService;
        private DetalleFacturaService oDetalleFacturaService;
        private Prenda oPrendaSelected;

        private frmFacturas()
        {
            InitializeComponent();
            oTipoFacturaService = new TipoFacturaService();
            oClienteService = new ClienteService();
            oFacturaService = new FacturaService();
            oDetalleFacturaService = new DetalleFacturaService();

            listaDetalleFactura = new BindingList<DetalleFactura>();
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
            InicializarFormulario();

            LlenarCombo(cmbTipoFactura, oTipoFacturaService.ObtenerTodos(), "Id", "Id");
            LlenarCombo(cmbCliente, oClienteService.ObtenerTodos(), "Nombre", "Id");
            txtNroFactura.Text = (oFacturaService.ObtenerUltimoIdFactura()+1).ToString();

            dgvDetalle.DataSource = listaDetalleFactura;
           

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

        private void _btnAgregar_Click(object sender, EventArgs e)
        {

            listaDetalleFactura.Add(new DetalleFactura()
            {
                IdDetalle = oDetalleFacturaService.ObtenerUltimoIdDetalleFactura() + 1,
                NroFactura = listaDetalleFactura.Count + 1,
                Cantidad = (int)nudCantidad.Value,
                Prenda = oPrendaSelected

            }) ;

            CalcularTotales();

            InicializarDetalle();

        }

        private void CalcularTotales()
        {
            var subtotal = listaDetalleFactura.Sum(p => p.Subtotal);
            txtSubtotal.Text = subtotal.ToString();

            double descuento = 0;
            double.TryParse(txtDescuento.Text, out descuento);

            var importeTotal = subtotal - subtotal * descuento / 100;
            txtImporteTotal.Text = importeTotal.ToString();

        }

        private void InicializarDetalle()
        {
            
            nudCantidad.Value = 1;
            txtPrendaSelected.Text = 0.ToString("N2");
            txtPrecio.Text = 0.ToString("N2");
            txtImporte.Text = 0.ToString("N2");
        }

        private void InicializarFormulario()
        {

            
            txtDescuento.Text = (0).ToString("N2");
            txtNroFactura.Text = (oFacturaService.ObtenerUltimoIdFactura() + 1).ToString();
            cmbTipoFactura.SelectedIndex = -1;

            cmbCliente.SelectedIndex = -1;
            txtDireccion.Text = "";
            txtCUIT.Text = "";

            InicializarDetalle();

            dgvDetalle.DataSource = null;

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            InicializarFormulario();
        }


        private bool ValidarDatos()
        {
            return true;
        }

        private void btnGrabar_Click_1(object sender, EventArgs e)
        {
            try
            {
                var factura = new Factura
                {
                    // hace falta pasar NroFactura?,
                    Fecha = dtpFecha.Value,
                    Cliente = (Cliente)cmbCliente.SelectedItem,
                    TipoFactura = (TipoFactura)cmbTipoFactura.SelectedItem,
                    Detalles = listaDetalleFactura,
                    Total = double.Parse(txtSubtotal.Text),
                    Descuento = double.Parse(txtDescuento.Text)
                };

                if (oFacturaService.ValidarDatos(factura))
                {
                    oFacturaService.Crear(factura);

                    MessageBox.Show(string.Concat("La factura nro: ", factura.NroFactura, " se generó correctamente."), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    InicializarFormulario();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar la factura! " + ex.Message + ex.StackTrace, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void _btnQuitar_Click(object sender, EventArgs e)
        {
            if (dgvDetalle.CurrentRow != null)
            {
                var detalleSeleccionado = (DetalleFactura)dgvDetalle.CurrentRow.DataBoundItem;
                listaDetalleFactura.Remove(detalleSeleccionado);
            }
        }

        private void _btnCancelar_Click(object sender, EventArgs e)
        {
            InicializarDetalle();
        }
    }

    

}
