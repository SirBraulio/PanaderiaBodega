namespace CapaGUI
{
    partial class TablaEst3
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
            this.clienteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clienteBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.ventaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panaderiaDataSetVenta = new CapaGUI.panaderiaDataSetVenta();
            this.ventaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ventaTableAdapter = new CapaGUI.panaderiaDataSetVentaTableAdapters.ventaTableAdapter();
            this.panaderiaDataSetClientes = new CapaGUI.panaderiaDataSetClientes();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clienteBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter = new CapaGUI.panaderiaDataSetClientesTableAdapters.clienteTableAdapter();
            this.idclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rutclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numerocelularDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantcomprasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panaderiaDataSetVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panaderiaDataSetClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // panaderiaDataSetVenta
            // 
            this.panaderiaDataSetVenta.DataSetName = "panaderiaDataSetVenta";
            this.panaderiaDataSetVenta.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ventaBindingSource
            // 
            this.ventaBindingSource.DataMember = "venta";
            this.ventaBindingSource.DataSource = this.panaderiaDataSetVenta;
            // 
            // ventaTableAdapter
            // 
            this.ventaTableAdapter.ClearBeforeFill = true;
            // 
            // panaderiaDataSetClientes
            // 
            this.panaderiaDataSetClientes.DataSetName = "panaderiaDataSetClientes";
            this.panaderiaDataSetClientes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "cliente";
            this.clienteBindingSource.DataSource = this.panaderiaDataSetClientes;
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
            this.dataGridView1.DataSource = this.clienteBindingSource3;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(542, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // clienteBindingSource3
            // 
            this.clienteBindingSource3.DataMember = "cliente";
            this.clienteBindingSource3.DataSource = this.panaderiaDataSetClientes;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
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
            // TablaEst3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TablaEst3";
            this.Text = "Tabla Clientes";
            this.Load += new System.EventHandler(this.TablaEst3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panaderiaDataSetVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panaderiaDataSetClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource clienteBindingSource1;
        private System.Windows.Forms.BindingSource clienteBindingSource2;
        private System.Windows.Forms.BindingSource ventaBindingSource1;
        private panaderiaDataSetVenta panaderiaDataSetVenta;
        private System.Windows.Forms.BindingSource ventaBindingSource;
        private panaderiaDataSetVentaTableAdapters.ventaTableAdapter ventaTableAdapter;
        private panaderiaDataSetClientes panaderiaDataSetClientes;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource clienteBindingSource3;
        private panaderiaDataSetClientesTableAdapters.clienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rutclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numerocelularDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantcomprasDataGridViewTextBoxColumn;
    }
}