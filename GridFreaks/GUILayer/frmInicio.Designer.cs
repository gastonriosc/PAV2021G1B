
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sesionTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.iniciarSesionTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.prendasTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.coloresTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.marcasTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.facturasTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.salirTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sesionTSMI,
            this.usuariosTSMI,
            this.prendasTSMI,
            this.coloresTSMI,
            this.marcasTSMI,
            this.facturasTSMI,
            this.salirTSMI});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(634, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sesionTSMI
            // 
            this.sesionTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iniciarSesionTSMI,
            this.cerrarSesionTSMI});
            this.sesionTSMI.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.sesionTSMI.Name = "sesionTSMI";
            this.sesionTSMI.Size = new System.Drawing.Size(53, 20);
            this.sesionTSMI.Text = "Sesión";
            // 
            // iniciarSesionTSMI
            // 
            this.iniciarSesionTSMI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iniciarSesionTSMI.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.iniciarSesionTSMI.Name = "iniciarSesionTSMI";
            this.iniciarSesionTSMI.Size = new System.Drawing.Size(143, 22);
            this.iniciarSesionTSMI.Text = "Iniciar Sesión";
            this.iniciarSesionTSMI.Click += new System.EventHandler(this.iniciarSesionTSMI_Click);
            // 
            // cerrarSesionTSMI
            // 
            this.cerrarSesionTSMI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cerrarSesionTSMI.Enabled = false;
            this.cerrarSesionTSMI.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cerrarSesionTSMI.Name = "cerrarSesionTSMI";
            this.cerrarSesionTSMI.Size = new System.Drawing.Size(143, 22);
            this.cerrarSesionTSMI.Text = "Cerrar Sesión";
            // 
            // usuariosTSMI
            // 
            this.usuariosTSMI.Enabled = false;
            this.usuariosTSMI.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.usuariosTSMI.Name = "usuariosTSMI";
            this.usuariosTSMI.Size = new System.Drawing.Size(64, 20);
            this.usuariosTSMI.Text = "Usuarios";
            this.usuariosTSMI.Click += new System.EventHandler(this.usuariosTSMI_Click);
            // 
            // prendasTSMI
            // 
            this.prendasTSMI.Enabled = false;
            this.prendasTSMI.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.prendasTSMI.Name = "prendasTSMI";
            this.prendasTSMI.Size = new System.Drawing.Size(61, 20);
            this.prendasTSMI.Text = "Prendas";
            this.prendasTSMI.Click += new System.EventHandler(this.prendasTSMI_Click);
            // 
            // coloresTSMI
            // 
            this.coloresTSMI.Enabled = false;
            this.coloresTSMI.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.coloresTSMI.Name = "coloresTSMI";
            this.coloresTSMI.Size = new System.Drawing.Size(59, 20);
            this.coloresTSMI.Text = "Colores";
            this.coloresTSMI.Click += new System.EventHandler(this.coloresTSMI_Click);
            // 
            // marcasTSMI
            // 
            this.marcasTSMI.Enabled = false;
            this.marcasTSMI.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.marcasTSMI.Name = "marcasTSMI";
            this.marcasTSMI.Size = new System.Drawing.Size(57, 20);
            this.marcasTSMI.Text = "Marcas";
            this.marcasTSMI.Click += new System.EventHandler(this.marcasTSMI_Click);
            // 
            // facturasTSMI
            // 
            this.facturasTSMI.Enabled = false;
            this.facturasTSMI.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.facturasTSMI.Name = "facturasTSMI";
            this.facturasTSMI.Size = new System.Drawing.Size(63, 20);
            this.facturasTSMI.Text = "Facturas";
            this.facturasTSMI.Click += new System.EventHandler(this.facturasTSMI_Click);
            // 
            // salirTSMI
            // 
            this.salirTSMI.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.salirTSMI.Name = "salirTSMI";
            this.salirTSMI.Size = new System.Drawing.Size(41, 20);
            this.salirTSMI.Text = "Salir";
            this.salirTSMI.Click += new System.EventHandler(this.salirTSMI_Click);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::GridFreaks.Properties.Resources.LogoSample_ByTailorBrands_removebg_preview__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(634, 343);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.ToolStripMenuItem prendasTSMI;
        private System.Windows.Forms.ToolStripMenuItem coloresTSMI;
        private System.Windows.Forms.ToolStripMenuItem marcasTSMI;
        private System.Windows.Forms.ToolStripMenuItem facturasTSMI;
    }
}

