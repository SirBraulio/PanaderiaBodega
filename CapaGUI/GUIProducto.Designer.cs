namespace CapaGUI
{
    partial class GUIProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUIProducto));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIDProducto = new System.Windows.Forms.TextBox();
            this.txtPrecioUni = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtDiasV = new System.Windows.Forms.TextBox();
            this.txtIdProv = new System.Windows.Forms.TextBox();
            this.txtTipoP = new System.Windows.Forms.TextBox();
            this.txtCaracteristica = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idproductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preciounitarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diasparavencimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idproveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoproductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caracteristicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panaderiaDataSetProducto = new CapaGUI.panaderiaDataSetProducto();
            this.productoTableAdapter = new CapaGUI.panaderiaDataSetProductoTableAdapters.productoTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idproveedorDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreprovDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panaderiaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panaderiaDataSet = new CapaGUI.panaderiaDataSet();
            this.proveedorTableAdapter = new CapaGUI.panaderiaDataSetTableAdapters.proveedorTableAdapter();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.brnModificar = new System.Windows.Forms.Button();
            this.btnMostrarL = new System.Windows.Forms.Button();
            this.btnOcultar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panaderiaDataSet1 = new CapaGUI.panaderiaDataSet();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panaderiaDataSetProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panaderiaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panaderiaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panaderiaDataSet1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Precio Unitario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cantidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Dias Vencimiento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(352, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tipo Producto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(352, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Id Proveedor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(352, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Caracteristica";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(352, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Marca";
            // 
            // txtIDProducto
            // 
            this.txtIDProducto.Location = new System.Drawing.Point(139, 37);
            this.txtIDProducto.Name = "txtIDProducto";
            this.txtIDProducto.Size = new System.Drawing.Size(171, 20);
            this.txtIDProducto.TabIndex = 8;
            this.toolTip1.SetToolTip(this.txtIDProducto, "Ingresa la ID del Producto\r\nej: 1212-b");
            // 
            // txtPrecioUni
            // 
            this.txtPrecioUni.Location = new System.Drawing.Point(139, 79);
            this.txtPrecioUni.Name = "txtPrecioUni";
            this.txtPrecioUni.Size = new System.Drawing.Size(171, 20);
            this.txtPrecioUni.TabIndex = 9;
            this.toolTip1.SetToolTip(this.txtPrecioUni, "Ingresa El precio unitario del Producto en pesos\r\nej: 230");
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(139, 128);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(171, 20);
            this.txtCantidad.TabIndex = 10;
            this.toolTip1.SetToolTip(this.txtCantidad, "Ingresa la Cantidad del Producto\r\nej: 23\r\n");
            // 
            // txtDiasV
            // 
            this.txtDiasV.Location = new System.Drawing.Point(139, 185);
            this.txtDiasV.Name = "txtDiasV";
            this.txtDiasV.Size = new System.Drawing.Size(171, 20);
            this.txtDiasV.TabIndex = 11;
            this.toolTip1.SetToolTip(this.txtDiasV, "Ingresa los dias para el Vencimiento del Producto\r\nej: 20\r\n");
            // 
            // txtIdProv
            // 
            this.txtIdProv.Location = new System.Drawing.Point(426, 34);
            this.txtIdProv.Name = "txtIdProv";
            this.txtIdProv.Size = new System.Drawing.Size(161, 20);
            this.txtIdProv.TabIndex = 12;
            this.toolTip1.SetToolTip(this.txtIdProv, "Ingresa o selecciona la ID del Proveedor\r\nej: 777\r\n");
            // 
            // txtTipoP
            // 
            this.txtTipoP.Location = new System.Drawing.Point(426, 79);
            this.txtTipoP.Name = "txtTipoP";
            this.txtTipoP.Size = new System.Drawing.Size(161, 20);
            this.txtTipoP.TabIndex = 13;
            this.toolTip1.SetToolTip(this.txtTipoP, "Ingresa el tipo del producto\r\nej: Perecible\r\n");
            // 
            // txtCaracteristica
            // 
            this.txtCaracteristica.Location = new System.Drawing.Point(426, 128);
            this.txtCaracteristica.Name = "txtCaracteristica";
            this.txtCaracteristica.Size = new System.Drawing.Size(161, 20);
            this.txtCaracteristica.TabIndex = 14;
            this.toolTip1.SetToolTip(this.txtCaracteristica, "Ingresa una caracteristica del producto\r\nej: Integral\r\n");
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(426, 189);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(161, 20);
            this.txtMarca.TabIndex = 15;
            this.toolTip1.SetToolTip(this.txtMarca, "Ingresa la marca del producto\r\nej: Carozzi\r\n");
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(48, 219);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(121, 23);
            this.btnAgregar.TabIndex = 16;
            this.btnAgregar.Text = "Agregar";
            this.toolTip1.SetToolTip(this.btnAgregar, "Agrega un NUEVO producto");
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idproductoDataGridViewTextBoxColumn,
            this.preciounitarioDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.diasparavencimientoDataGridViewTextBoxColumn,
            this.idproveedorDataGridViewTextBoxColumn,
            this.tipoproductoDataGridViewTextBoxColumn,
            this.caracteristicaDataGridViewTextBoxColumn,
            this.marcaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 259);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(822, 204);
            this.dataGridView1.TabIndex = 17;
            this.toolTip1.SetToolTip(this.dataGridView1, "Seleccione doble click en la id del producto que desea manejar.");
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // idproductoDataGridViewTextBoxColumn
            // 
            this.idproductoDataGridViewTextBoxColumn.DataPropertyName = "idproducto";
            this.idproductoDataGridViewTextBoxColumn.HeaderText = "idproducto";
            this.idproductoDataGridViewTextBoxColumn.Name = "idproductoDataGridViewTextBoxColumn";
            this.idproductoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // preciounitarioDataGridViewTextBoxColumn
            // 
            this.preciounitarioDataGridViewTextBoxColumn.DataPropertyName = "precio_unitario";
            this.preciounitarioDataGridViewTextBoxColumn.HeaderText = "precio_unitario";
            this.preciounitarioDataGridViewTextBoxColumn.Name = "preciounitarioDataGridViewTextBoxColumn";
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "cantidad";
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            // 
            // diasparavencimientoDataGridViewTextBoxColumn
            // 
            this.diasparavencimientoDataGridViewTextBoxColumn.DataPropertyName = "dias_paravencimiento";
            this.diasparavencimientoDataGridViewTextBoxColumn.HeaderText = "dias_paravencimiento";
            this.diasparavencimientoDataGridViewTextBoxColumn.Name = "diasparavencimientoDataGridViewTextBoxColumn";
            // 
            // idproveedorDataGridViewTextBoxColumn
            // 
            this.idproveedorDataGridViewTextBoxColumn.DataPropertyName = "idproveedor";
            this.idproveedorDataGridViewTextBoxColumn.HeaderText = "idproveedor";
            this.idproveedorDataGridViewTextBoxColumn.Name = "idproveedorDataGridViewTextBoxColumn";
            // 
            // tipoproductoDataGridViewTextBoxColumn
            // 
            this.tipoproductoDataGridViewTextBoxColumn.DataPropertyName = "tipo_producto";
            this.tipoproductoDataGridViewTextBoxColumn.HeaderText = "tipo_producto";
            this.tipoproductoDataGridViewTextBoxColumn.Name = "tipoproductoDataGridViewTextBoxColumn";
            // 
            // caracteristicaDataGridViewTextBoxColumn
            // 
            this.caracteristicaDataGridViewTextBoxColumn.DataPropertyName = "caracteristica";
            this.caracteristicaDataGridViewTextBoxColumn.HeaderText = "caracteristica";
            this.caracteristicaDataGridViewTextBoxColumn.Name = "caracteristicaDataGridViewTextBoxColumn";
            // 
            // marcaDataGridViewTextBoxColumn
            // 
            this.marcaDataGridViewTextBoxColumn.DataPropertyName = "marca";
            this.marcaDataGridViewTextBoxColumn.HeaderText = "marca";
            this.marcaDataGridViewTextBoxColumn.Name = "marcaDataGridViewTextBoxColumn";
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataMember = "producto";
            this.productoBindingSource.DataSource = this.panaderiaDataSetProducto;
            // 
            // panaderiaDataSetProducto
            // 
            this.panaderiaDataSetProducto.DataSetName = "panaderiaDataSetProducto";
            this.panaderiaDataSetProducto.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productoTableAdapter
            // 
            this.productoTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idproveedorDataGridViewTextBoxColumn1,
            this.nombreprovDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.proveedorBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(604, 34);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(240, 150);
            this.dataGridView2.TabIndex = 18;
            this.dataGridView2.Visible = false;
            this.dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellDoubleClick);
            // 
            // idproveedorDataGridViewTextBoxColumn1
            // 
            this.idproveedorDataGridViewTextBoxColumn1.DataPropertyName = "idproveedor";
            this.idproveedorDataGridViewTextBoxColumn1.HeaderText = "idproveedor";
            this.idproveedorDataGridViewTextBoxColumn1.Name = "idproveedorDataGridViewTextBoxColumn1";
            this.idproveedorDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idproveedorDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // nombreprovDataGridViewTextBoxColumn
            // 
            this.nombreprovDataGridViewTextBoxColumn.DataPropertyName = "nombre_prov";
            this.nombreprovDataGridViewTextBoxColumn.HeaderText = "nombre_prov";
            this.nombreprovDataGridViewTextBoxColumn.Name = "nombreprovDataGridViewTextBoxColumn";
            // 
            // proveedorBindingSource
            // 
            this.proveedorBindingSource.DataMember = "proveedor";
            this.proveedorBindingSource.DataSource = this.panaderiaDataSetBindingSource;
            // 
            // panaderiaDataSetBindingSource
            // 
            this.panaderiaDataSetBindingSource.DataSource = this.panaderiaDataSet;
            this.panaderiaDataSetBindingSource.Position = 0;
            // 
            // panaderiaDataSet
            // 
            this.panaderiaDataSet.DataSetName = "panaderiaDataSet";
            this.panaderiaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // proveedorTableAdapter
            // 
            this.proveedorTableAdapter.ClearBeforeFill = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(210, 219);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(119, 23);
            this.btnEliminar.TabIndex = 19;
            this.btnEliminar.Text = "Eliminar";
            this.toolTip1.SetToolTip(this.btnEliminar, "Elimina un producto existente");
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // brnModificar
            // 
            this.brnModificar.Location = new System.Drawing.Point(379, 219);
            this.brnModificar.Name = "brnModificar";
            this.brnModificar.Size = new System.Drawing.Size(119, 23);
            this.brnModificar.TabIndex = 20;
            this.brnModificar.Text = "Modificar";
            this.toolTip1.SetToolTip(this.brnModificar, "Modifica un elemento de un producto existente\r\n");
            this.brnModificar.UseVisualStyleBackColor = true;
            this.brnModificar.Click += new System.EventHandler(this.brnModificar_Click);
            // 
            // btnMostrarL
            // 
            this.btnMostrarL.Location = new System.Drawing.Point(604, 31);
            this.btnMostrarL.Name = "btnMostrarL";
            this.btnMostrarL.Size = new System.Drawing.Size(84, 23);
            this.btnMostrarL.TabIndex = 21;
            this.btnMostrarL.Text = "Mostrar Lista";
            this.btnMostrarL.UseVisualStyleBackColor = true;
            this.btnMostrarL.Click += new System.EventHandler(this.btnMostrarL_Click);
            // 
            // btnOcultar
            // 
            this.btnOcultar.Location = new System.Drawing.Point(769, 185);
            this.btnOcultar.Name = "btnOcultar";
            this.btnOcultar.Size = new System.Drawing.Size(75, 23);
            this.btnOcultar.TabIndex = 22;
            this.btnOcultar.Text = "Ocultar Lista";
            this.btnOcultar.UseVisualStyleBackColor = true;
            this.btnOcultar.Visible = false;
            this.btnOcultar.Click += new System.EventHandler(this.btnOcultar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(533, 219);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(119, 23);
            this.btnLimpiar.TabIndex = 23;
            this.btnLimpiar.Text = "Limpiar campos";
            this.toolTip1.SetToolTip(this.btnLimpiar, "Vacia los campos.");
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // panaderiaDataSet1
            // 
            this.panaderiaDataSet1.DataSetName = "panaderiaDataSet";
            this.panaderiaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(846, 24);
            this.menuStrip1.TabIndex = 27;
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
            // GUIProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 475);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnOcultar);
            this.Controls.Add(this.btnMostrarL);
            this.Controls.Add(this.brnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtCaracteristica);
            this.Controls.Add(this.txtTipoP);
            this.Controls.Add(this.txtIdProv);
            this.Controls.Add(this.txtDiasV);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtPrecioUni);
            this.Controls.Add(this.txtIDProducto);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GUIProducto";
            this.Text = "Administrador de Productos";
            this.Load += new System.EventHandler(this.GUIProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panaderiaDataSetProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panaderiaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panaderiaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panaderiaDataSet1)).EndInit();
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIDProducto;
        private System.Windows.Forms.TextBox txtPrecioUni;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtDiasV;
        private System.Windows.Forms.TextBox txtIdProv;
        private System.Windows.Forms.TextBox txtTipoP;
        private System.Windows.Forms.TextBox txtCaracteristica;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private panaderiaDataSetProducto panaderiaDataSetProducto;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private panaderiaDataSetProductoTableAdapters.productoTableAdapter productoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idproductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn preciounitarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diasparavencimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idproveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoproductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn caracteristicaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource panaderiaDataSetBindingSource;
        private panaderiaDataSet panaderiaDataSet;
        private System.Windows.Forms.BindingSource proveedorBindingSource;
        private panaderiaDataSetTableAdapters.proveedorTableAdapter proveedorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idproveedorDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreprovDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button brnModificar;
        private System.Windows.Forms.Button btnMostrarL;
        private System.Windows.Forms.Button btnOcultar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.ToolTip toolTip1;
        private panaderiaDataSet panaderiaDataSet1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem irAMantenedorDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem irAMantenedorDeProveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem irAAdministracionDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem irAAdminnistracionDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem irANuevaVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem irAMenuPrincipalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirAltF4ToolStripMenuItem;
    }
}