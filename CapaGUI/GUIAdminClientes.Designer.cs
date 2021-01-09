namespace CapaGUI
{
    partial class GUIAdminClientes
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
            this.txtRutCliente = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtNumeroCel = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificarCliente = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rutclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numerocelularDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantcomprasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panaderiaDataSetClientes = new CapaGUI.panaderiaDataSetClientes();
            this.clienteTableAdapter = new CapaGUI.panaderiaDataSetClientesTableAdapters.clienteTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panaderiaDataSetClientes)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rut Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Numero Celular";
            // 
            // txtRutCliente
            // 
            this.txtRutCliente.Location = new System.Drawing.Point(233, 82);
            this.txtRutCliente.Name = "txtRutCliente";
            this.txtRutCliente.Size = new System.Drawing.Size(100, 20);
            this.txtRutCliente.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(233, 133);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // txtNumeroCel
            // 
            this.txtNumeroCel.Location = new System.Drawing.Point(233, 178);
            this.txtNumeroCel.Name = "txtNumeroCel";
            this.txtNumeroCel.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroCel.TabIndex = 5;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(415, 34);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(89, 34);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar nuevo cliente";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificarCliente
            // 
            this.btnModificarCliente.Location = new System.Drawing.Point(415, 100);
            this.btnModificarCliente.Name = "btnModificarCliente";
            this.btnModificarCliente.Size = new System.Drawing.Size(89, 37);
            this.btnModificarCliente.TabIndex = 7;
            this.btnModificarCliente.Text = "Modificar Cliente";
            this.btnModificarCliente.UseVisualStyleBackColor = true;
            this.btnModificarCliente.Click += new System.EventHandler(this.btnModificarCliente_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idclienteDataGridViewTextBoxColumn,
            this.rutclienteDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.numerocelularDataGridViewTextBoxColumn,
            this.cantcomprasDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.clienteBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(93, 246);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(544, 138);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // idclienteDataGridViewTextBoxColumn
            // 
            this.idclienteDataGridViewTextBoxColumn.DataPropertyName = "idcliente";
            this.idclienteDataGridViewTextBoxColumn.HeaderText = "idcliente";
            this.idclienteDataGridViewTextBoxColumn.Name = "idclienteDataGridViewTextBoxColumn";
            this.idclienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rutclienteDataGridViewTextBoxColumn
            // 
            this.rutclienteDataGridViewTextBoxColumn.DataPropertyName = "rutcliente";
            this.rutclienteDataGridViewTextBoxColumn.HeaderText = "rutcliente";
            this.rutclienteDataGridViewTextBoxColumn.Name = "rutclienteDataGridViewTextBoxColumn";
            this.rutclienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numerocelularDataGridViewTextBoxColumn
            // 
            this.numerocelularDataGridViewTextBoxColumn.DataPropertyName = "numero_celular";
            this.numerocelularDataGridViewTextBoxColumn.HeaderText = "numero_celular";
            this.numerocelularDataGridViewTextBoxColumn.Name = "numerocelularDataGridViewTextBoxColumn";
            this.numerocelularDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cantcomprasDataGridViewTextBoxColumn
            // 
            this.cantcomprasDataGridViewTextBoxColumn.DataPropertyName = "cant_compras";
            this.cantcomprasDataGridViewTextBoxColumn.HeaderText = "cant_compras";
            this.cantcomprasDataGridViewTextBoxColumn.Name = "cantcomprasDataGridViewTextBoxColumn";
            this.cantcomprasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "cliente";
            this.clienteBindingSource.DataSource = this.panaderiaDataSetClientes;
            // 
            // panaderiaDataSetClientes
            // 
            this.panaderiaDataSetClientes.DataSetName = "panaderiaDataSetClientes";
            this.panaderiaDataSetClientes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Id Cliente";
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Enabled = false;
            this.txtIdCliente.Location = new System.Drawing.Point(233, 34);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.ReadOnly = true;
            this.txtIdCliente.Size = new System.Drawing.Size(100, 20);
            this.txtIdCliente.TabIndex = 10;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(415, 181);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(89, 23);
            this.btnLimpiar.TabIndex = 12;
            this.btnLimpiar.Text = "Limpiar campos";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(562, 181);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(75, 23);
            this.btnList.TabIndex = 13;
            this.btnList.Text = "Mostrar Lista";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 29;
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
            // GUIAdminClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txtIdCliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnModificarCliente);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtNumeroCel);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtRutCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GUIAdminClientes";
            this.Text = "Administrar Clientes";
            this.Load += new System.EventHandler(this.GUIAdminClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panaderiaDataSetClientes)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRutCliente;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtNumeroCel;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificarCliente;
        private System.Windows.Forms.DataGridView dataGridView1;
        private panaderiaDataSetClientes panaderiaDataSetClientes;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private panaderiaDataSetClientesTableAdapters.clienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rutclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numerocelularDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantcomprasDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnList;
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