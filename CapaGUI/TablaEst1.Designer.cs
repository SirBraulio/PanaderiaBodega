namespace CapaGUI
{
    partial class TablaEst1
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
            this.panaderiaDataSetProductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panaderiaDataSetProducto = new CapaGUI.panaderiaDataSetProducto();
            this.productoTableAdapter = new CapaGUI.panaderiaDataSetProductoTableAdapters.productoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panaderiaDataSetProductoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panaderiaDataSetProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
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
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(800, 450);
            this.dataGridView1.TabIndex = 0;
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
            this.preciounitarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "cantidad";
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            this.cantidadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // diasparavencimientoDataGridViewTextBoxColumn
            // 
            this.diasparavencimientoDataGridViewTextBoxColumn.DataPropertyName = "dias_paravencimiento";
            this.diasparavencimientoDataGridViewTextBoxColumn.HeaderText = "dias_paravencimiento";
            this.diasparavencimientoDataGridViewTextBoxColumn.Name = "diasparavencimientoDataGridViewTextBoxColumn";
            this.diasparavencimientoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idproveedorDataGridViewTextBoxColumn
            // 
            this.idproveedorDataGridViewTextBoxColumn.DataPropertyName = "idproveedor";
            this.idproveedorDataGridViewTextBoxColumn.HeaderText = "idproveedor";
            this.idproveedorDataGridViewTextBoxColumn.Name = "idproveedorDataGridViewTextBoxColumn";
            this.idproveedorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoproductoDataGridViewTextBoxColumn
            // 
            this.tipoproductoDataGridViewTextBoxColumn.DataPropertyName = "tipo_producto";
            this.tipoproductoDataGridViewTextBoxColumn.HeaderText = "tipo_producto";
            this.tipoproductoDataGridViewTextBoxColumn.Name = "tipoproductoDataGridViewTextBoxColumn";
            this.tipoproductoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // caracteristicaDataGridViewTextBoxColumn
            // 
            this.caracteristicaDataGridViewTextBoxColumn.DataPropertyName = "caracteristica";
            this.caracteristicaDataGridViewTextBoxColumn.HeaderText = "caracteristica";
            this.caracteristicaDataGridViewTextBoxColumn.Name = "caracteristicaDataGridViewTextBoxColumn";
            this.caracteristicaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // marcaDataGridViewTextBoxColumn
            // 
            this.marcaDataGridViewTextBoxColumn.DataPropertyName = "marca";
            this.marcaDataGridViewTextBoxColumn.HeaderText = "marca";
            this.marcaDataGridViewTextBoxColumn.Name = "marcaDataGridViewTextBoxColumn";
            this.marcaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataMember = "producto";
            this.productoBindingSource.DataSource = this.panaderiaDataSetProductoBindingSource;
            // 
            // panaderiaDataSetProductoBindingSource
            // 
            this.panaderiaDataSetProductoBindingSource.DataSource = this.panaderiaDataSetProducto;
            this.panaderiaDataSetProductoBindingSource.Position = 0;
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
            // TablaEst1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TablaEst1";
            this.Text = "Tabla Producto";
            this.Load += new System.EventHandler(this.TablaEst1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panaderiaDataSetProductoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panaderiaDataSetProducto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource panaderiaDataSetProductoBindingSource;
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
    }
}