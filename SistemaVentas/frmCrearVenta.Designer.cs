namespace SistemaVentas
{
    partial class frmCrearVenta
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
            this.cboTipoDocumentoVenta = new System.Windows.Forms.ComboBox();
            this.txtFechaVenta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblNroDocumento = new System.Windows.Forms.Label();
            this.lblRuc = new System.Windows.Forms.Label();
            this.txtEmpleadoCorreo = new System.Windows.Forms.TextBox();
            this.txtEmpleadoApellidos = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEmpleadoNombre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.NumericUpDown();
            this.Label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtPrecioUnidad = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtProductoDescripcion = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtProductoNombre = new System.Windows.Forms.TextBox();
            this.txtProductoCodigo = new System.Windows.Forms.TextBox();
            this.dgvVenta = new System.Windows.Forms.DataGridView();
            this.txtDireccionCliente = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txtTelefonoCliente = new System.Windows.Forms.TextBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtDocumentoCliente = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.cboTipoDocumentoCliente = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.btnImprimirTerminar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblIGV = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.txtMontoPago = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label27 = new System.Windows.Forms.Label();
            this.txtCambio = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.lblTotalProductos = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTiendaNombre = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTiendaRuc = new System.Windows.Forms.TextBox();
            this.txtTiendaDireccion = new System.Windows.Forms.TextBox();
            this.txtIdProducto = new System.Windows.Forms.TextBox();
            this.txtIdEmpleado = new System.Windows.Forms.TextBox();
            this.txtIdTienda = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // cboTipoDocumentoVenta
            // 
            this.cboTipoDocumentoVenta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboTipoDocumentoVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboTipoDocumentoVenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoDocumentoVenta.FormattingEnabled = true;
            this.cboTipoDocumentoVenta.Location = new System.Drawing.Point(414, 30);
            this.cboTipoDocumentoVenta.Name = "cboTipoDocumentoVenta";
            this.cboTipoDocumentoVenta.Size = new System.Drawing.Size(112, 21);
            this.cboTipoDocumentoVenta.TabIndex = 1;
            // 
            // txtFechaVenta
            // 
            this.txtFechaVenta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFechaVenta.Location = new System.Drawing.Point(572, 7);
            this.txtFechaVenta.Name = "txtFechaVenta";
            this.txtFechaVenta.ReadOnly = true;
            this.txtFechaVenta.Size = new System.Drawing.Size(141, 20);
            this.txtFechaVenta.TabIndex = 2;
            this.txtFechaVenta.TextChanged += new System.EventHandler(this.txtFechaVenta_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(333, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Documento:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(135, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(202, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "RUC:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNroDocumento
            // 
            this.lblNroDocumento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNroDocumento.AutoSize = true;
            this.lblNroDocumento.BackColor = System.Drawing.Color.White;
            this.lblNroDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroDocumento.ForeColor = System.Drawing.Color.Red;
            this.lblNroDocumento.Location = new System.Drawing.Point(592, 9);
            this.lblNroDocumento.Name = "lblNroDocumento";
            this.lblNroDocumento.Size = new System.Drawing.Size(0, 13);
            this.lblNroDocumento.TabIndex = 7;
            // 
            // lblRuc
            // 
            this.lblRuc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRuc.AutoSize = true;
            this.lblRuc.BackColor = System.Drawing.Color.White;
            this.lblRuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRuc.Location = new System.Drawing.Point(195, 9);
            this.lblRuc.Name = "lblRuc";
            this.lblRuc.Size = new System.Drawing.Size(14, 13);
            this.lblRuc.TabIndex = 9;
            this.lblRuc.Text = "0";
            this.lblRuc.Click += new System.EventHandler(this.lblRuc_Click);
            // 
            // txtEmpleadoCorreo
            // 
            this.txtEmpleadoCorreo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmpleadoCorreo.Location = new System.Drawing.Point(12, 279);
            this.txtEmpleadoCorreo.Name = "txtEmpleadoCorreo";
            this.txtEmpleadoCorreo.ReadOnly = true;
            this.txtEmpleadoCorreo.Size = new System.Drawing.Size(137, 20);
            this.txtEmpleadoCorreo.TabIndex = 8;
            // 
            // txtEmpleadoApellidos
            // 
            this.txtEmpleadoApellidos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmpleadoApellidos.Location = new System.Drawing.Point(12, 239);
            this.txtEmpleadoApellidos.Name = "txtEmpleadoApellidos";
            this.txtEmpleadoApellidos.ReadOnly = true;
            this.txtEmpleadoApellidos.Size = new System.Drawing.Size(137, 20);
            this.txtEmpleadoApellidos.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Correo";
            // 
            // txtEmpleadoNombre
            // 
            this.txtEmpleadoNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmpleadoNombre.Location = new System.Drawing.Point(12, 198);
            this.txtEmpleadoNombre.Name = "txtEmpleadoNombre";
            this.txtEmpleadoNombre.ReadOnly = true;
            this.txtEmpleadoNombre.Size = new System.Drawing.Size(137, 20);
            this.txtEmpleadoNombre.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Apellidos";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Nombre";
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregarProducto.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregarProducto.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAgregarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarProducto.ForeColor = System.Drawing.Color.White;
            this.btnAgregarProducto.Location = new System.Drawing.Point(595, 305);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(157, 23);
            this.btnAgregarProducto.TabIndex = 20;
            this.btnAgregarProducto.Text = "Agregar";
            this.btnAgregarProducto.UseVisualStyleBackColor = false;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCantidad.Location = new System.Drawing.Point(572, 221);
            this.txtCantidad.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.txtCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.ReadOnly = true;
            this.txtCantidad.Size = new System.Drawing.Size(80, 20);
            this.txtCantidad.TabIndex = 19;
            this.txtCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Label12
            // 
            this.Label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label12.AutoSize = true;
            this.Label12.Location = new System.Drawing.Point(513, 228);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(52, 13);
            this.Label12.TabIndex = 10;
            this.Label12.Text = "Cantidad:";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(488, 183);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "Precio Unidad:";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(527, 164);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 13);
            this.label14.TabIndex = 8;
            this.label14.Text = "Stock:";
            // 
            // txtPrecioUnidad
            // 
            this.txtPrecioUnidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrecioUnidad.Location = new System.Drawing.Point(572, 183);
            this.txtPrecioUnidad.Name = "txtPrecioUnidad";
            this.txtPrecioUnidad.ReadOnly = true;
            this.txtPrecioUnidad.Size = new System.Drawing.Size(99, 20);
            this.txtPrecioUnidad.TabIndex = 18;
            // 
            // txtStock
            // 
            this.txtStock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtStock.Location = new System.Drawing.Point(573, 157);
            this.txtStock.Name = "txtStock";
            this.txtStock.ReadOnly = true;
            this.txtStock.Size = new System.Drawing.Size(90, 20);
            this.txtStock.TabIndex = 16;
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscarProducto.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnBuscarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarProducto.ForeColor = System.Drawing.Color.White;
            this.btnBuscarProducto.Location = new System.Drawing.Point(512, 305);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(53, 23);
            this.btnBuscarProducto.TabIndex = 4;
            this.btnBuscarProducto.Text = "Buscar";
            this.btnBuscarProducto.UseVisualStyleBackColor = false;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(502, 133);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(63, 13);
            this.label17.TabIndex = 3;
            this.label17.Text = "Descripción";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(521, 114);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 13);
            this.label15.TabIndex = 3;
            this.label15.Text = "Nombre";
            // 
            // txtProductoDescripcion
            // 
            this.txtProductoDescripcion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtProductoDescripcion.Location = new System.Drawing.Point(573, 131);
            this.txtProductoDescripcion.Name = "txtProductoDescripcion";
            this.txtProductoDescripcion.ReadOnly = true;
            this.txtProductoDescripcion.Size = new System.Drawing.Size(150, 20);
            this.txtProductoDescripcion.TabIndex = 16;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(525, 82);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(40, 13);
            this.label16.TabIndex = 2;
            this.label16.Text = "Codigo";
            // 
            // txtProductoNombre
            // 
            this.txtProductoNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtProductoNombre.Location = new System.Drawing.Point(573, 105);
            this.txtProductoNombre.Name = "txtProductoNombre";
            this.txtProductoNombre.ReadOnly = true;
            this.txtProductoNombre.Size = new System.Drawing.Size(150, 20);
            this.txtProductoNombre.TabIndex = 15;
            // 
            // txtProductoCodigo
            // 
            this.txtProductoCodigo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtProductoCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProductoCodigo.Location = new System.Drawing.Point(573, 80);
            this.txtProductoCodigo.Name = "txtProductoCodigo";
            this.txtProductoCodigo.Size = new System.Drawing.Size(90, 20);
            this.txtProductoCodigo.TabIndex = 14;
            this.txtProductoCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProductoCodigo_KeyDown);
            // 
            // dgvVenta
            // 
            this.dgvVenta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvVenta.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.dgvVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVenta.Location = new System.Drawing.Point(12, 413);
            this.dgvVenta.Name = "dgvVenta";
            this.dgvVenta.Size = new System.Drawing.Size(960, 150);
            this.dgvVenta.TabIndex = 13;
            this.dgvVenta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVenta_CellContentClick);
            // 
            // txtDireccionCliente
            // 
            this.txtDireccionCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDireccionCliente.Location = new System.Drawing.Point(179, 258);
            this.txtDireccionCliente.Name = "txtDireccionCliente";
            this.txtDireccionCliente.Size = new System.Drawing.Size(141, 20);
            this.txtDireccionCliente.TabIndex = 12;
            // 
            // label22
            // 
            this.label22.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(176, 197);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(49, 13);
            this.label22.TabIndex = 4;
            this.label22.Text = "Telefono";
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(176, 241);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(52, 13);
            this.label21.TabIndex = 4;
            this.label21.Text = "Dirección";
            // 
            // txtTelefonoCliente
            // 
            this.txtTelefonoCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTelefonoCliente.Location = new System.Drawing.Point(179, 214);
            this.txtTelefonoCliente.Name = "txtTelefonoCliente";
            this.txtTelefonoCliente.Size = new System.Drawing.Size(141, 20);
            this.txtTelefonoCliente.TabIndex = 13;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNombreCliente.Location = new System.Drawing.Point(179, 171);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(141, 20);
            this.txtNombreCliente.TabIndex = 11;
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(176, 155);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(44, 13);
            this.label20.TabIndex = 2;
            this.label20.Text = "Nombre";
            // 
            // txtDocumentoCliente
            // 
            this.txtDocumentoCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDocumentoCliente.Location = new System.Drawing.Point(180, 130);
            this.txtDocumentoCliente.Name = "txtDocumentoCliente";
            this.txtDocumentoCliente.Size = new System.Drawing.Size(141, 20);
            this.txtDocumentoCliente.TabIndex = 10;
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(177, 114);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(102, 13);
            this.label19.TabIndex = 2;
            this.label19.Text = "Numero Documento";
            // 
            // cboTipoDocumentoCliente
            // 
            this.cboTipoDocumentoCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboTipoDocumentoCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboTipoDocumentoCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoDocumentoCliente.FormattingEnabled = true;
            this.cboTipoDocumentoCliente.Location = new System.Drawing.Point(180, 89);
            this.cboTipoDocumentoCliente.Name = "cboTipoDocumentoCliente";
            this.cboTipoDocumentoCliente.Size = new System.Drawing.Size(141, 21);
            this.cboTipoDocumentoCliente.TabIndex = 9;
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(177, 73);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(86, 13);
            this.label18.TabIndex = 0;
            this.label18.Text = "Tipo Documento";
            // 
            // btnImprimirTerminar
            // 
            this.btnImprimirTerminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnImprimirTerminar.BackColor = System.Drawing.Color.Orange;
            this.btnImprimirTerminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimirTerminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImprimirTerminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimirTerminar.ForeColor = System.Drawing.Color.Black;
            this.btnImprimirTerminar.Location = new System.Drawing.Point(875, 569);
            this.btnImprimirTerminar.Name = "btnImprimirTerminar";
            this.btnImprimirTerminar.Size = new System.Drawing.Size(97, 33);
            this.btnImprimirTerminar.TabIndex = 24;
            this.btnImprimirTerminar.Text = "Imprimir";
            this.btnImprimirTerminar.UseVisualStyleBackColor = false;
            this.btnImprimirTerminar.Click += new System.EventHandler(this.btnImprimirTerminar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalir.BackColor = System.Drawing.Color.Red;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Black;
            this.btnSalir.Location = new System.Drawing.Point(911, 9);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(79, 23);
            this.btnSalir.TabIndex = 25;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label23
            // 
            this.label23.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(9, 578);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(95, 13);
            this.label23.TabIndex = 17;
            this.label23.Text = "SubTotal : C$/.";
            // 
            // label24
            // 
            this.label24.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(168, 578);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(60, 13);
            this.label24.TabIndex = 17;
            this.label24.Text = "IVA: C$/.";
            // 
            // label25
            // 
            this.label25.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(279, 578);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(73, 13);
            this.label25.TabIndex = 17;
            this.label25.Text = "Total : C$/.";
            this.label25.Click += new System.EventHandler(this.label25_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(347, 578);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(14, 13);
            this.lblTotal.TabIndex = 18;
            this.lblTotal.Text = "0";
            // 
            // lblIGV
            // 
            this.lblIGV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblIGV.AutoSize = true;
            this.lblIGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIGV.Location = new System.Drawing.Point(223, 578);
            this.lblIGV.Name = "lblIGV";
            this.lblIGV.Size = new System.Drawing.Size(14, 13);
            this.lblIGV.TabIndex = 18;
            this.lblIGV.Text = "0";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.Location = new System.Drawing.Point(101, 578);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(14, 13);
            this.lblSubTotal.TabIndex = 18;
            this.lblSubTotal.Text = "0";
            // 
            // label26
            // 
            this.label26.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(373, 580);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(79, 13);
            this.label26.TabIndex = 19;
            this.label26.Text = "Monto Pago:";
            // 
            // txtMontoPago
            // 
            this.txtMontoPago.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMontoPago.Location = new System.Drawing.Point(451, 577);
            this.txtMontoPago.Name = "txtMontoPago";
            this.txtMontoPago.Size = new System.Drawing.Size(100, 20);
            this.txtMontoPago.TabIndex = 21;
            this.txtMontoPago.Text = "0";
            this.txtMontoPago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMontoPago_KeyPress);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcular.Location = new System.Drawing.Point(557, 575);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 22;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label27
            // 
            this.label27.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(642, 578);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(52, 13);
            this.label27.TabIndex = 22;
            this.label27.Text = "Cambio:";
            // 
            // txtCambio
            // 
            this.txtCambio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCambio.Location = new System.Drawing.Point(697, 575);
            this.txtCambio.Name = "txtCambio";
            this.txtCambio.ReadOnly = true;
            this.txtCambio.Size = new System.Drawing.Size(100, 20);
            this.txtCambio.TabIndex = 23;
            this.txtCambio.Text = "0";
            // 
            // label28
            // 
            this.label28.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(770, 310);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(62, 13);
            this.label28.TabIndex = 24;
            this.label28.Text = "Total Items:";
            // 
            // lblTotalProductos
            // 
            this.lblTotalProductos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotalProductos.AutoSize = true;
            this.lblTotalProductos.Location = new System.Drawing.Point(838, 310);
            this.lblTotalProductos.Name = "lblTotalProductos";
            this.lblTotalProductos.Size = new System.Drawing.Size(13, 13);
            this.lblTotalProductos.TabIndex = 25;
            this.lblTotalProductos.Text = "0";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Nombre";
            // 
            // txtTiendaNombre
            // 
            this.txtTiendaNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTiendaNombre.Location = new System.Drawing.Point(18, 90);
            this.txtTiendaNombre.Name = "txtTiendaNombre";
            this.txtTiendaNombre.ReadOnly = true;
            this.txtTiendaNombre.Size = new System.Drawing.Size(133, 20);
            this.txtTiendaNombre.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Direccion";
            // 
            // txtTiendaRuc
            // 
            this.txtTiendaRuc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTiendaRuc.Location = new System.Drawing.Point(180, 6);
            this.txtTiendaRuc.Name = "txtTiendaRuc";
            this.txtTiendaRuc.ReadOnly = true;
            this.txtTiendaRuc.Size = new System.Drawing.Size(134, 20);
            this.txtTiendaRuc.TabIndex = 4;
            // 
            // txtTiendaDireccion
            // 
            this.txtTiendaDireccion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTiendaDireccion.Location = new System.Drawing.Point(19, 128);
            this.txtTiendaDireccion.Name = "txtTiendaDireccion";
            this.txtTiendaDireccion.ReadOnly = true;
            this.txtTiendaDireccion.Size = new System.Drawing.Size(133, 20);
            this.txtTiendaDireccion.TabIndex = 5;
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIdProducto.Location = new System.Drawing.Point(616, 54);
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.Size = new System.Drawing.Size(20, 20);
            this.txtIdProducto.TabIndex = 12;
            this.txtIdProducto.Text = "0";
            this.txtIdProducto.Visible = false;
            // 
            // txtIdEmpleado
            // 
            this.txtIdEmpleado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIdEmpleado.Location = new System.Drawing.Point(44, 156);
            this.txtIdEmpleado.Name = "txtIdEmpleado";
            this.txtIdEmpleado.Size = new System.Drawing.Size(20, 20);
            this.txtIdEmpleado.TabIndex = 12;
            this.txtIdEmpleado.Text = "0";
            this.txtIdEmpleado.Visible = false;
            // 
            // txtIdTienda
            // 
            this.txtIdTienda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIdTienda.Location = new System.Drawing.Point(44, 42);
            this.txtIdTienda.Name = "txtIdTienda";
            this.txtIdTienda.Size = new System.Drawing.Size(20, 20);
            this.txtIdTienda.TabIndex = 12;
            this.txtIdTienda.Text = "0";
            this.txtIdTienda.Visible = false;
            // 
            // label29
            // 
            this.label29.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(61, 45);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(40, 13);
            this.label29.TabIndex = 26;
            this.label29.Text = "Tienda";
            this.label29.Click += new System.EventHandler(this.label29_Click);
            // 
            // label30
            // 
            this.label30.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(224, 47);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(39, 13);
            this.label30.TabIndex = 27;
            this.label30.Text = "Cliente";
            // 
            // label31
            // 
            this.label31.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(61, 160);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(54, 13);
            this.label31.TabIndex = 28;
            this.label31.Text = "Empleado";
            // 
            // label32
            // 
            this.label32.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(613, 38);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(50, 13);
            this.label32.TabIndex = 29;
            this.label32.Text = "Producto";
            // 
            // label33
            // 
            this.label33.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label33.BackColor = System.Drawing.Color.White;
            this.label33.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label33.Location = new System.Drawing.Point(530, 4);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(202, 23);
            this.label33.TabIndex = 30;
            this.label33.Text = "Fecha:";
            this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmCrearVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(999, 636);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.btnAgregarProducto);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtEmpleadoCorreo);
            this.Controls.Add(this.Label12);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtEmpleadoApellidos);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPrecioUnidad);
            this.Controls.Add(this.txtDireccionCliente);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.txtEmpleadoNombre);
            this.Controls.Add(this.btnBuscarProducto);
            this.Controls.Add(this.txtTiendaDireccion);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtProductoDescripcion);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtProductoNombre);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.txtProductoCodigo);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.txtTiendaRuc);
            this.Controls.Add(this.txtTelefonoCliente);
            this.Controls.Add(this.lblTotalProductos);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.txtDocumentoCliente);
            this.Controls.Add(this.txtTiendaNombre);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.cboTipoDocumentoCliente);
            this.Controls.Add(this.txtCambio);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtMontoPago);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.lblIGV);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.btnImprimirTerminar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtIdProducto);
            this.Controls.Add(this.dgvVenta);
            this.Controls.Add(this.txtIdEmpleado);
            this.Controls.Add(this.txtIdTienda);
            this.Controls.Add(this.lblRuc);
            this.Controls.Add(this.lblNroDocumento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtFechaVenta);
            this.Controls.Add(this.cboTipoDocumentoVenta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCrearVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear Venta";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCrearVenta_FormClosed);
            this.Load += new System.EventHandler(this.frmCrearVenta_Load);
            this.Shown += new System.EventHandler(this.frmCrearVenta_Shown_1);
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cboTipoDocumentoVenta;
        private System.Windows.Forms.TextBox txtFechaVenta;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Label lblNroDocumento;
        private System.Windows.Forms.Label lblRuc;
        private System.Windows.Forms.TextBox txtEmpleadoNombre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmpleadoApellidos;
        private System.Windows.Forms.TextBox txtEmpleadoCorreo;
        private System.Windows.Forms.Label label8;
        internal System.Windows.Forms.Button btnAgregarProducto;
        internal System.Windows.Forms.NumericUpDown txtCantidad;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.Label label13;
        internal System.Windows.Forms.Label label14;
        internal System.Windows.Forms.TextBox txtPrecioUnidad;
        internal System.Windows.Forms.TextBox txtStock;
        internal System.Windows.Forms.Button btnBuscarProducto;
        internal System.Windows.Forms.Label label17;
        internal System.Windows.Forms.Label label15;
        internal System.Windows.Forms.TextBox txtProductoDescripcion;
        internal System.Windows.Forms.Label label16;
        internal System.Windows.Forms.TextBox txtProductoNombre;
        internal System.Windows.Forms.TextBox txtProductoCodigo;
        private System.Windows.Forms.DataGridView dgvVenta;
        private System.Windows.Forms.ComboBox cboTipoDocumentoCliente;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtDireccionCliente;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtTelefonoCliente;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtDocumentoCliente;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnImprimirTerminar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblIGV;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtMontoPago;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtCambio;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label lblTotalProductos;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTiendaNombre;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTiendaRuc;
        private System.Windows.Forms.TextBox txtTiendaDireccion;
        private System.Windows.Forms.TextBox txtIdProducto;
        private System.Windows.Forms.TextBox txtIdEmpleado;
        private System.Windows.Forms.TextBox txtIdTienda;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        internal System.Windows.Forms.Label label33;
    }
}