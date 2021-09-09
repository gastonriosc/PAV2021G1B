﻿using GridFreaks.GUILayer;
using GridFreaks.GUILayer.Usuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GridFreaks
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void iniciarSesionTSMI_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.ShowDialog();
            habilitarTodosCampos();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

        }

        private void habilitarTodosCampos()
        {
            this.cerrarSesionTSMI.Enabled = true;
            this.usuariosTSMI.Enabled = true;
        }

        private void usuariosTSMI_Click(object sender, EventArgs e)
        {
            frmUsuarios ventanaUsuarios = new frmUsuarios();
            ventanaUsuarios.ShowDialog();
        }
    }
}