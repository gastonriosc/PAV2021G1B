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

namespace GridFreaks.GUILayer.Colores
{
    public partial class frmABMColores : Form
    {
        private FormMode formMode = FormMode.insert;

        private ColorService oColorService;
        private ColorPrenda oColorSelected;
        public frmABMColores()
        {
            InitializeComponent();
            Location = new Point(970, 300);
            oColorService = new ColorService();
        }

        public enum FormMode
        {
            insert,
            update,
            delete
        }

        public void SeleccionarColor(FormMode op, ColorPrenda colorSelected)
        {
            formMode = op;
            oColorSelected = colorSelected;
        }

        private void frmABMColores_Load(object sender, EventArgs e)
        {
            switch (formMode)
            {
                case FormMode.insert:
                    {
                        this.Text = "Registrar Color";
                        lblNuevoColor.Text = "Nuevo Color";
                        break;
                    }

                case FormMode.update:
                    {
                        this.Text = "Modificar Color";
                        lblNuevoColor.Text = "Editar Color";
                        // Recupera el color seleccionado en la grilla 
                        txtNuevoColor.Text = oColorSelected.Nombre;
                        break;
                    }

                case FormMode.delete:
                    {
                        this.Text = "Borrar Color";
                        lblNuevoColor.Text = "Borrar Color";
                        txtNuevoColor.Text = oColorSelected.Nombre;
                        txtNuevoColor.Enabled = false;
                        break;
                    }
            }
        }

        private bool ValidarCampos()
        {
            if (txtNuevoColor.Text == string.Empty) 
            {
                return false;
            }
            return true;
        }

        private bool ExisteColor()
        {
            var oColor = new ColorPrenda();
            oColor.Nombre = txtNuevoColor.Text;

            return oColorService.RecuperarColor(oColor);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            switch (formMode)
            {
                case FormMode.insert:
                    {
                        if (ValidarCampos())
                        {
                            if (ExisteColor() == false)
                            {
                                if (MessageBox.Show("¿Seguro que desea registrar este color?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                                {
                                    var oColor = new ColorPrenda();
                                    oColor.Id = oColorService.ObtenerUltimoIdColor() + 1;
                                    oColor.Nombre = txtNuevoColor.Text;

                                    if (oColorService.CrearColor(oColor))
                                    {
                                        MessageBox.Show("Color registrado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        this.Close();
                                    }
                                    else
                                        MessageBox.Show("Error al registrar el color.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                            else
                                MessageBox.Show("Color ya registrado anteriormente!. Ingrese un color diferente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            MessageBox.Show("Escriba el nombre del nuevo color...", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }

                case FormMode.update:
                    {
                        if (ValidarCampos())
                        {
                            oColorSelected.Nombre = txtNuevoColor.Text;

                            if (oColorService.ActualizarColor(oColorSelected))
                            {
                                MessageBox.Show("Color actualizado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Dispose();
                            }
                            else
                                MessageBox.Show("Error al actualizar el color.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            MessageBox.Show("Escriba el nombre del nuevo color...", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }

                case FormMode.delete:
                    {
                        if (MessageBox.Show("¿Seguro que desea borrar este color?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            if (oColorService.ModificarEstadoColor(oColorSelected))
                            {
                                MessageBox.Show("Color borrado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                                MessageBox.Show("Error al borrar el color.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        break;
                    }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
