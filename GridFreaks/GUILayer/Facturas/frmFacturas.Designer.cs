
namespace GridFreaks.GUILayer.Facturas
{
    partial class frmFacturas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFacturas));
            this.cmbTipoFactura = new System.Windows.Forms.ComboBox();
            this.lblTipoFactura = new System.Windows.Forms.Label();
            this.lblClientes = new System.Windows.Forms.Label();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.txtNroFactura = new System.Windows.Forms.TextBox();
            this.lblNroFactura = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCUIT = new System.Windows.Forms.MaskedTextBox();
            this.lblCUIT = new System.Windows.Forms.Label();
            this.dpbDetalle = new System.Windows.Forms.GroupBox();
            this.txtPrendaSelected = new System.Windows.Forms.TextBox();
            this.btnSelecPrenda = new System.Windows.Forms.Button();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.txtImporteTotal = new System.Windows.Forms.TextBox();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.lblImporteTotal = new System.Windows.Forms.Label();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.lblImporte = new System.Windows.Forms.Label();
            this._btnCancelar = new System.Windows.Forms.Button();
            this._btnQuitar = new System.Windows.Forms.Button();
            this._btnAgregar = new System.Windows.Forms.Button();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this._lblCantidad = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.dpbDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbTipoFactura
            // 
            this.cmbTipoFactura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.cmbTipoFactura.FormattingEnabled = true;
            this.cmbTipoFactura.Location = new System.Drawing.Point(110, 22);
            this.cmbTipoFactura.Name = "cmbTipoFactura";
            this.cmbTipoFactura.Size = new System.Drawing.Size(126, 25);
            this.cmbTipoFactura.TabIndex = 0;
            // 
            // lblTipoFactura
            // 
            this.lblTipoFactura.AutoSize = true;
            this.lblTipoFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoFactura.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTipoFactura.Location = new System.Drawing.Point(14, 25);
            this.lblTipoFactura.Name = "lblTipoFactura";
            this.lblTipoFactura.Size = new System.Drawing.Size(88, 17);
            this.lblTipoFactura.TabIndex = 1;
            this.lblTipoFactura.Text = "Tipo Factura";
            // 
            // lblClientes
            // 
            this.lblClientes.AutoSize = true;
            this.lblClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblClientes.Location = new System.Drawing.Point(51, 65);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(51, 17);
            this.lblClientes.TabIndex = 3;
            this.lblClientes.Text = "Cliente";
            // 
            // cmbCliente
            // 
            this.cmbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(110, 62);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(126, 25);
            this.cmbCliente.TabIndex = 2;
            // 
            // txtNroFactura
            // 
            this.txtNroFactura.Enabled = false;
            this.txtNroFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtNroFactura.Location = new System.Drawing.Point(383, 22);
            this.txtNroFactura.Name = "txtNroFactura";
            this.txtNroFactura.Size = new System.Drawing.Size(126, 23);
            this.txtNroFactura.TabIndex = 4;
            // 
            // lblNroFactura
            // 
            this.lblNroFactura.AutoSize = true;
            this.lblNroFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroFactura.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNroFactura.Location = new System.Drawing.Point(294, 25);
            this.lblNroFactura.Name = "lblNroFactura";
            this.lblNroFactura.Size = new System.Drawing.Size(83, 17);
            this.lblNroFactura.TabIndex = 5;
            this.lblNroFactura.Text = "Nro Factura";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDireccion.Location = new System.Drawing.Point(310, 65);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(67, 17);
            this.lblDireccion.TabIndex = 6;
            this.lblDireccion.Text = "Direccion";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Enabled = false;
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtDireccion.Location = new System.Drawing.Point(383, 62);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(196, 23);
            this.txtDireccion.TabIndex = 7;
            // 
            // dtpFecha
            // 
            this.dtpFecha.CustomFormat = "";
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(706, 22);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(108, 23);
            this.dtpFecha.TabIndex = 9;
            this.dtpFecha.Value = new System.DateTime(2021, 10, 8, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(653, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Fecha";
            // 
            // txtCUIT
            // 
            this.txtCUIT.Enabled = false;
            this.txtCUIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtCUIT.Location = new System.Drawing.Point(706, 62);
            this.txtCUIT.Mask = "00-00000000-0";
            this.txtCUIT.Name = "txtCUIT";
            this.txtCUIT.Size = new System.Drawing.Size(108, 23);
            this.txtCUIT.TabIndex = 11;
            // 
            // lblCUIT
            // 
            this.lblCUIT.AutoSize = true;
            this.lblCUIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCUIT.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCUIT.Location = new System.Drawing.Point(661, 65);
            this.lblCUIT.Name = "lblCUIT";
            this.lblCUIT.Size = new System.Drawing.Size(39, 17);
            this.lblCUIT.TabIndex = 12;
            this.lblCUIT.Text = "CUIT";
            // 
            // dpbDetalle
            // 
            this.dpbDetalle.Controls.Add(this.txtPrendaSelected);
            this.dpbDetalle.Controls.Add(this.btnSelecPrenda);
            this.dpbDetalle.Controls.Add(this.nudCantidad);
            this.dpbDetalle.Controls.Add(this.txtImporteTotal);
            this.dpbDetalle.Controls.Add(this.txtDescuento);
            this.dpbDetalle.Controls.Add(this.txtSubtotal);
            this.dpbDetalle.Controls.Add(this.lblImporteTotal);
            this.dpbDetalle.Controls.Add(this.lblDescuento);
            this.dpbDetalle.Controls.Add(this.lblSubtotal);
            this.dpbDetalle.Controls.Add(this.txtImporte);
            this.dpbDetalle.Controls.Add(this.lblImporte);
            this.dpbDetalle.Controls.Add(this._btnCancelar);
            this.dpbDetalle.Controls.Add(this._btnQuitar);
            this.dpbDetalle.Controls.Add(this._btnAgregar);
            this.dpbDetalle.Controls.Add(this.dgvDetalle);
            this.dpbDetalle.Controls.Add(this.txtPrecio);
            this.dpbDetalle.Controls.Add(this.lblPrecio);
            this.dpbDetalle.Controls.Add(this._lblCantidad);
            this.dpbDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpbDetalle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.dpbDetalle.Location = new System.Drawing.Point(17, 97);
            this.dpbDetalle.Name = "dpbDetalle";
            this.dpbDetalle.Size = new System.Drawing.Size(797, 362);
            this.dpbDetalle.TabIndex = 13;
            this.dpbDetalle.TabStop = false;
            this.dpbDetalle.Text = "Detalle";
            // 
            // txtPrendaSelected
            // 
            this.txtPrendaSelected.Enabled = false;
            this.txtPrendaSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtPrendaSelected.Location = new System.Drawing.Point(13, 60);
            this.txtPrendaSelected.Name = "txtPrendaSelected";
            this.txtPrendaSelected.Size = new System.Drawing.Size(244, 23);
            this.txtPrendaSelected.TabIndex = 17;
            // 
            // btnSelecPrenda
            // 
            this.btnSelecPrenda.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSelecPrenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelecPrenda.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSelecPrenda.Image = global::GridFreaks.Properties.Resources.SeleccionarPrenda;
            this.btnSelecPrenda.Location = new System.Drawing.Point(13, 23);
            this.btnSelecPrenda.Name = "btnSelecPrenda";
            this.btnSelecPrenda.Size = new System.Drawing.Size(178, 31);
            this.btnSelecPrenda.TabIndex = 17;
            this.btnSelecPrenda.UseVisualStyleBackColor = true;
            this.btnSelecPrenda.Click += new System.EventHandler(this.btnSelecPrenda_Click);
            // 
            // nudCantidad
            // 
            this.nudCantidad.Enabled = false;
            this.nudCantidad.Location = new System.Drawing.Point(357, 23);
            this.nudCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(64, 23);
            this.nudCantidad.TabIndex = 31;
            this.nudCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantidad.ValueChanged += new System.EventHandler(this.nudCantidad_ValueChanged);
            // 
            // txtImporteTotal
            // 
            this.txtImporteTotal.Enabled = false;
            this.txtImporteTotal.Location = new System.Drawing.Point(683, 324);
            this.txtImporteTotal.Name = "txtImporteTotal";
            this.txtImporteTotal.Size = new System.Drawing.Size(100, 23);
            this.txtImporteTotal.TabIndex = 27;
            this.txtImporteTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDescuento
            // 
            this.txtDescuento.Enabled = false;
            this.txtDescuento.Location = new System.Drawing.Point(462, 324);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(100, 23);
            this.txtDescuento.TabIndex = 26;
            this.txtDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDescuento.TextChanged += new System.EventHandler(this.txtDescuento_TextChanged);
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Enabled = false;
            this.txtSubtotal.Location = new System.Drawing.Point(225, 324);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(100, 23);
            this.txtSubtotal.TabIndex = 25;
            this.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblImporteTotal
            // 
            this.lblImporteTotal.AutoSize = true;
            this.lblImporteTotal.Location = new System.Drawing.Point(586, 327);
            this.lblImporteTotal.Name = "lblImporteTotal";
            this.lblImporteTotal.Size = new System.Drawing.Size(91, 17);
            this.lblImporteTotal.TabIndex = 30;
            this.lblImporteTotal.Text = "Importe Total";
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Location = new System.Drawing.Point(354, 327);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(102, 17);
            this.lblDescuento.TabIndex = 29;
            this.lblDescuento.Text = "Descuento (%)";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(159, 327);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(60, 17);
            this.lblSubtotal.TabIndex = 28;
            this.lblSubtotal.Text = "Subtotal";
            // 
            // txtImporte
            // 
            this.txtImporte.Enabled = false;
            this.txtImporte.Location = new System.Drawing.Point(498, 23);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.ReadOnly = true;
            this.txtImporte.Size = new System.Drawing.Size(64, 23);
            this.txtImporte.TabIndex = 3;
            // 
            // lblImporte
            // 
            this.lblImporte.AutoSize = true;
            this.lblImporte.Location = new System.Drawing.Point(437, 25);
            this.lblImporte.Name = "lblImporte";
            this.lblImporte.Size = new System.Drawing.Size(55, 17);
            this.lblImporte.TabIndex = 8;
            this.lblImporte.Text = "Importe";
            // 
            // _btnCancelar
            // 
            this._btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnCancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this._btnCancelar.Image = global::GridFreaks.Properties.Resources.CancelarIcon;
            this._btnCancelar.Location = new System.Drawing.Point(710, 25);
            this._btnCancelar.Name = "_btnCancelar";
            this._btnCancelar.Size = new System.Drawing.Size(68, 54);
            this._btnCancelar.TabIndex = 7;
            this._btnCancelar.UseVisualStyleBackColor = true;
            this._btnCancelar.Click += new System.EventHandler(this._btnCancelar_Click);
            // 
            // _btnQuitar
            // 
            this._btnQuitar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._btnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnQuitar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this._btnQuitar.Image = global::GridFreaks.Properties.Resources.QuitarIcon;
            this._btnQuitar.Location = new System.Drawing.Point(655, 29);
            this._btnQuitar.Name = "_btnQuitar";
            this._btnQuitar.Size = new System.Drawing.Size(49, 47);
            this._btnQuitar.TabIndex = 6;
            this._btnQuitar.UseVisualStyleBackColor = true;
            this._btnQuitar.Click += new System.EventHandler(this._btnQuitar_Click);
            // 
            // _btnAgregar
            // 
            this._btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnAgregar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this._btnAgregar.Image = global::GridFreaks.Properties.Resources.AgregarIcon;
            this._btnAgregar.Location = new System.Drawing.Point(604, 29);
            this._btnAgregar.Name = "_btnAgregar";
            this._btnAgregar.Size = new System.Drawing.Size(45, 47);
            this._btnAgregar.TabIndex = 5;
            this._btnAgregar.UseVisualStyleBackColor = true;
            this._btnAgregar.Click += new System.EventHandler(this._btnAgregar_Click);
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.AllowUserToAddRows = false;
            this.dgvDetalle.AllowUserToDeleteRows = false;
            this.dgvDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalle.Location = new System.Drawing.Point(13, 92);
            this.dgvDetalle.MultiSelect = false;
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.ReadOnly = true;
            this.dgvDetalle.RowHeadersWidth = 51;
            this.dgvDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalle.Size = new System.Drawing.Size(770, 221);
            this.dgvDetalle.TabIndex = 7;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Enabled = false;
            this.txtPrecio.Location = new System.Drawing.Point(357, 59);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.ReadOnly = true;
            this.txtPrecio.Size = new System.Drawing.Size(64, 23);
            this.txtPrecio.TabIndex = 2;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(303, 62);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(48, 17);
            this.lblPrecio.TabIndex = 4;
            this.lblPrecio.Text = "Precio";
            // 
            // _lblCantidad
            // 
            this._lblCantidad.AutoSize = true;
            this._lblCantidad.Location = new System.Drawing.Point(287, 25);
            this._lblCantidad.Name = "_lblCantidad";
            this._lblCantidad.Size = new System.Drawing.Size(64, 17);
            this._lblCantidad.TabIndex = 2;
            this._lblCantidad.Text = "Cantidad";
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnSalir.Image = global::GridFreaks.Properties.Resources.salir__2_;
            this.btnSalir.Location = new System.Drawing.Point(716, 470);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(97, 31);
            this.btnSalir.TabIndex = 16;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGrabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrabar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnGrabar.Image = global::GridFreaks.Properties.Resources.GuardarIcon_;
            this.btnGrabar.Location = new System.Drawing.Point(110, 470);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(123, 31);
            this.btnGrabar.TabIndex = 15;
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click_1);
            // 
            // btnNuevo
            // 
            this.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnNuevo.Image = global::GridFreaks.Properties.Resources.NuevoIcon;
            this.btnNuevo.Location = new System.Drawing.Point(17, 470);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(85, 28);
            this.btnNuevo.TabIndex = 14;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // frmFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(833, 511);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dpbDetalle);
            this.Controls.Add(this.lblCUIT);
            this.Controls.Add(this.txtCUIT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblNroFactura);
            this.Controls.Add(this.txtNroFactura);
            this.Controls.Add(this.lblClientes);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.lblTipoFactura);
            this.Controls.Add(this.cmbTipoFactura);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFacturas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Facturas";
            this.Load += new System.EventHandler(this.frmFacturas_Load);
            this.dpbDetalle.ResumeLayout(false);
            this.dpbDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTipoFactura;
        private System.Windows.Forms.Label lblTipoFactura;
        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.TextBox txtNroFactura;
        private System.Windows.Forms.Label lblNroFactura;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtCUIT;
        private System.Windows.Forms.Label lblCUIT;
        private System.Windows.Forms.GroupBox dpbDetalle;
        private System.Windows.Forms.TextBox txtImporteTotal;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label lblImporteTotal;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.Label lblImporte;
        private System.Windows.Forms.Button _btnCancelar;
        private System.Windows.Forms.Button _btnQuitar;
        private System.Windows.Forms.Button _btnAgregar;
        private System.Windows.Forms.DataGridView dgvDetalle;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label _lblCantidad;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Button btnSelecPrenda;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtPrendaSelected;
    }
}