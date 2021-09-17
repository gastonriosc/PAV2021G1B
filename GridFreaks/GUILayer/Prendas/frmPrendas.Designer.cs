
namespace GridFreaks.GUILayer.Prendas
{
    partial class frmPrendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrendas));
            this.lblTipoPrenda = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.gbFiltrosPrendas = new System.Windows.Forms.GroupBox();
            this.chkTodos = new System.Windows.Forms.CheckBox();
            this.UpDownPrecioMax = new System.Windows.Forms.NumericUpDown();
            this.UpDownPrecioMin = new System.Windows.Forms.NumericUpDown();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lblPrecioMax = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboTemporada = new System.Windows.Forms.ComboBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblTemporada = new System.Windows.Forms.Label();
            this.comboMarca = new System.Windows.Forms.ComboBox();
            this.comboColor = new System.Windows.Forms.ComboBox();
            this.comboTipoPrenda = new System.Windows.Forms.ComboBox();
            this.dgvPrendas = new System.Windows.Forms.DataGridView();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.pbPrenda = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.gbFiltrosPrendas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownPrecioMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownPrecioMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrendas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrenda)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTipoPrenda
            // 
            this.lblTipoPrenda.AutoSize = true;
            this.lblTipoPrenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTipoPrenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoPrenda.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTipoPrenda.Location = new System.Drawing.Point(22, 34);
            this.lblTipoPrenda.Name = "lblTipoPrenda";
            this.lblTipoPrenda.Size = new System.Drawing.Size(110, 17);
            this.lblTipoPrenda.TabIndex = 1;
            this.lblTipoPrenda.Text = "Tipo de Prenda:";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblColor.Location = new System.Drawing.Point(87, 72);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(45, 17);
            this.lblColor.TabIndex = 2;
            this.lblColor.Text = "Color:";
            // 
            // gbFiltrosPrendas
            // 
            this.gbFiltrosPrendas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gbFiltrosPrendas.Controls.Add(this.chkTodos);
            this.gbFiltrosPrendas.Controls.Add(this.UpDownPrecioMax);
            this.gbFiltrosPrendas.Controls.Add(this.UpDownPrecioMin);
            this.gbFiltrosPrendas.Controls.Add(this.btnConsultar);
            this.gbFiltrosPrendas.Controls.Add(this.lblPrecioMax);
            this.gbFiltrosPrendas.Controls.Add(this.label2);
            this.gbFiltrosPrendas.Controls.Add(this.comboTemporada);
            this.gbFiltrosPrendas.Controls.Add(this.lblMarca);
            this.gbFiltrosPrendas.Controls.Add(this.lblTemporada);
            this.gbFiltrosPrendas.Controls.Add(this.comboMarca);
            this.gbFiltrosPrendas.Controls.Add(this.comboColor);
            this.gbFiltrosPrendas.Controls.Add(this.lblTipoPrenda);
            this.gbFiltrosPrendas.Controls.Add(this.comboTipoPrenda);
            this.gbFiltrosPrendas.Controls.Add(this.lblColor);
            this.gbFiltrosPrendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFiltrosPrendas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gbFiltrosPrendas.Location = new System.Drawing.Point(12, 12);
            this.gbFiltrosPrendas.Name = "gbFiltrosPrendas";
            this.gbFiltrosPrendas.Size = new System.Drawing.Size(644, 155);
            this.gbFiltrosPrendas.TabIndex = 3;
            this.gbFiltrosPrendas.TabStop = false;
            this.gbFiltrosPrendas.Text = "Filtros";
            // 
            // chkTodos
            // 
            this.chkTodos.AutoSize = true;
            this.chkTodos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chkTodos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.chkTodos.Location = new System.Drawing.Point(539, 45);
            this.chkTodos.Name = "chkTodos";
            this.chkTodos.Size = new System.Drawing.Size(67, 21);
            this.chkTodos.TabIndex = 18;
            this.chkTodos.Text = "Todos";
            this.chkTodos.UseVisualStyleBackColor = false;
            // 
            // UpDownPrecioMax
            // 
            this.UpDownPrecioMax.Location = new System.Drawing.Point(391, 108);
            this.UpDownPrecioMax.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.UpDownPrecioMax.Name = "UpDownPrecioMax";
            this.UpDownPrecioMax.Size = new System.Drawing.Size(113, 23);
            this.UpDownPrecioMax.TabIndex = 16;
            // 
            // UpDownPrecioMin
            // 
            this.UpDownPrecioMin.Location = new System.Drawing.Point(144, 108);
            this.UpDownPrecioMin.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.UpDownPrecioMin.Name = "UpDownPrecioMin";
            this.UpDownPrecioMin.Size = new System.Drawing.Size(113, 23);
            this.UpDownPrecioMin.TabIndex = 15;
            // 
            // btnConsultar
            // 
            this.btnConsultar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Image = global::GridFreaks.Properties.Resources.Consultar;
            this.btnConsultar.Location = new System.Drawing.Point(522, 99);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(103, 32);
            this.btnConsultar.TabIndex = 12;
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // lblPrecioMax
            // 
            this.lblPrecioMax.AutoSize = true;
            this.lblPrecioMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPrecioMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioMax.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPrecioMax.Location = new System.Drawing.Point(282, 110);
            this.lblPrecioMax.Name = "lblPrecioMax";
            this.lblPrecioMax.Size = new System.Drawing.Size(103, 17);
            this.lblPrecioMax.TabIndex = 10;
            this.lblPrecioMax.Text = "Precio Maximo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(32, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Precio Mínimo:";
            // 
            // comboTemporada
            // 
            this.comboTemporada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTemporada.FormattingEnabled = true;
            this.comboTemporada.Location = new System.Drawing.Point(391, 69);
            this.comboTemporada.Name = "comboTemporada";
            this.comboTemporada.Size = new System.Drawing.Size(113, 25);
            this.comboTemporada.TabIndex = 7;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblMarca.Location = new System.Drawing.Point(334, 34);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(51, 17);
            this.lblMarca.TabIndex = 5;
            this.lblMarca.Text = "Marca:";
            // 
            // lblTemporada
            // 
            this.lblTemporada.AutoSize = true;
            this.lblTemporada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTemporada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemporada.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTemporada.Location = new System.Drawing.Point(300, 72);
            this.lblTemporada.Name = "lblTemporada";
            this.lblTemporada.Size = new System.Drawing.Size(85, 17);
            this.lblTemporada.TabIndex = 6;
            this.lblTemporada.Text = "Temporada:";
            // 
            // comboMarca
            // 
            this.comboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMarca.FormattingEnabled = true;
            this.comboMarca.Location = new System.Drawing.Point(391, 31);
            this.comboMarca.Name = "comboMarca";
            this.comboMarca.Size = new System.Drawing.Size(113, 25);
            this.comboMarca.TabIndex = 4;
            // 
            // comboColor
            // 
            this.comboColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboColor.FormattingEnabled = true;
            this.comboColor.Location = new System.Drawing.Point(144, 69);
            this.comboColor.Name = "comboColor";
            this.comboColor.Size = new System.Drawing.Size(113, 25);
            this.comboColor.TabIndex = 3;
            // 
            // comboTipoPrenda
            // 
            this.comboTipoPrenda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTipoPrenda.FormattingEnabled = true;
            this.comboTipoPrenda.Location = new System.Drawing.Point(144, 31);
            this.comboTipoPrenda.Name = "comboTipoPrenda";
            this.comboTipoPrenda.Size = new System.Drawing.Size(113, 25);
            this.comboTipoPrenda.TabIndex = 0;
            // 
            // dgvPrendas
            // 
            this.dgvPrendas.AllowUserToAddRows = false;
            this.dgvPrendas.AllowUserToDeleteRows = false;
            this.dgvPrendas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPrendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrendas.Location = new System.Drawing.Point(12, 183);
            this.dgvPrendas.Name = "dgvPrendas";
            this.dgvPrendas.ReadOnly = true;
            this.dgvPrendas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrendas.Size = new System.Drawing.Size(644, 221);
            this.dgvPrendas.TabIndex = 4;
            this.dgvPrendas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPrendas_CellClick);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Image = global::GridFreaks.Properties.Resources.RegistrarPrenda;
            this.btnRegistrar.Location = new System.Drawing.Point(12, 418);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(133, 36);
            this.btnRegistrar.TabIndex = 18;
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // pbPrenda
            // 
            this.pbPrenda.Location = new System.Drawing.Point(672, 18);
            this.pbPrenda.Name = "pbPrenda";
            this.pbPrenda.Size = new System.Drawing.Size(463, 436);
            this.pbPrenda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbPrenda.TabIndex = 19;
            this.pbPrenda.TabStop = false;
            this.pbPrenda.Visible = false;
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Image = global::GridFreaks.Properties.Resources.Salir;
            this.btnSalir.Location = new System.Drawing.Point(591, 418);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(65, 30);
            this.btnSalir.TabIndex = 15;
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Image = global::GridFreaks.Properties.Resources.EliminarPrenda;
            this.btnEliminar.Location = new System.Drawing.Point(315, 418);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(160, 36);
            this.btnEliminar.TabIndex = 16;
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Image = global::GridFreaks.Properties.Resources.ModificarPrenda;
            this.btnModificar.Location = new System.Drawing.Point(151, 418);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(158, 36);
            this.btnModificar.TabIndex = 17;
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // frmPrendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(667, 467);
            this.Controls.Add(this.pbPrenda);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.dgvPrendas);
            this.Controls.Add(this.gbFiltrosPrendas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrendas";
            this.Text = "frmPrendas";
            this.Load += new System.EventHandler(this.frmPrendas_Load);
            this.gbFiltrosPrendas.ResumeLayout(false);
            this.gbFiltrosPrendas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownPrecioMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownPrecioMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrendas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTipoPrenda;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.GroupBox gbFiltrosPrendas;
        private System.Windows.Forms.Label lblPrecioMax;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboTemporada;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblTemporada;
        private System.Windows.Forms.ComboBox comboMarca;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.ComboBox comboColor;
        private System.Windows.Forms.ComboBox comboTipoPrenda;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.PictureBox pbPrenda;
        internal System.Windows.Forms.DataGridView dgvPrendas;
        private System.Windows.Forms.NumericUpDown UpDownPrecioMax;
        private System.Windows.Forms.NumericUpDown UpDownPrecioMin;
        internal System.Windows.Forms.CheckBox chkTodos;
    }
}