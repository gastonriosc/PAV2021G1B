
namespace GridFreaks
{
    partial class frmInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sesionTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.iniciarSesionTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.salirTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sesionTSMI,
            this.usuariosTSMI,
            this.salirTSMI});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sesionTSMI
            // 
            this.sesionTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iniciarSesionTSMI,
            this.cerrarSesionTSMI});
            this.sesionTSMI.Name = "sesionTSMI";
            this.sesionTSMI.Size = new System.Drawing.Size(53, 20);
            this.sesionTSMI.Text = "Sesión";
            // 
            // iniciarSesionTSMI
            // 
            this.iniciarSesionTSMI.Name = "iniciarSesionTSMI";
            this.iniciarSesionTSMI.Size = new System.Drawing.Size(180, 22);
            this.iniciarSesionTSMI.Text = "Iniciar Sesión";
            this.iniciarSesionTSMI.Click += new System.EventHandler(this.iniciarSesionTSMI_Click);
            // 
            // cerrarSesionTSMI
            // 
            this.cerrarSesionTSMI.Enabled = false;
            this.cerrarSesionTSMI.Name = "cerrarSesionTSMI";
            this.cerrarSesionTSMI.Size = new System.Drawing.Size(180, 22);
            this.cerrarSesionTSMI.Text = "Cerrar Sesión";
            // 
            // usuariosTSMI
            // 
            this.usuariosTSMI.Enabled = false;
            this.usuariosTSMI.Name = "usuariosTSMI";
            this.usuariosTSMI.Size = new System.Drawing.Size(64, 20);
            this.usuariosTSMI.Text = "Usuarios";
            this.usuariosTSMI.Click += new System.EventHandler(this.usuariosTSMI_Click);
            // 
            // salirTSMI
            // 
            this.salirTSMI.Name = "salirTSMI";
            this.salirTSMI.Size = new System.Drawing.Size(41, 20);
            this.salirTSMI.Text = "Salir";
            this.salirTSMI.Click += new System.EventHandler(this.salirTSMI_Click);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmInicio";
            this.Text = "Inicio";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmInicio_FormClosing);
            this.Load += new System.EventHandler(this.frmInicio_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sesionTSMI;
        private System.Windows.Forms.ToolStripMenuItem iniciarSesionTSMI;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionTSMI;
        private System.Windows.Forms.ToolStripMenuItem usuariosTSMI;
        private System.Windows.Forms.ToolStripMenuItem salirTSMI;
    }
}

