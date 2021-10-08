
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
            this.cmbTipoPrenda = new System.Windows.Forms.ComboBox();
            this.lblTipoPrenda = new System.Windows.Forms.Label();
            this.dgvPrendas = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.pbFotoPrenda = new System.Windows.Forms.PictureBox();
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
            this.dgvPrendas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrendas.Size = new System.Drawing.Size(348, 360);
            this.dgvPrendas.TabIndex = 2;
            this.dgvPrendas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPrendas_CellClick);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnBuscar.Location = new System.Drawing.Point(290, 23);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(86, 25);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Enabled = false;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnAceptar.Location = new System.Drawing.Point(290, 434);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(86, 25);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
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
            this.Name = "frmPrendasSelec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrendasSelec";
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