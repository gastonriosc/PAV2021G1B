
namespace GridFreaks.GUILayer.Reportes
{
    partial class frmReportes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportes));
            this.gbFiltros = new System.Windows.Forms.GroupBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.nudPrecioMax = new System.Windows.Forms.NumericUpDown();
            this.nudPrecioMin = new System.Windows.Forms.NumericUpDown();
            this.lblPrecioMax = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrendaSelec = new System.Windows.Forms.Button();
            this.lblMarca = new System.Windows.Forms.Label();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.txtPrendaSelected = new System.Windows.Forms.TextBox();
            this.lblPrenda = new System.Windows.Forms.Label();
            this.lblClientes = new System.Windows.Forms.Label();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.lblTipoFactura = new System.Windows.Forms.Label();
            this.cmbTipoFactura = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dtFacturasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetFacturas = new GridFreaks.GUILayer.Reportes.DataSetFacturas();
            this.gbFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFacturasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetFacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // gbFiltros
            // 
            this.gbFiltros.Controls.Add(this.btnConsultar);
            this.gbFiltros.Controls.Add(this.nudPrecioMax);
            this.gbFiltros.Controls.Add(this.nudPrecioMin);
            this.gbFiltros.Controls.Add(this.lblPrecioMax);
            this.gbFiltros.Controls.Add(this.label1);
            this.gbFiltros.Controls.Add(this.btnPrendaSelec);
            this.gbFiltros.Controls.Add(this.lblMarca);
            this.gbFiltros.Controls.Add(this.cmbMarca);
            this.gbFiltros.Controls.Add(this.txtPrendaSelected);
            this.gbFiltros.Controls.Add(this.lblPrenda);
            this.gbFiltros.Controls.Add(this.lblClientes);
            this.gbFiltros.Controls.Add(this.cmbCliente);
            this.gbFiltros.Controls.Add(this.lblTipoFactura);
            this.gbFiltros.Controls.Add(this.cmbTipoFactura);
            this.gbFiltros.Controls.Add(this.label2);
            this.gbFiltros.Controls.Add(this.lblFechaDesde);
            this.gbFiltros.Controls.Add(this.dtpFechaHasta);
            this.gbFiltros.Controls.Add(this.dtpFechaDesde);
            this.gbFiltros.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.gbFiltros.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gbFiltros.Location = new System.Drawing.Point(11, 12);
            this.gbFiltros.Name = "gbFiltros";
            this.gbFiltros.Size = new System.Drawing.Size(836, 277);
            this.gbFiltros.TabIndex = 1;
            this.gbFiltros.TabStop = false;
            this.gbFiltros.Text = "Filtros";
            // 
            // btnConsultar
            // 
            this.btnConsultar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Image = global::GridFreaks.Properties.Resources.Consultar;
            this.btnConsultar.Location = new System.Drawing.Point(626, 219);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(114, 32);
            this.btnConsultar.TabIndex = 9;
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // nudPrecioMax
            // 
            this.nudPrecioMax.Location = new System.Drawing.Point(605, 127);
            this.nudPrecioMax.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudPrecioMax.Name = "nudPrecioMax";
            this.nudPrecioMax.Size = new System.Drawing.Size(135, 23);
            this.nudPrecioMax.TabIndex = 6;
            // 
            // nudPrecioMin
            // 
            this.nudPrecioMin.Location = new System.Drawing.Point(166, 127);
            this.nudPrecioMin.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudPrecioMin.Name = "nudPrecioMin";
            this.nudPrecioMin.Size = new System.Drawing.Size(135, 23);
            this.nudPrecioMin.TabIndex = 5;
            // 
            // lblPrecioMax
            // 
            this.lblPrecioMax.AutoSize = true;
            this.lblPrecioMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPrecioMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioMax.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPrecioMax.Location = new System.Drawing.Point(500, 129);
            this.lblPrecioMax.Name = "lblPrecioMax";
            this.lblPrecioMax.Size = new System.Drawing.Size(103, 17);
            this.lblPrecioMax.TabIndex = 38;
            this.lblPrecioMax.Text = "Precio Máximo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(64, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 37;
            this.label1.Text = "Precio Mínimo:";
            // 
            // btnPrendaSelec
            // 
            this.btnPrendaSelec.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPrendaSelec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrendaSelec.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPrendaSelec.Image = global::GridFreaks.Properties.Resources.Seleccionar;
            this.btnPrendaSelec.Location = new System.Drawing.Point(166, 170);
            this.btnPrendaSelec.Name = "btnPrendaSelec";
            this.btnPrendaSelec.Size = new System.Drawing.Size(116, 25);
            this.btnPrendaSelec.TabIndex = 7;
            this.btnPrendaSelec.UseVisualStyleBackColor = true;
            this.btnPrendaSelec.Click += new System.EventHandler(this.btnPrendaSelec_Click);
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblMarca.Location = new System.Drawing.Point(552, 85);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(51, 17);
            this.lblMarca.TabIndex = 22;
            this.lblMarca.Text = "Marca:";
            // 
            // cmbMarca
            // 
            this.cmbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Location = new System.Drawing.Point(605, 82);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(135, 25);
            this.cmbMarca.TabIndex = 4;
            // 
            // txtPrendaSelected
            // 
            this.txtPrendaSelected.Enabled = false;
            this.txtPrendaSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtPrendaSelected.Location = new System.Drawing.Point(109, 212);
            this.txtPrendaSelected.Name = "txtPrendaSelected";
            this.txtPrendaSelected.Size = new System.Drawing.Size(192, 23);
            this.txtPrendaSelected.TabIndex = 20;
            // 
            // lblPrenda
            // 
            this.lblPrenda.AutoSize = true;
            this.lblPrenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrenda.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPrenda.Location = new System.Drawing.Point(106, 175);
            this.lblPrenda.Name = "lblPrenda";
            this.lblPrenda.Size = new System.Drawing.Size(58, 17);
            this.lblPrenda.TabIndex = 18;
            this.lblPrenda.Text = "Prenda:";
            // 
            // lblClientes
            // 
            this.lblClientes.AutoSize = true;
            this.lblClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblClientes.Location = new System.Drawing.Point(548, 174);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(55, 17);
            this.lblClientes.TabIndex = 17;
            this.lblClientes.Text = "Cliente:";
            // 
            // cmbCliente
            // 
            this.cmbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(605, 171);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(135, 25);
            this.cmbCliente.TabIndex = 8;
            // 
            // lblTipoFactura
            // 
            this.lblTipoFactura.AutoSize = true;
            this.lblTipoFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoFactura.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTipoFactura.Location = new System.Drawing.Point(72, 85);
            this.lblTipoFactura.Name = "lblTipoFactura";
            this.lblTipoFactura.Size = new System.Drawing.Size(92, 17);
            this.lblTipoFactura.TabIndex = 15;
            this.lblTipoFactura.Text = "Tipo Factura:";
            // 
            // cmbTipoFactura
            // 
            this.cmbTipoFactura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.cmbTipoFactura.FormattingEnabled = true;
            this.cmbTipoFactura.Location = new System.Drawing.Point(166, 82);
            this.cmbTipoFactura.Name = "cmbTipoFactura";
            this.cmbTipoFactura.Size = new System.Drawing.Size(135, 25);
            this.cmbTipoFactura.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(511, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Fecha Hasta:";
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.Location = new System.Drawing.Point(68, 42);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(96, 17);
            this.lblFechaDesde.TabIndex = 12;
            this.lblFechaDesde.Text = "Fecha Desde:";
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.CustomFormat = "";
            this.dtpFechaHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(605, 37);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(135, 23);
            this.dtpFechaHasta.TabIndex = 2;
            this.dtpFechaHasta.Value = new System.DateTime(2021, 10, 8, 0, 0, 0, 0);
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.CustomFormat = "";
            this.dtpFechaDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(166, 37);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(135, 23);
            this.dtpFechaDesde.TabIndex = 1;
            this.dtpFechaDesde.Value = new System.DateTime(2021, 10, 8, 0, 0, 0, 0);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.dtFacturasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GridFreaks.GUILayer.Reportes.Reporte.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(11, 295);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(836, 367);
            this.reportViewer1.TabIndex = 2;
            // 
            // dtFacturasBindingSource
            // 
            this.dtFacturasBindingSource.DataMember = "dtFacturas";
            this.dtFacturasBindingSource.DataSource = this.DataSetFacturas;
            // 
            // DataSetFacturas
            // 
            this.DataSetFacturas.DataSetName = "DataSetFacturas";
            this.DataSetFacturas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(860, 674);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.gbFiltros);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Reportes";
            this.Load += new System.EventHandler(this.frmReportes_Load);
            this.gbFiltros.ResumeLayout(false);
            this.gbFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFacturasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetFacturas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbFiltros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Label lblTipoFactura;
        private System.Windows.Forms.ComboBox cmbTipoFactura;
        private System.Windows.Forms.Label lblPrenda;
        private System.Windows.Forms.TextBox txtPrendaSelected;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.Button btnPrendaSelec;
        private System.Windows.Forms.NumericUpDown nudPrecioMax;
        private System.Windows.Forms.NumericUpDown nudPrecioMin;
        private System.Windows.Forms.Label lblPrecioMax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConsultar;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dtFacturasBindingSource;
        private DataSetFacturas DataSetFacturas;
    }
}