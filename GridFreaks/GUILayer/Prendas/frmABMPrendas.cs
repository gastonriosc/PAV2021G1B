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

namespace GridFreaks.GUILayer.Prendas
{
    public partial class frmABMPrendas : Form
    {
        private FormMode formMode = FormMode.insert;

        private TipoPrendaService oTipoPrendaService;
        private ColorService oColorService;
        private MarcaService oMarcaService;
        private readonly PrendaService oPrendaService;

        private Prenda oPrendaSelected;
        public frmABMPrendas()
        {
            InitializeComponent();

            oTipoPrendaService = new TipoPrendaService();
            oMarcaService = new MarcaService();
            oColorService = new ColorService();
            oPrendaService = new PrendaService();
        }

        public enum FormMode
        {
            insert,
            update,
            delete
        }

        private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.DataSource = source;
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.SelectedIndex = -1;
        }

        private void frmABMPrendas_Load(object sender, EventArgs e)
        {
            LlenarCombo(cmbMarca, oMarcaService.ObtenerTodos(), "Nombre", "Id");
            LlenarCombo(cmbColor, oColorService.ObtenerTodos(), "Nombre", "Id");
            LlenarCombo(cmbTipoPrenda, oTipoPrendaService.ObtenerTodos(), "Nombre", "Id");
            cmbTemporada.Items.Add("Invierno");
            cmbTemporada.Items.Add("Verano");

            this.CenterToParent();

            switch (formMode)
            {
                case FormMode.insert:
                    {
                        Size = new Size(295,508);
                        this.Text = "Nueva Prenda";
                        break;
                    }

                case FormMode.update:
                    {
                        this.Text = "Modificar Prenda";
                        // Recupera el usuario seleccionado en la grilla 
                        MostrarDatos();
                        cmbTipoPrenda.Enabled = true;
                        cmbColor.Enabled = true;
                        cmbTemporada.Enabled = true;
                        cmbMarca.Enabled = true;
                        nudStock.Enabled = true;
                        nudPrecio.Enabled = true;
                        break;
                    }

                case FormMode.delete:
                    {
                        MostrarDatos();
                        this.Text = "Borrar Prenda";
                        cmbTipoPrenda.Enabled = false;
                        cmbColor.Enabled = false;
                        cmbTemporada.Enabled = false;
                        cmbMarca.Enabled = false;
                        nudStock.Enabled = false;
                        nudPrecio.Enabled = false;
                        btnFoto.Enabled = false;
                        break;
                    }
            }
        }

        private void MostrarDatos()
        {
            if (oPrendaSelected != null)
            {
                cmbTipoPrenda.SelectedIndex = oPrendaSelected.TipoPrenda.Id-1;
                cmbColor.SelectedIndex = oPrendaSelected.Color.Id - 1;
                cmbTemporada.SelectedItem = oPrendaSelected.Temporada;
                cmbMarca.SelectedIndex = oPrendaSelected.Marca.Id - 1;
                nudStock.Value = oPrendaSelected.Stock;
                nudPrecio.Value = (int)oPrendaSelected.Precio;
                cargarFotoPrenda();
            }
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

            string resultado = direccionImagenes + "\\" + oPrendaSelected.NombreImagen;
            pbPrenda.Image = Image.FromFile(resultado);
        }

        public void SeleccionarPrenda(FormMode op, Prenda prendaSelected)
        {
            formMode = op;
            oPrendaSelected = prendaSelected;
        }

        
        private void btnFoto_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog fo = new OpenFileDialog();
                DialogResult rs = fo.ShowDialog();
                if (rs == DialogResult.OK)
                {

                    pbPrenda.Image = Image.FromFile(fo.FileName);
                    //string nombreImagen = Path.GetFileName(fo.FileName);
                    pbPrenda.Tag = Path.GetFileName(fo.FileName);

                }

                Size = new Size(778, 508);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el archivo. Intente nuevamente.");
            }
        }

        private bool ExistePrenda()
        {
            var oPrenda = new Prenda();
            //oPrenda.Id = oPrendaService.ObtenerUltimoIdPrenda() + 1;
            oPrenda.TipoPrenda = new TipoPrenda();
            oPrenda.TipoPrenda.Id = (int)cmbTipoPrenda.SelectedValue;
            oPrenda.Color = new ColorPrenda();
            oPrenda.Color.Id = (int)cmbColor.SelectedValue;
            oPrenda.Temporada = cmbTemporada.Text;
            oPrenda.Marca = new Marca();
            oPrenda.Marca.Id = (int)cmbMarca.SelectedValue;
            oPrenda.Stock = (int)nudStock.Value;
            oPrenda.Precio = (float)nudPrecio.Value;
            //oPrenda.NombreImagen = nombreImagen;
            oPrenda.NombreImagen = (string)pbPrenda.Tag;

            return oPrendaService.ObtenerPrenda(oPrenda);
        }

        private bool ValidarCampos()
        {
            // campos obligatorios, si alguno no esta modificado, devuelve false
            if (cmbTipoPrenda.SelectedIndex == -1 || cmbColor.SelectedIndex == -1 || cmbTemporada.SelectedIndex == -1 || cmbMarca.SelectedIndex == -1 || nudPrecio.Value == 0 || nudStock.Value == 0 || pbPrenda.Image == null) // agregar validacion foto
            {
                return false;
            }
            return true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrar_Click_1(object sender, EventArgs e)
        {
            switch (formMode)
            {
                case FormMode.insert:
                    {
                        if (ValidarCampos())
                        {
                            if (ExistePrenda() == false)
                            {
                                var oPrenda = new Prenda();
                                oPrenda.Id = oPrendaService.ObtenerUltimoIdPrenda() + 1;
                                oPrenda.TipoPrenda = new TipoPrenda();
                                oPrenda.TipoPrenda.Id = (int)cmbTipoPrenda.SelectedValue;
                                oPrenda.Color = new ColorPrenda();
                                oPrenda.Color.Id = (int)cmbColor.SelectedValue;
                                oPrenda.Temporada = cmbTemporada.Text;
                                oPrenda.Marca = new Marca();
                                oPrenda.Marca.Id = (int)cmbMarca.SelectedValue;
                                oPrenda.Stock = (int)nudStock.Value;
                                oPrenda.Precio = (float)nudPrecio.Value;
                                // guarda unicamente el nombre de la imagen
                                // oPrenda.NombreImagen = Path.GetFileName(fo.FileName);
                                //oPrenda.NombreImagen = nombreImagen;
                                oPrenda.NombreImagen = (string)pbPrenda.Tag;

                                if (oPrendaService.CrearPrenda(oPrenda))
                                {
                                    MessageBox.Show("Prenda insertada correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                                else
                                    MessageBox.Show("Error al actualizar la prenda!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                                MessageBox.Show("Prenda ya registrada anteriormente!. Ingrese una prenda diferente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            MessageBox.Show("Faltan campos por completar!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }

                case FormMode.update:
                    {
                        if (ValidarCampos())
                        {
                            oPrendaSelected.TipoPrenda = new TipoPrenda();
                            oPrendaSelected.TipoPrenda.Id = (int)cmbTipoPrenda.SelectedValue;
                            oPrendaSelected.Color = new ColorPrenda();
                            oPrendaSelected.Color.Id = (int)cmbColor.SelectedValue;
                            oPrendaSelected.Temporada = cmbTemporada.Text;
                            oPrendaSelected.Marca = new Marca();
                            oPrendaSelected.Marca.Id = (int)cmbMarca.SelectedValue;
                            oPrendaSelected.Stock = (int)nudStock.Value;
                            oPrendaSelected.Precio = (float)nudPrecio.Value;
                            if (pbPrenda.Tag != null)
                            {
                                oPrendaSelected.NombreImagen = (string)pbPrenda.Tag;
                            }
                            
                            //oPrendaSelected.NombreImagen = (string)pbPrenda.Tag;

                            if (oPrendaService.ActualizarPrenda(oPrendaSelected))
                            {
                                MessageBox.Show("Prenda actualizada correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                                MessageBox.Show("Error al actualizar la prenda.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            MessageBox.Show("Faltan campos por completar!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }

                case FormMode.delete:
                    {
                        if (MessageBox.Show("¿Seguro que desea borrar la prenda seleccioada?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {

                            if (oPrendaService.ModificarEstadoPrenda(oPrendaSelected))
                            {
                                MessageBox.Show("Prenda borrada correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                                MessageBox.Show("Error al borrar la prenda.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        break;
                    }
            }
        }
    }
}
