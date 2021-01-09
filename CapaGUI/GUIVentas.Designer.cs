namespace CapaGUI
{
    partial class GUIVentas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIdProducto = new System.Windows.Forms.TextBox();
            this.txtPrecioP = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtRutCliente = new System.Windows.Forms.TextBox();
            this.txtPagarxProducto = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panaderiaDataSetProducto = new CapaGUI.panaderiaDataSetProducto();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productoTableAdapter = new CapaGUI.panaderiaDataSetProductoTableAdapters.productoTableAdapter();
            this.panaderiaDataSetProductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tipoproductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idproductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panaderiaDataSetProductoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnMostrarL = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idventaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idproductoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rutclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diferenciadorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panaderiaDataSetVenta = new CapaGUI.panaderiaDataSetVenta();
            this.ventaTableAdapter = new CapaGUI.panaderiaDataSetVentaTableAdapters.ventaTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotalApagar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPagaCon = new System.Windows.Forms.TextBox();
            this.txtVuelto = new System.Windows.Forms.TextBox();
            this.btnCalcularTotalAP = new System.Windows.Forms.Button();
            this.btnBuscaCliente = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.irAMantenedorDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.irAMantenedorDeProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.irAAdministracionDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.irAAdminnistracionDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.irANuevaVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.irAMenuPrincipalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirAltF4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.panaderiaDataSetProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panaderiaDataSetProductoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panaderiaDataSetProductoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panaderiaDataSetVenta)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id del Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(534, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rut del Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cantidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(516, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total por producto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Precio Producto";
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.Location = new System.Drawing.Point(179, 70);
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.Size = new System.Drawing.Size(100, 20);
            this.txtIdProducto.TabIndex = 5;
            // 
            // txtPrecioP
            // 
            this.txtPrecioP.Location = new System.Drawing.Point(176, 153);
            this.txtPrecioP.Name = "txtPrecioP";
            this.txtPrecioP.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioP.TabIndex = 6;
            this.txtPrecioP.TextChanged += new System.EventHandler(this.txtPrecioP_TextChanged);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(176, 213);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 7;
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            // 
            // txtRutCliente
            // 
            this.txtRutCliente.Location = new System.Drawing.Point(627, 106);
            this.txtRutCliente.Name = "txtRutCliente";
            this.txtRutCliente.Size = new System.Drawing.Size(100, 20);
            this.txtRutCliente.TabIndex = 8;
            // 
            // txtPagarxProducto
            // 
            this.txtPagarxProducto.Location = new System.Drawing.Point(627, 210);
            this.txtPagarxProducto.Name = "txtPagarxProducto";
            this.txtPagarxProducto.Size = new System.Drawing.Size(100, 20);
            this.txtPagarxProducto.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 51);
            this.button1.TabIndex = 10;
            this.button1.Text = "Agregar otro producto a la venta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(493, 511);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 39);
            this.button2.TabIndex = 11;
            this.button2.Text = "Finalizar Venta";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(316, 213);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "Validar Stock ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panaderiaDataSetProducto
            // 
            this.panaderiaDataSetProducto.DataSetName = "panaderiaDataSetProducto";
            this.panaderiaDataSetProducto.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataMember = "producto";
            this.productoBindingSource.DataSource = this.panaderiaDataSetProducto;
            // 
            // productoTableAdapter
            // 
            this.productoTableAdapter.ClearBeforeFill = true;
            // 
            // panaderiaDataSetProductoBindingSource
            // 
            this.panaderiaDataSetProductoBindingSource.DataSource = this.panaderiaDataSetProducto;
            this.panaderiaDataSetProductoBindingSource.Position = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tipoproductoDataGridViewTextBoxColumn,
            this.idproductoDataGridViewTextBoxColumn,
            this.precio_unitario});
            this.dataGridView1.DataSource = this.productoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(285, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(243, 150);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // tipoproductoDataGridViewTextBoxColumn
            // 
            this.tipoproductoDataGridViewTextBoxColumn.DataPropertyName = "tipo_producto";
            this.tipoproductoDataGridViewTextBoxColumn.HeaderText = "tipo_producto";
            this.tipoproductoDataGridViewTextBoxColumn.Name = "tipoproductoDataGridViewTextBoxColumn";
            this.tipoproductoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idproductoDataGridViewTextBoxColumn
            // 
            this.idproductoDataGridViewTextBoxColumn.DataPropertyName = "idproducto";
            this.idproductoDataGridViewTextBoxColumn.HeaderText = "idproducto";
            this.idproductoDataGridViewTextBoxColumn.Name = "idproductoDataGridViewTextBoxColumn";
            this.idproductoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precio_unitario
            // 
            this.precio_unitario.DataPropertyName = "precio_unitario";
            this.precio_unitario.HeaderText = "precio_unitario";
            this.precio_unitario.Name = "precio_unitario";
            this.precio_unitario.ReadOnly = true;
            // 
            // panaderiaDataSetProductoBindingSource1
            // 
            this.panaderiaDataSetProductoBindingSource1.DataSource = this.panaderiaDataSetProducto;
            this.panaderiaDataSetProductoBindingSource1.Position = 0;
            // 
            // btnMostrarL
            // 
            this.btnMostrarL.Location = new System.Drawing.Point(203, 96);
            this.btnMostrarL.Name = "btnMostrarL";
            this.btnMostrarL.Size = new System.Drawing.Size(76, 46);
            this.btnMostrarL.TabIndex = 14;
            this.btnMostrarL.Text = "Mostrar Lista Productos";
            this.btnMostrarL.UseVisualStyleBackColor = true;
            this.btnMostrarL.Click += new System.EventHandler(this.btnMostrarL_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idventaDataGridViewTextBoxColumn,
            this.idproductoDataGridViewTextBoxColumn1,
            this.rutclienteDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.diferenciadorDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.ventaBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(179, 265);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(432, 154);
            this.dataGridView2.TabIndex = 15;
            // 
            // idventaDataGridViewTextBoxColumn
            // 
            this.idventaDataGridViewTextBoxColumn.DataPropertyName = "idventa";
            this.idventaDataGridViewTextBoxColumn.HeaderText = "idventa";
            this.idventaDataGridViewTextBoxColumn.Name = "idventaDataGridViewTextBoxColumn";
            this.idventaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idproductoDataGridViewTextBoxColumn1
            // 
            this.idproductoDataGridViewTextBoxColumn1.DataPropertyName = "idproducto";
            this.idproductoDataGridViewTextBoxColumn1.HeaderText = "idproducto";
            this.idproductoDataGridViewTextBoxColumn1.Name = "idproductoDataGridViewTextBoxColumn1";
            this.idproductoDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // rutclienteDataGridViewTextBoxColumn
            // 
            this.rutclienteDataGridViewTextBoxColumn.DataPropertyName = "rutcliente";
            this.rutclienteDataGridViewTextBoxColumn.HeaderText = "rutcliente";
            this.rutclienteDataGridViewTextBoxColumn.Name = "rutclienteDataGridViewTextBoxColumn";
            this.rutclienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "cantidad";
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            this.cantidadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // diferenciadorDataGridViewTextBoxColumn
            // 
            this.diferenciadorDataGridViewTextBoxColumn.DataPropertyName = "diferenciador";
            this.diferenciadorDataGridViewTextBoxColumn.HeaderText = "diferenciador";
            this.diferenciadorDataGridViewTextBoxColumn.Name = "diferenciadorDataGridViewTextBoxColumn";
            this.diferenciadorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ventaBindingSource
            // 
            this.ventaBindingSource.DataMember = "venta";
            this.ventaBindingSource.DataSource = this.panaderiaDataSetVenta;
            // 
            // panaderiaDataSetVenta
            // 
            this.panaderiaDataSetVenta.DataSetName = "panaderiaDataSetVenta";
            this.panaderiaDataSetVenta.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ventaTableAdapter
            // 
            this.ventaTableAdapter.ClearBeforeFill = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(105, 463);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Total a Pagar";
            // 
            // txtTotalApagar
            // 
            this.txtTotalApagar.Location = new System.Drawing.Point(227, 463);
            this.txtTotalApagar.Name = "txtTotalApagar";
            this.txtTotalApagar.Size = new System.Drawing.Size(139, 20);
            this.txtTotalApagar.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(105, 499);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Paga Con :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(107, 533);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Vuelto";
            // 
            // txtPagaCon
            // 
            this.txtPagaCon.Location = new System.Drawing.Point(227, 499);
            this.txtPagaCon.Name = "txtPagaCon";
            this.txtPagaCon.Size = new System.Drawing.Size(139, 20);
            this.txtPagaCon.TabIndex = 22;
            this.txtPagaCon.TextChanged += new System.EventHandler(this.txtPagaCon_TextChanged);
            // 
            // txtVuelto
            // 
            this.txtVuelto.Location = new System.Drawing.Point(227, 530);
            this.txtVuelto.Name = "txtVuelto";
            this.txtVuelto.Size = new System.Drawing.Size(139, 20);
            this.txtVuelto.TabIndex = 23;
            // 
            // btnCalcularTotalAP
            // 
            this.btnCalcularTotalAP.Location = new System.Drawing.Point(408, 459);
            this.btnCalcularTotalAP.Name = "btnCalcularTotalAP";
            this.btnCalcularTotalAP.Size = new System.Drawing.Size(75, 34);
            this.btnCalcularTotalAP.TabIndex = 24;
            this.btnCalcularTotalAP.Text = "Calcular el total";
            this.btnCalcularTotalAP.UseVisualStyleBackColor = true;
            this.btnCalcularTotalAP.Click += new System.EventHandler(this.btnCalcularTotalAP_Click);
            // 
            // btnBuscaCliente
            // 
            this.btnBuscaCliente.Location = new System.Drawing.Point(627, 143);
            this.btnBuscaCliente.Name = "btnBuscaCliente";
            this.btnBuscaCliente.Size = new System.Drawing.Size(100, 23);
            this.btnBuscaCliente.TabIndex = 25;
            this.btnBuscaCliente.Text = "Busca Cliente";
            this.btnBuscaCliente.UseVisualStyleBackColor = true;
            this.btnBuscaCliente.Click += new System.EventHandler(this.btnBuscaCliente_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 26;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.irAMantenedorDeProductosToolStripMenuItem,
            this.irAMantenedorDeProveedoresToolStripMenuItem,
            this.irAAdministracionDeUsuariosToolStripMenuItem,
            this.irAAdminnistracionDeClientesToolStripMenuItem,
            this.irANuevaVentaToolStripMenuItem,
            this.irAMenuPrincipalToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // irAMantenedorDeProductosToolStripMenuItem
            // 
            this.irAMantenedorDeProductosToolStripMenuItem.Name = "irAMantenedorDeProductosToolStripMenuItem";
            this.irAMantenedorDeProductosToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.irAMantenedorDeProductosToolStripMenuItem.Text = "Ir a Mantenedor de Productos";
            this.irAMantenedorDeProductosToolStripMenuItem.Click += new System.EventHandler(this.irAMantenedorDeProductosToolStripMenuItem_Click);
            // 
            // irAMantenedorDeProveedoresToolStripMenuItem
            // 
            this.irAMantenedorDeProveedoresToolStripMenuItem.Name = "irAMantenedorDeProveedoresToolStripMenuItem";
            this.irAMantenedorDeProveedoresToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.irAMantenedorDeProveedoresToolStripMenuItem.Text = "Ir a Mantenedor de Proveedores";
            this.irAMantenedorDeProveedoresToolStripMenuItem.Click += new System.EventHandler(this.irAMantenedorDeProveedoresToolStripMenuItem_Click);
            // 
            // irAAdministracionDeUsuariosToolStripMenuItem
            // 
            this.irAAdministracionDeUsuariosToolStripMenuItem.Name = "irAAdministracionDeUsuariosToolStripMenuItem";
            this.irAAdministracionDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.irAAdministracionDeUsuariosToolStripMenuItem.Text = "Ir a Administracion de Usuarios";
            this.irAAdministracionDeUsuariosToolStripMenuItem.Click += new System.EventHandler(this.irAAdministracionDeUsuariosToolStripMenuItem_Click);
            // 
            // irAAdminnistracionDeClientesToolStripMenuItem
            // 
            this.irAAdminnistracionDeClientesToolStripMenuItem.Name = "irAAdminnistracionDeClientesToolStripMenuItem";
            this.irAAdminnistracionDeClientesToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.irAAdminnistracionDeClientesToolStripMenuItem.Text = "Ir a Administracion de Clientes";
            this.irAAdminnistracionDeClientesToolStripMenuItem.Click += new System.EventHandler(this.irAAdminnistracionDeClientesToolStripMenuItem_Click);
            // 
            // irANuevaVentaToolStripMenuItem
            // 
            this.irANuevaVentaToolStripMenuItem.Name = "irANuevaVentaToolStripMenuItem";
            this.irANuevaVentaToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.irANuevaVentaToolStripMenuItem.Text = "Ir a Nueva Venta";
            this.irANuevaVentaToolStripMenuItem.Click += new System.EventHandler(this.irANuevaVentaToolStripMenuItem_Click);
            // 
            // irAMenuPrincipalToolStripMenuItem
            // 
            this.irAMenuPrincipalToolStripMenuItem.Name = "irAMenuPrincipalToolStripMenuItem";
            this.irAMenuPrincipalToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.irAMenuPrincipalToolStripMenuItem.Text = "Ir a Menu Principal";
            this.irAMenuPrincipalToolStripMenuItem.Click += new System.EventHandler(this.irAMenuPrincipalToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirAltF4ToolStripMenuItem});
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // salirAltF4ToolStripMenuItem
            // 
            this.salirAltF4ToolStripMenuItem.Name = "salirAltF4ToolStripMenuItem";
            this.salirAltF4ToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.salirAltF4ToolStripMenuItem.Text = "Salir                     alt+F4";
            this.salirAltF4ToolStripMenuItem.Click += new System.EventHandler(this.salirAltF4ToolStripMenuItem_Click);
            // 
            // GUIVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 570);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnBuscaCliente);
            this.Controls.Add(this.btnCalcularTotalAP);
            this.Controls.Add(this.txtVuelto);
            this.Controls.Add(this.txtPagaCon);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTotalApagar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnMostrarL);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPagarxProducto);
            this.Controls.Add(this.txtRutCliente);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtPrecioP);
            this.Controls.Add(this.txtIdProducto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GUIVentas";
            this.Text = "Nueva venta";
            this.Load += new System.EventHandler(this.GUIVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panaderiaDataSetProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panaderiaDataSetProductoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panaderiaDataSetProductoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panaderiaDataSetVenta)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIdProducto;
        private System.Windows.Forms.TextBox txtPrecioP;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtRutCliente;
        private System.Windows.Forms.TextBox txtPagarxProducto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private panaderiaDataSetProducto panaderiaDataSetProducto;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private panaderiaDataSetProductoTableAdapters.productoTableAdapter productoTableAdapter;
        private System.Windows.Forms.BindingSource panaderiaDataSetProductoBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoproductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idproductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_unitario;
        private System.Windows.Forms.BindingSource panaderiaDataSetProductoBindingSource1;
        private System.Windows.Forms.Button btnMostrarL;
        private System.Windows.Forms.DataGridView dataGridView2;
        private panaderiaDataSetVenta panaderiaDataSetVenta;
        private System.Windows.Forms.BindingSource ventaBindingSource;
        private panaderiaDataSetVentaTableAdapters.ventaTableAdapter ventaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idventaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idproductoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rutclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diferenciadorDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTotalApagar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPagaCon;
        private System.Windows.Forms.TextBox txtVuelto;
        private System.Windows.Forms.Button btnCalcularTotalAP;
        private System.Windows.Forms.Button btnBuscaCliente;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem irAMantenedorDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem irAMantenedorDeProveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem irAAdministracionDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem irAAdminnistracionDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem irANuevaVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirAltF4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem irAMenuPrincipalToolStripMenuItem;
    }
}