namespace CapaGUI
{
    partial class GUImenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUImenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.irAMantenedorDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.irAMantenedorDeProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.irAAdministracionDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.irAAdminnistracionDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.irANuevaVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirAltF4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtWarning = new System.Windows.Forms.Label();
            this.labelCantidadMin = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.labelClientesxVentas = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.labelClientesNoRegistrados = new System.Windows.Forms.Label();
            this.estsumatotal = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.irAMantenedorDeProductosToolStripMenuItem,
            this.irAMantenedorDeProveedoresToolStripMenuItem,
            this.irAAdministracionDeUsuariosToolStripMenuItem,
            this.irAAdminnistracionDeClientesToolStripMenuItem,
            this.irANuevaVentaToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
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
            // txtWarning
            // 
            this.txtWarning.AutoSize = true;
            this.txtWarning.Font = new System.Drawing.Font("Segoe UI Black", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWarning.Location = new System.Drawing.Point(57, 88);
            this.txtWarning.Name = "txtWarning";
            this.txtWarning.Size = new System.Drawing.Size(94, 19);
            this.txtWarning.TabIndex = 2;
            this.txtWarning.Text = "Estadistica 1";
            this.txtWarning.Click += new System.EventHandler(this.txtWarning_Click);
            // 
            // labelCantidadMin
            // 
            this.labelCantidadMin.AutoSize = true;
            this.labelCantidadMin.Font = new System.Drawing.Font("Segoe UI Black", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCantidadMin.Location = new System.Drawing.Point(57, 157);
            this.labelCantidadMin.Name = "labelCantidadMin";
            this.labelCantidadMin.Size = new System.Drawing.Size(95, 19);
            this.labelCantidadMin.TabIndex = 3;
            this.labelCantidadMin.Text = "Estadistica 2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(61, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Ver Tabla ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(60, 275);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Ver Tabla ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelClientesxVentas
            // 
            this.labelClientesxVentas.AutoSize = true;
            this.labelClientesxVentas.Font = new System.Drawing.Font("Segoe UI Black", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientesxVentas.Location = new System.Drawing.Point(56, 322);
            this.labelClientesxVentas.Name = "labelClientesxVentas";
            this.labelClientesxVentas.Size = new System.Drawing.Size(95, 19);
            this.labelClientesxVentas.TabIndex = 6;
            this.labelClientesxVentas.Text = "Estadistica 3";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(61, 356);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Ver Tabla ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // labelClientesNoRegistrados
            // 
            this.labelClientesNoRegistrados.AutoSize = true;
            this.labelClientesNoRegistrados.Font = new System.Drawing.Font("Segoe UI Black", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientesNoRegistrados.Location = new System.Drawing.Point(57, 195);
            this.labelClientesNoRegistrados.Name = "labelClientesNoRegistrados";
            this.labelClientesNoRegistrados.Size = new System.Drawing.Size(96, 19);
            this.labelClientesNoRegistrados.TabIndex = 8;
            this.labelClientesNoRegistrados.Text = "Estadistica 4";
            // 
            // estsumatotal
            // 
            this.estsumatotal.AutoSize = true;
            this.estsumatotal.Font = new System.Drawing.Font("Segoe UI Black", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estsumatotal.Location = new System.Drawing.Point(57, 238);
            this.estsumatotal.Name = "estsumatotal";
            this.estsumatotal.Size = new System.Drawing.Size(95, 19);
            this.estsumatotal.TabIndex = 9;
            this.estsumatotal.Text = "Estadistica 5";
            // 
            // GUImenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.estsumatotal);
            this.Controls.Add(this.labelClientesNoRegistrados);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.labelClientesxVentas);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelCantidadMin);
            this.Controls.Add(this.txtWarning);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GUImenu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.GUImenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem irAMantenedorDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem irAMantenedorDeProveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirAltF4ToolStripMenuItem;
        private System.Windows.Forms.Label txtWarning;
        private System.Windows.Forms.ToolStripMenuItem irAAdministracionDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem irAAdminnistracionDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem irANuevaVentaToolStripMenuItem;
        private System.Windows.Forms.Label labelCantidadMin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelClientesxVentas;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label labelClientesNoRegistrados;
        private System.Windows.Forms.Label estsumatotal;
    }
}