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

namespace BugTracker.GUILayer.Usuarios
{
    public partial class frmABMUsuario : Form
    {

        private FormMode formMode = FormMode.insert;

        private readonly UserService oUsuarioService;
        private User oUsuarioSelected;

        public frmABMUsuario()
        {
            InitializeComponent();
            oUsuarioService = new UserService();
        }

        public enum FormMode
        {
            insert,
            update,
            delete
        }


        private void frmABMUsuario_Load(System.Object sender, System.EventArgs e)
        {
            //LlenarCombo(cboPerfil, oPerfilService.ObtenerTodos(), "Nombre", "IdPerfil");
            switch (formMode)
            {
                case FormMode.insert:
                    {
                        this.Text = "Nuevo Usuario";
                        break;
                    }

                case FormMode.update:
                    {
                        this.Text = "Actualizar Usuario";
                        // Recupera el usuario seleccionado en la grilla 
                        MostrarDatos();
                        txtUsuario.Enabled = true;
                        txtNombre.Enabled = true;
                        txtApellido.Enabled = true;
                        txtMail.Enabled = true;
                        txtContra.Enabled = true;
                        txtConfirmarContra.Enabled = true;
                        break;
                    }

                case FormMode.delete:
                    {
                        MostrarDatos();
                        this.Text = "Deshabilitar Usuario";
                        txtUsuario.Enabled = false;
                        txtNombre.Enabled = false;
                        txtApellido.Enabled = false;
                        txtMail.Enabled = false;
                        txtContra.Enabled = false;
                        txtConfirmarContra.Enabled = false;
                        break;
                    }
            }
        }

        public void SeleccionarUsuario(FormMode op, User usuarioSelected)
        {
            formMode = op;
            oUsuarioSelected = usuarioSelected;
        }

        private void MostrarDatos()
        {
            if (oUsuarioSelected != null)
            {
                txtUsuario.Text = oUsuarioSelected.Usuario;
                txtNombre.Text = oUsuarioSelected.Nombre;
                txtApellido.Text = oUsuarioSelected.Apellido;
                txtMail.Text = oUsuarioSelected.Mail;
                txtContra.Text = oUsuarioSelected.Contra;
                txtConfirmarContra.Text = txtContra.Text;
            }
        }

        private void btnAceptar_Click(System.Object sender, System.EventArgs e)
        {
            switch (formMode)
            {
                case FormMode.insert:
                    {
                        if (ExisteUsuario() == false)
                        {
                            if (ValidarCampos())
                            {
                                var oUsuario = new User();
                                oUsuario.Usuario = txtUsuario.Text;
                                oUsuario.Nombre = txtNombre.Text;
                                oUsuario.Apellido = txtApellido.Text;
                                oUsuario.Mail = txtMail.Text;
                                oUsuario.Contra = txtContra.Text;

                                if (oUsuarioService.CrearUsuario(oUsuario))
                                {
                                    MessageBox.Show("Usuario insertado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                            }
                            else
                                MessageBox.Show("Faltan campos por completar!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        else
                            MessageBox.Show("Nombre de usuario encontrado!. Ingrese un nombre diferente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }

                case FormMode.update:
                    {
                        if (ValidarCampos())
                        {
                            oUsuarioSelected.Usuario = txtUsuario.Text;
                            oUsuarioSelected.Nombre = txtNombre.Text;
                            oUsuarioSelected.Apellido = txtApellido.Text;
                            oUsuarioSelected.Mail = txtMail.Text;

                            if (oUsuarioService.ActualizarUsuario(oUsuarioSelected))
                            {
                                MessageBox.Show("Usuario actualizado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Dispose();
                            }
                            else
                                MessageBox.Show("Error al actualizar el usuario!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            MessageBox.Show("Faltan campos por completar!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }

                case FormMode.delete:
                    {
                        if (MessageBox.Show("¿Seguro que desea deshabilitar el usuario seleccionado?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {

                            if (oUsuarioService.ModificarEstadoUsuario(oUsuarioSelected))
                            {
                                MessageBox.Show("Usuario Deshabilitado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                                MessageBox.Show("Error al actualizar el usuario!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        break;
                    }
            }
        }

        private bool ValidarCampos()
        {
            
            // campos obligatorios
            if (txtNombre.Text == string.Empty || txtUsuario.Text == "" || txtApellido.Text == "" || txtMail.Text == "" || txtContra.Text == "" || txtConfirmarContra.Text == "" )
            {
                return false;
            }

            else
                txtNombre.BackColor = Color.White;
            
            return true;
        }

        private bool ExisteUsuario()
        {
            return oUsuarioService.ObtenerUsuario(txtNombre.Text) != null;
        }


        private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.DataSource = source;
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.SelectedIndex = -1;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalir_Click(System.Object sender, System.EventArgs e)
        {
            this.Close();
        }

    }
}
