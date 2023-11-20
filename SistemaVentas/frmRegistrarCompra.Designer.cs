namespace SistemaVentas
{
    partial class frmRegistrarCompra
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombreTienda = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBuscarTienda = new System.Windows.Forms.Button();
            this.txtRucTienda = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.NumericUpDown();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.txtPrecioCompra = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.txtCodigoProducto = new System.Windows.Forms.TextBox();
            this.txtRazonSocialProveedor = new System.Windows.Forms.TextBox();
            this.txtRucProveedor = new System.Windows.Forms.TextBox();
            this.btnBuscarProveedor = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvDetalleCompra = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardarCompra = new System.Windows.Forms.Button();
            this.txtIdTienda = new System.Windows.Forms.TextBox();
            this.txtIdProveedor = new System.Windows.Forms.TextBox();
            this.txtIdProducto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 999;
            this.label3.Text = "RUC:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(457, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 999;
            this.label4.Text = "Código:";
            // 
            // txtNombreTienda
            // 
            this.txtNombreTienda.Location = new System.Drawing.Point(291, 162);
            this.txtNombreTienda.Name = "txtNombreTienda";
            this.txtNombreTienda.ReadOnly = true;
            this.txtNombreTienda.Size = new System.Drawing.Size(122, 20);
            this.txtNombreTienda.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(241, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 999;
            this.label7.Text = "Nombre:";
            // 
            // btnBuscarTienda
            // 
            this.btnBuscarTienda.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnBuscarTienda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarTienda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarTienda.ForeColor = System.Drawing.Color.White;
            this.btnBuscarTienda.Location = new System.Drawing.Point(244, 188);
            this.btnBuscarTienda.Name = "btnBuscarTienda";
            this.btnBuscarTienda.Size = new System.Drawing.Size(169, 23);
            this.btnBuscarTienda.TabIndex = 5;
            this.btnBuscarTienda.Text = "Buscar";
            this.btnBuscarTienda.UseVisualStyleBackColor = false;
            this.btnBuscarTienda.Click += new System.EventHandler(this.btnBuscarTienda_Click);
            // 
            // txtRucTienda
            // 
            this.txtRucTienda.Location = new System.Drawing.Point(279, 133);
            this.txtRucTienda.Name = "txtRucTienda";
            this.txtRucTienda.ReadOnly = true;
            this.txtRucTienda.Size = new System.Drawing.Size(134, 20);
            this.txtRucTienda.TabIndex = 3;
            // 
            // txtCantidad
            // 
            this.txtCantidad.InterceptArrowKeys = false;
            this.txtCantidad.Location = new System.Drawing.Point(460, 214);
            this.txtCantidad.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(92, 20);
            this.txtCantidad.TabIndex = 9;
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Location = new System.Drawing.Point(558, 172);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(92, 20);
            this.txtPrecioVenta.TabIndex = 11;
            this.txtPrecioVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioVenta_KeyPress);
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.Location = new System.Drawing.Point(460, 171);
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.Size = new System.Drawing.Size(92, 20);
            this.txtPrecioCompra.TabIndex = 10;
            this.txtPrecioCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioCompra_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(555, 156);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Precio Venta:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(457, 155);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Precio Compra:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(459, 241);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(191, 23);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Añadir a Compra";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(457, 198);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 999;
            this.label9.Text = "Cantidad:";
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(460, 130);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.ReadOnly = true;
            this.txtNombreProducto.Size = new System.Drawing.Size(190, 20);
            this.txtNombreProducto.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(457, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 999;
            this.label8.Text = "Nombre:";
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnBuscarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarProducto.ForeColor = System.Drawing.Color.White;
            this.btnBuscarProducto.Location = new System.Drawing.Point(558, 195);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(92, 40);
            this.btnBuscarProducto.TabIndex = 8;
            this.btnBuscarProducto.Text = "Buscar";
            this.btnBuscarProducto.UseVisualStyleBackColor = false;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // txtCodigoProducto
            // 
            this.txtCodigoProducto.Location = new System.Drawing.Point(459, 87);
            this.txtCodigoProducto.Name = "txtCodigoProducto";
            this.txtCodigoProducto.ReadOnly = true;
            this.txtCodigoProducto.Size = new System.Drawing.Size(191, 20);
            this.txtCodigoProducto.TabIndex = 6;
            // 
            // txtRazonSocialProveedor
            // 
            this.txtRazonSocialProveedor.Location = new System.Drawing.Point(99, 163);
            this.txtRazonSocialProveedor.Name = "txtRazonSocialProveedor";
            this.txtRazonSocialProveedor.ReadOnly = true;
            this.txtRazonSocialProveedor.Size = new System.Drawing.Size(108, 20);
            this.txtRazonSocialProveedor.TabIndex = 1;
            // 
            // txtRucProveedor
            // 
            this.txtRucProveedor.Location = new System.Drawing.Point(60, 137);
            this.txtRucProveedor.Name = "txtRucProveedor";
            this.txtRucProveedor.ReadOnly = true;
            this.txtRucProveedor.Size = new System.Drawing.Size(147, 20);
            this.txtRucProveedor.TabIndex = 0;
            // 
            // btnBuscarProveedor
            // 
            this.btnBuscarProveedor.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnBuscarProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarProveedor.ForeColor = System.Drawing.Color.White;
            this.btnBuscarProveedor.Location = new System.Drawing.Point(23, 189);
            this.btnBuscarProveedor.Name = "btnBuscarProveedor";
            this.btnBuscarProveedor.Size = new System.Drawing.Size(184, 23);
            this.btnBuscarProveedor.TabIndex = 2;
            this.btnBuscarProveedor.Text = "Buscar";
            this.btnBuscarProveedor.UseVisualStyleBackColor = false;
            this.btnBuscarProveedor.Click += new System.EventHandler(this.btnBuscarProveedor_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 999;
            this.label6.Text = "Razón Social:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 999;
            this.label5.Text = "RUC:";
            // 
            // dgvDetalleCompra
            // 
            this.dgvDetalleCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvDetalleCompra.Location = new System.Drawing.Point(12, 285);
            this.dgvDetalleCompra.Name = "dgvDetalleCompra";
            this.dgvDetalleCompra.Size = new System.Drawing.Size(639, 150);
            this.dgvDetalleCompra.TabIndex = 10;
            this.dgvDetalleCompra.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalleCompra_CellContentClick);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Red;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(12, 441);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(318, 43);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGuardarCompra
            // 
            this.btnGuardarCompra.BackColor = System.Drawing.Color.ForestGreen;
            this.btnGuardarCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardarCompra.ForeColor = System.Drawing.Color.White;
            this.btnGuardarCompra.Location = new System.Drawing.Point(336, 441);
            this.btnGuardarCompra.Name = "btnGuardarCompra";
            this.btnGuardarCompra.Size = new System.Drawing.Size(314, 43);
            this.btnGuardarCompra.TabIndex = 13;
            this.btnGuardarCompra.Text = "Guardar Compra";
            this.btnGuardarCompra.UseVisualStyleBackColor = false;
            this.btnGuardarCompra.Click += new System.EventHandler(this.btnGuardarCompra_Click);
            // 
            // txtIdTienda
            // 
            this.txtIdTienda.Location = new System.Drawing.Point(291, 104);
            this.txtIdTienda.Name = "txtIdTienda";
            this.txtIdTienda.Size = new System.Drawing.Size(15, 20);
            this.txtIdTienda.TabIndex = 999;
            this.txtIdTienda.Text = "0";
            this.txtIdTienda.Visible = false;
            // 
            // txtIdProveedor
            // 
            this.txtIdProveedor.Location = new System.Drawing.Point(76, 108);
            this.txtIdProveedor.Name = "txtIdProveedor";
            this.txtIdProveedor.Size = new System.Drawing.Size(15, 20);
            this.txtIdProveedor.TabIndex = 999;
            this.txtIdProveedor.Text = "0";
            this.txtIdProveedor.Visible = false;
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.Location = new System.Drawing.Point(517, 52);
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.Size = new System.Drawing.Size(17, 20);
            this.txtIdProducto.TabIndex = 999;
            this.txtIdProducto.Text = "0";
            this.txtIdProducto.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1000;
            this.label1.Text = "Proveedor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(301, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1001;
            this.label2.Text = "Sucursal:";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label12.Location = new System.Drawing.Point(230, 87);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(203, 147);
            this.label12.TabIndex = 1002;
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label13.Location = new System.Drawing.Point(9, 87);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(221, 147);
            this.label13.TabIndex = 1003;
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(529, 55);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 13);
            this.label14.TabIndex = 1004;
            this.label14.Text = "Producto:";
            // 
            // frmRegistrarCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 558);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPrecioVenta);
            this.Controls.Add(this.txtNombreTienda);
            this.Controls.Add(this.txtPrecioCompra);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtRazonSocialProveedor);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnBuscarTienda);
            this.Controls.Add(this.txtRucTienda);
            this.Controls.Add(this.txtNombreProducto);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtIdProducto);
            this.Controls.Add(this.btnBuscarProducto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRucProveedor);
            this.Controls.Add(this.txtCodigoProducto);
            this.Controls.Add(this.txtIdProveedor);
            this.Controls.Add(this.btnBuscarProveedor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtIdTienda);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnGuardarCompra);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvDetalleCompra);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmRegistrarCompra";
            this.Text = "Registrar Compra";
            this.Load += new System.EventHandler(this.frmRegistrarCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleCompra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRazonSocialProveedor;
        private System.Windows.Forms.TextBox txtRucProveedor;
        private System.Windows.Forms.Button btnBuscarProveedor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombreTienda;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnBuscarTienda;
        private System.Windows.Forms.TextBox txtRucTienda;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.TextBox txtCodigoProducto;
        private System.Windows.Forms.DataGridView dgvDetalleCompra;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.TextBox txtPrecioCompra;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGuardarCompra;
        private System.Windows.Forms.TextBox txtIdTienda;
        private System.Windows.Forms.TextBox txtIdProveedor;
        private System.Windows.Forms.TextBox txtIdProducto;
        private System.Windows.Forms.NumericUpDown txtCantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}