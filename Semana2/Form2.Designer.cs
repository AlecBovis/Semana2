namespace Semana2
{
    partial class Form2
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
            this.DgPedidos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.DgDetalle = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.neptunoDataSet1 = new Semana2.neptunoDataSet1();
            this.pedidosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pedidosTableAdapter = new Semana2.neptunoDataSet1TableAdapters.PedidosTableAdapter();
            this.idPedidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEmpleadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaPedidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaEntregaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaEnvioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formaEnvioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinatarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDestinatarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciudadDestinatarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regionDestinatarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codPostalDestinatarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paisDestinatarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.neptunoDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DgPedidos
            // 
            this.DgPedidos.AllowUserToAddRows = false;
            this.DgPedidos.AllowUserToDeleteRows = false;
            this.DgPedidos.AutoGenerateColumns = false;
            this.DgPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPedidoDataGridViewTextBoxColumn,
            this.idClienteDataGridViewTextBoxColumn,
            this.idEmpleadoDataGridViewTextBoxColumn,
            this.fechaPedidoDataGridViewTextBoxColumn,
            this.fechaEntregaDataGridViewTextBoxColumn,
            this.fechaEnvioDataGridViewTextBoxColumn,
            this.formaEnvioDataGridViewTextBoxColumn,
            this.cargoDataGridViewTextBoxColumn,
            this.destinatarioDataGridViewTextBoxColumn,
            this.direccionDestinatarioDataGridViewTextBoxColumn,
            this.ciudadDestinatarioDataGridViewTextBoxColumn,
            this.regionDestinatarioDataGridViewTextBoxColumn,
            this.codPostalDestinatarioDataGridViewTextBoxColumn,
            this.paisDestinatarioDataGridViewTextBoxColumn});
            this.DgPedidos.DataSource = this.pedidosBindingSource;
            this.DgPedidos.Location = new System.Drawing.Point(52, 66);
            this.DgPedidos.Name = "DgPedidos";
            this.DgPedidos.ReadOnly = true;
            this.DgPedidos.Size = new System.Drawing.Size(698, 178);
            this.DgPedidos.TabIndex = 0;
            this.DgPedidos.DoubleClick += new System.EventHandler(this.DgPedido_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "PEDIDOS REGISTRADOS";
            // 
            // DgDetalle
            // 
            this.DgDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgDetalle.Location = new System.Drawing.Point(52, 288);
            this.DgDetalle.Name = "DgDetalle";
            this.DgDetalle.Size = new System.Drawing.Size(698, 150);
            this.DgDetalle.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "DETALLE DE PEDIDOS";
            // 
            // neptunoDataSet1
            // 
            this.neptunoDataSet1.DataSetName = "neptunoDataSet1";
            this.neptunoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pedidosBindingSource
            // 
            this.pedidosBindingSource.DataMember = "Pedidos";
            this.pedidosBindingSource.DataSource = this.neptunoDataSet1;
            // 
            // pedidosTableAdapter
            // 
            this.pedidosTableAdapter.ClearBeforeFill = true;
            // 
            // idPedidoDataGridViewTextBoxColumn
            // 
            this.idPedidoDataGridViewTextBoxColumn.DataPropertyName = "IdPedido";
            this.idPedidoDataGridViewTextBoxColumn.HeaderText = "IdPedido";
            this.idPedidoDataGridViewTextBoxColumn.Name = "idPedidoDataGridViewTextBoxColumn";
            this.idPedidoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idClienteDataGridViewTextBoxColumn
            // 
            this.idClienteDataGridViewTextBoxColumn.DataPropertyName = "IdCliente";
            this.idClienteDataGridViewTextBoxColumn.HeaderText = "IdCliente";
            this.idClienteDataGridViewTextBoxColumn.Name = "idClienteDataGridViewTextBoxColumn";
            this.idClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idEmpleadoDataGridViewTextBoxColumn
            // 
            this.idEmpleadoDataGridViewTextBoxColumn.DataPropertyName = "IdEmpleado";
            this.idEmpleadoDataGridViewTextBoxColumn.HeaderText = "IdEmpleado";
            this.idEmpleadoDataGridViewTextBoxColumn.Name = "idEmpleadoDataGridViewTextBoxColumn";
            this.idEmpleadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaPedidoDataGridViewTextBoxColumn
            // 
            this.fechaPedidoDataGridViewTextBoxColumn.DataPropertyName = "FechaPedido";
            this.fechaPedidoDataGridViewTextBoxColumn.HeaderText = "FechaPedido";
            this.fechaPedidoDataGridViewTextBoxColumn.Name = "fechaPedidoDataGridViewTextBoxColumn";
            this.fechaPedidoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaEntregaDataGridViewTextBoxColumn
            // 
            this.fechaEntregaDataGridViewTextBoxColumn.DataPropertyName = "FechaEntrega";
            this.fechaEntregaDataGridViewTextBoxColumn.HeaderText = "FechaEntrega";
            this.fechaEntregaDataGridViewTextBoxColumn.Name = "fechaEntregaDataGridViewTextBoxColumn";
            this.fechaEntregaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaEnvioDataGridViewTextBoxColumn
            // 
            this.fechaEnvioDataGridViewTextBoxColumn.DataPropertyName = "FechaEnvio";
            this.fechaEnvioDataGridViewTextBoxColumn.HeaderText = "FechaEnvio";
            this.fechaEnvioDataGridViewTextBoxColumn.Name = "fechaEnvioDataGridViewTextBoxColumn";
            this.fechaEnvioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // formaEnvioDataGridViewTextBoxColumn
            // 
            this.formaEnvioDataGridViewTextBoxColumn.DataPropertyName = "FormaEnvio";
            this.formaEnvioDataGridViewTextBoxColumn.HeaderText = "FormaEnvio";
            this.formaEnvioDataGridViewTextBoxColumn.Name = "formaEnvioDataGridViewTextBoxColumn";
            this.formaEnvioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cargoDataGridViewTextBoxColumn
            // 
            this.cargoDataGridViewTextBoxColumn.DataPropertyName = "Cargo";
            this.cargoDataGridViewTextBoxColumn.HeaderText = "Cargo";
            this.cargoDataGridViewTextBoxColumn.Name = "cargoDataGridViewTextBoxColumn";
            this.cargoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // destinatarioDataGridViewTextBoxColumn
            // 
            this.destinatarioDataGridViewTextBoxColumn.DataPropertyName = "Destinatario";
            this.destinatarioDataGridViewTextBoxColumn.HeaderText = "Destinatario";
            this.destinatarioDataGridViewTextBoxColumn.Name = "destinatarioDataGridViewTextBoxColumn";
            this.destinatarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // direccionDestinatarioDataGridViewTextBoxColumn
            // 
            this.direccionDestinatarioDataGridViewTextBoxColumn.DataPropertyName = "DireccionDestinatario";
            this.direccionDestinatarioDataGridViewTextBoxColumn.HeaderText = "DireccionDestinatario";
            this.direccionDestinatarioDataGridViewTextBoxColumn.Name = "direccionDestinatarioDataGridViewTextBoxColumn";
            this.direccionDestinatarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ciudadDestinatarioDataGridViewTextBoxColumn
            // 
            this.ciudadDestinatarioDataGridViewTextBoxColumn.DataPropertyName = "CiudadDestinatario";
            this.ciudadDestinatarioDataGridViewTextBoxColumn.HeaderText = "CiudadDestinatario";
            this.ciudadDestinatarioDataGridViewTextBoxColumn.Name = "ciudadDestinatarioDataGridViewTextBoxColumn";
            this.ciudadDestinatarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // regionDestinatarioDataGridViewTextBoxColumn
            // 
            this.regionDestinatarioDataGridViewTextBoxColumn.DataPropertyName = "RegionDestinatario";
            this.regionDestinatarioDataGridViewTextBoxColumn.HeaderText = "RegionDestinatario";
            this.regionDestinatarioDataGridViewTextBoxColumn.Name = "regionDestinatarioDataGridViewTextBoxColumn";
            this.regionDestinatarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codPostalDestinatarioDataGridViewTextBoxColumn
            // 
            this.codPostalDestinatarioDataGridViewTextBoxColumn.DataPropertyName = "CodPostalDestinatario";
            this.codPostalDestinatarioDataGridViewTextBoxColumn.HeaderText = "CodPostalDestinatario";
            this.codPostalDestinatarioDataGridViewTextBoxColumn.Name = "codPostalDestinatarioDataGridViewTextBoxColumn";
            this.codPostalDestinatarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paisDestinatarioDataGridViewTextBoxColumn
            // 
            this.paisDestinatarioDataGridViewTextBoxColumn.DataPropertyName = "PaisDestinatario";
            this.paisDestinatarioDataGridViewTextBoxColumn.HeaderText = "PaisDestinatario";
            this.paisDestinatarioDataGridViewTextBoxColumn.Name = "paisDestinatarioDataGridViewTextBoxColumn";
            this.paisDestinatarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DgDetalle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgPedidos);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.neptunoDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgPedidos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgDetalle;
        private System.Windows.Forms.Label label2;
        private neptunoDataSet1 neptunoDataSet1;
        private System.Windows.Forms.BindingSource pedidosBindingSource;
        private neptunoDataSet1TableAdapters.PedidosTableAdapter pedidosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPedidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEmpleadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaPedidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaEntregaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaEnvioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn formaEnvioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinatarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDestinatarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciudadDestinatarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regionDestinatarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codPostalDestinatarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paisDestinatarioDataGridViewTextBoxColumn;
    }
}