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

namespace GridFreaks.GUILayer.Marcas
{
    public partial class frmABMCMarcas : Form
    {
        private FormMode formMode = FormMode.insert;

        private MarcaService oMarcaService;
        private Marca oMarcaSelected;

        public frmABMCMarcas()
        {
            InitializeComponent();

            oMarcaService = new MarcaService();
        }


        public enum FormMode
        {
            insert,
            update,
            delete
        }

        public void SeleccionarMarca(FormMode op, Marca marcaSelected)
        {
            formMode = op;
            oMarcaSelected = marcaSelected;
        }

        private void frmABMCMarcas_Load(object sender, EventArgs e)
        {
            switch (formMode)
            {
                case FormMode.insert:
                    {
                        this.Text = "Registrar Marca";
                        lblNuevaMarca.Text = "Nueva Marca";
                        break;
                    }

                case FormMode.update:
                    {
                        this.Text = "Modificar Marca";
                        lblNuevaMarca.Text = "Editar Color";
                        // Recupera el color seleccionado en la grilla 
                        txtNuevaMarca.Text = oMarcaSelected.Nombre;
                        break;
                    }

                case FormMode.delete:
                    {
                        this.Text = "Borrar Color";
                        lblNuevaMarca.Text = "Borrar Color";
                        txtNuevaMarca.Text = oMarcaSelected.Nombre;
                        txtNuevaMarca.Enabled = false;
                        break;
                    }
            }
        }
        private bool ValidarCampos()
        {
            if (txtNuevaMarca.Text == string.Empty)
            {
                return false;
            }
            return true;
        }

        private bool ExisteMarca()
        {
            var oMarca = new Marca();
            oMarca.Nombre = txtNuevaMarca.Text;

            return oMarcaService.RecuperarMarca(oMarca);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            switch (formMode)
            {
                case FormMode.insert:
                    {
                        if (ValidarCampos())
                        {
                            if (ExisteMarca() == false)
                            {
                                if (MessageBox.Show("¿Seguro que desea registrar esta Marca?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                                {
                                    var oMarca = new Marca();
                                    oMarca.Id = oMarcaService.ObtenerUltimoIdMarca() + 1;
                                    oMarca.Nombre = txtNuevaMarca.Text;

                                    if (oMarcaService.CrearMarca(oMarca))
                                    {
                                        MessageBox.Show("Marca registrada correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        this.Close();
                                    }
                                    else
                                        MessageBox.Show("Error al registrar la marca.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                            else
                                MessageBox.Show("Marca ya registrada anteriormente!. Ingrese una marca diferente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            MessageBox.Show("Escriba el nombre de la nueva marca...", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }

                case FormMode.update:
                    {
                        if (ValidarCampos())
                        {
                            oMarcaSelected.Nombre = txtNuevaMarca.Text;

                            if (oMarcaService.ActualizarMarca(oMarcaSelected))
                            {
                                MessageBox.Show("Marca actualizada correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Dispose();
                            }
                            else
                                MessageBox.Show("Error al actualizar la marca.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            MessageBox.Show("Escriba el nombre de la nueva marca...", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }

                case FormMode.delete:
                    {
                        if (MessageBox.Show("¿Seguro que desea borrar esta marca?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            if (oMarcaService.ModificarEstadoMarca(oMarcaSelected))
                            {
                                MessageBox.Show("Marca borrada correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                                MessageBox.Show("Error al borrar la marca.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        break;
                    }
            }
        }
    }
}
