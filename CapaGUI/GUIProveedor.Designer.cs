namespace CapaGUI
{
    partial class GUIProveedor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUIProveedor));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdProv = new System.Windows.Forms.TextBox();
            this.txtNameProv = new System.Windows.Forms.TextBox();
            this.txtNumberProv = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnList = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idproveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreprovDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroprovDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panaderiaDataSet = new CapaGUI.panaderiaDataSet();
            this.proveedorTableAdapter = new CapaGUI.panaderiaDataSetTableAdapters.proveedorTableAdapter();
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
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panaderiaDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id Proveedor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre Proveedor (Contacto)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Numero Proveedor";
            // 
            // txtIdProv
            // 
            this.txtIdProv.Location = new System.Drawing.Point(198, 74);
            this.txtIdProv.Name = "txtIdProv";
            this.txtIdProv.Size = new System.Drawing.Size(206, 20);
            this.txtIdProv.TabIndex = 3;
            // 
            // txtNameProv
            // 
            this.txtNameProv.Location = new System.Drawing.Point(198, 133);
            this.txtNameProv.Name = "txtNameProv";
            this.txtNameProv.Size = new System.Drawing.Size(206, 20);
            this.txtNameProv.TabIndex = 4;
            this.toolTip1.SetToolTip(this.txtNameProv, "ej: Juan O\'Driscoll");
            // 
            // txtNumberProv
            // 
            this.txtNumberProv.Location = new System.Drawing.Point(198, 200);
            this.txtNumberProv.Name = "txtNumberProv";
            this.txtNumberProv.Size = new System.Drawing.Size(206, 20);
            this.txtNumberProv.TabIndex = 5;
            this.toolTip1.SetToolTip(this.txtNumberProv, "ej: 11111111");
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(43, 291);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.toolTip1.SetToolTip(this.btnAgregar, "Agrega a un proveedor");
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(198, 291);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.toolTip1.SetToolTip(this.btnEliminar, "Elimina a un proveedor existente");
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(329, 291);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 8;
            this.btnModificar.Text = "Modificar";
            this.toolTip1.SetToolTip(this.btnModificar, "Modifica el nombre y el numero del proveedor");
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(329, 361);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(75, 23);
            this.btnList.TabIndex = 10;
            this.btnList.Text = "Mostrar Lista";
            this.toolTip1.SetToolTip(this.btnList, "Muestra la lista");
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idproveedorDataGridViewTextBoxColumn,
            this.nombreprovDataGridViewTextBoxColumn,
            this.numeroprovDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.proveedorBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(427, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(345, 240);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // idproveedorDataGridViewTextBoxColumn
            // 
            this.idproveedorDataGridViewTextBoxColumn.DataPropertyName = "idproveedor";
            this.idproveedorDataGridViewTextBoxColumn.HeaderText = "idproveedor";
            this.idproveedorDataGridViewTextBoxColumn.Name = "idproveedorDataGridViewTextBoxColumn";
            this.idproveedorDataGridViewTextBoxColumn.ReadOnly = true;
            this.idproveedorDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idproveedorDataGridViewTextBoxColumn.Visible = false;
            // 
            // nombreprovDataGridViewTextBoxColumn
            // 
            this.nombreprovDataGridViewTextBoxColumn.DataPropertyName = "nombre_prov";
            this.nombreprovDataGridViewTextBoxColumn.HeaderText = "nombre_prov";
            this.nombreprovDataGridViewTextBoxColumn.Name = "nombreprovDataGridViewTextBoxColumn";
            this.nombreprovDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numeroprovDataGridViewTextBoxColumn
            // 
            this.numeroprovDataGridViewTextBoxColumn.DataPropertyName = "numero_prov";
            this.numeroprovDataGridViewTextBoxColumn.HeaderText = "numero_prov";
            this.numeroprovDataGridViewTextBoxColumn.Name = "numeroprovDataGridViewTextBoxColumn";
            this.numeroprovDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // proveedorBindingSource
            // 
            this.proveedorBindingSource.DataMember = "proveedor";
            this.proveedorBindingSource.DataSource = this.panaderiaDataSet;
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
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
            // GUIProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtNumberProv);
            this.Controls.Add(this.txtNameProv);
            this.Controls.Add(this.txtIdProv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GUIProveedor";
            this.Text = "Administracion de Proveedores";
            this.toolTip1.SetToolTip(this, "Agrega un proveedor");
            this.Load += new System.EventHandler(this.Proveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panaderiaDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdProv;
        private System.Windows.Forms.TextBox txtNameProv;
        private System.Windows.Forms.TextBox txtNumberProv;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private panaderiaDataSet panaderiaDataSet;
        private System.Windows.Forms.BindingSource proveedorBindingSource;
        private panaderiaDataSetTableAdapters.proveedorTableAdapter proveedorTableAdapter;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.DataGridViewTextBoxColumn idproveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreprovDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroprovDataGridViewTextBoxColumn;
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

