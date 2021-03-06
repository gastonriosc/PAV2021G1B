
namespace GridFreaks.GUILayer.Facturas
{
    partial class frmPrendasSelec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrendasSelec));
            this.cmbTipoPrenda = new System.Windows.Forms.ComboBox();
            this.lblTipoPrenda = new System.Windows.Forms.Label();
            this.dgvPrendas = new System.Windows.Forms.DataGridView();
            this.pbFotoPrenda = new System.Windows.Forms.PictureBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrendas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoPrenda)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbTipoPrenda
            // 
            this.cmbTipoPrenda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoPrenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.cmbTipoPrenda.FormattingEnabled = true;
            this.cmbTipoPrenda.Location = new System.Drawing.Point(137, 23);
            this.cmbTipoPrenda.Name = "cmbTipoPrenda";
            this.cmbTipoPrenda.Size = new System.Drawing.Size(131, 25);
            this.cmbTipoPrenda.TabIndex = 0;
            // 
            // lblTipoPrenda
            // 
            this.lblTipoPrenda.AutoSize = true;
            this.lblTipoPrenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblTipoPrenda.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTipoPrenda.Location = new System.Drawing.Point(25, 26);
            this.lblTipoPrenda.Name = "lblTipoPrenda";
            this.lblTipoPrenda.Size = new System.Drawing.Size(106, 17);
            this.lblTipoPrenda.TabIndex = 1;
            this.lblTipoPrenda.Text = "Tipo de Prenda";
            // 
            // dgvPrendas
            // 
            this.dgvPrendas.AllowUserToAddRows = false;
            this.dgvPrendas.AllowUserToDeleteRows = false;
            this.dgvPrendas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPrendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrendas.Location = new System.Drawing.Point(28, 61);
            this.dgvPrendas.Name = "dgvPrendas";
            this.dgvPrendas.ReadOnly = true;
            this.dgvPrendas.RowHeadersWidth = 51;
            this.dgvPrendas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrendas.Size = new System.Drawing.Size(348, 360);
            this.dgvPrendas.TabIndex = 2;
            this.dgvPrendas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPrendas_CellClick);
            // 
            // pbFotoPrenda
            // 
            this.pbFotoPrenda.Location = new System.Drawing.Point(395, 23);
            this.pbFotoPrenda.Name = "pbFotoPrenda";
            this.pbFotoPrenda.Size = new System.Drawing.Size(463, 436);
            this.pbFotoPrenda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbFotoPrenda.TabIndex = 20;
            this.pbFotoPrenda.TabStop = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Enabled = false;
            this.btnAceptar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnAceptar.Image = global::GridFreaks.Properties.Resources.Aceptar;
            this.btnAceptar.Location = new System.Drawing.Point(278, 434);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(99, 31);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnBuscar.Image = global::GridFreaks.Properties.Resources.Consultar;
            this.btnBuscar.Location = new System.Drawing.Point(278, 19);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(99, 32);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // frmPrendasSelec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(873, 475);
            this.Controls.Add(this.pbFotoPrenda);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dgvPrendas);
            this.Controls.Add(this.lblTipoPrenda);
            this.Controls.Add(this.cmbTipoPrenda);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrendasSelec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccionar Prenda";
            this.Load += new System.EventHandler(this.frmPrendasSelec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrendas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoPrenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTipoPrenda;
        private System.Windows.Forms.Label lblTipoPrenda;
        private System.Windows.Forms.DataGridView dgvPrendas;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.PictureBox pbFotoPrenda;
    }
}