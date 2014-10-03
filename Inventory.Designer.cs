namespace Inventory
{
    partial class Inventory
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.InventoryDataSet = new Inventory.InventoryDataSet();
            this.inventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.InventoryTableAdapter = new Inventory.InventoryDataSetTableAdapters.InventoryTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentManufactureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentPartNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sheetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityInventoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costInventoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extensionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depreciatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.originalCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfInventoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfInvoiceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alternateSupplier1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alternateSupplierPartNumber1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alternateSupplier2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alternateSupplierPartNumber2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alternateSupplier3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alternateSupplierPartNumber3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(803, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // dataGridView
            // 
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn,
            this.departmentDataGridViewTextBoxColumn,
            this.currentManufactureDataGridViewTextBoxColumn,
            this.currentPartNumberDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.sheetDataGridViewTextBoxColumn,
            this.checkedDataGridViewTextBoxColumn,
            this.quantityInventoryDataGridViewTextBoxColumn,
            this.costInventoryDataGridViewTextBoxColumn,
            this.extensionDataGridViewTextBoxColumn,
            this.depreciatedDataGridViewTextBoxColumn,
            this.originalCostDataGridViewTextBoxColumn,
            this.dateOfInventoryDataGridViewTextBoxColumn,
            this.numDataGridViewTextBoxColumn,
            this.dateOfInvoiceDataGridViewTextBoxColumn,
            this.invoiceCostDataGridViewTextBoxColumn,
            this.invoiceDataGridViewTextBoxColumn,
            this.alternateSupplier1DataGridViewTextBoxColumn,
            this.alternateSupplierPartNumber1DataGridViewTextBoxColumn,
            this.alternateSupplier2DataGridViewTextBoxColumn,
            this.alternateSupplierPartNumber2DataGridViewTextBoxColumn,
            this.alternateSupplier3DataGridViewTextBoxColumn,
            this.alternateSupplierPartNumber3DataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.inventoryBindingSource;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 24);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(803, 569);
            this.dataGridView.TabIndex = 2;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // InventoryDataSet
            // 
            this.InventoryDataSet.DataSetName = "InventoryDataSet";
            this.InventoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inventoryBindingSource
            // 
            this.inventoryBindingSource.DataMember = "Inventory";
            this.inventoryBindingSource.DataSource = this.InventoryDataSet;
            // 
            // InventoryTableAdapter
            // 
            this.InventoryTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "Location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "Location";
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            // 
            // departmentDataGridViewTextBoxColumn
            // 
            this.departmentDataGridViewTextBoxColumn.DataPropertyName = "Department";
            this.departmentDataGridViewTextBoxColumn.HeaderText = "Department";
            this.departmentDataGridViewTextBoxColumn.Name = "departmentDataGridViewTextBoxColumn";
            // 
            // currentManufactureDataGridViewTextBoxColumn
            // 
            this.currentManufactureDataGridViewTextBoxColumn.DataPropertyName = "Current Manufacture";
            this.currentManufactureDataGridViewTextBoxColumn.HeaderText = "Current Manufacture";
            this.currentManufactureDataGridViewTextBoxColumn.Name = "currentManufactureDataGridViewTextBoxColumn";
            // 
            // currentPartNumberDataGridViewTextBoxColumn
            // 
            this.currentPartNumberDataGridViewTextBoxColumn.DataPropertyName = "Current Part Number";
            this.currentPartNumberDataGridViewTextBoxColumn.HeaderText = "Current Part Number";
            this.currentPartNumberDataGridViewTextBoxColumn.Name = "currentPartNumberDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // sheetDataGridViewTextBoxColumn
            // 
            this.sheetDataGridViewTextBoxColumn.DataPropertyName = "Sheet";
            this.sheetDataGridViewTextBoxColumn.HeaderText = "Sheet";
            this.sheetDataGridViewTextBoxColumn.Name = "sheetDataGridViewTextBoxColumn";
            // 
            // checkedDataGridViewTextBoxColumn
            // 
            this.checkedDataGridViewTextBoxColumn.DataPropertyName = "Checked";
            this.checkedDataGridViewTextBoxColumn.HeaderText = "Checked";
            this.checkedDataGridViewTextBoxColumn.Name = "checkedDataGridViewTextBoxColumn";
            // 
            // quantityInventoryDataGridViewTextBoxColumn
            // 
            this.quantityInventoryDataGridViewTextBoxColumn.DataPropertyName = "Quantity @ Inventory";
            this.quantityInventoryDataGridViewTextBoxColumn.HeaderText = "Quantity @ Inventory";
            this.quantityInventoryDataGridViewTextBoxColumn.Name = "quantityInventoryDataGridViewTextBoxColumn";
            // 
            // costInventoryDataGridViewTextBoxColumn
            // 
            this.costInventoryDataGridViewTextBoxColumn.DataPropertyName = "Cost @ Inventory";
            this.costInventoryDataGridViewTextBoxColumn.HeaderText = "Cost @ Inventory";
            this.costInventoryDataGridViewTextBoxColumn.Name = "costInventoryDataGridViewTextBoxColumn";
            // 
            // extensionDataGridViewTextBoxColumn
            // 
            this.extensionDataGridViewTextBoxColumn.DataPropertyName = "Extension";
            this.extensionDataGridViewTextBoxColumn.HeaderText = "Extension";
            this.extensionDataGridViewTextBoxColumn.Name = "extensionDataGridViewTextBoxColumn";
            // 
            // depreciatedDataGridViewTextBoxColumn
            // 
            this.depreciatedDataGridViewTextBoxColumn.DataPropertyName = "Depreciated";
            this.depreciatedDataGridViewTextBoxColumn.HeaderText = "Depreciated";
            this.depreciatedDataGridViewTextBoxColumn.Name = "depreciatedDataGridViewTextBoxColumn";
            // 
            // originalCostDataGridViewTextBoxColumn
            // 
            this.originalCostDataGridViewTextBoxColumn.DataPropertyName = "Original Cost";
            this.originalCostDataGridViewTextBoxColumn.HeaderText = "Original Cost";
            this.originalCostDataGridViewTextBoxColumn.Name = "originalCostDataGridViewTextBoxColumn";
            // 
            // dateOfInventoryDataGridViewTextBoxColumn
            // 
            this.dateOfInventoryDataGridViewTextBoxColumn.DataPropertyName = "Date of Inventory";
            this.dateOfInventoryDataGridViewTextBoxColumn.HeaderText = "Date of Inventory";
            this.dateOfInventoryDataGridViewTextBoxColumn.Name = "dateOfInventoryDataGridViewTextBoxColumn";
            // 
            // numDataGridViewTextBoxColumn
            // 
            this.numDataGridViewTextBoxColumn.DataPropertyName = "Num";
            this.numDataGridViewTextBoxColumn.HeaderText = "Num";
            this.numDataGridViewTextBoxColumn.Name = "numDataGridViewTextBoxColumn";
            // 
            // dateOfInvoiceDataGridViewTextBoxColumn
            // 
            this.dateOfInvoiceDataGridViewTextBoxColumn.DataPropertyName = "Date of Invoice";
            this.dateOfInvoiceDataGridViewTextBoxColumn.HeaderText = "Date of Invoice";
            this.dateOfInvoiceDataGridViewTextBoxColumn.Name = "dateOfInvoiceDataGridViewTextBoxColumn";
            // 
            // invoiceCostDataGridViewTextBoxColumn
            // 
            this.invoiceCostDataGridViewTextBoxColumn.DataPropertyName = "Invoice Cost";
            this.invoiceCostDataGridViewTextBoxColumn.HeaderText = "Invoice Cost";
            this.invoiceCostDataGridViewTextBoxColumn.Name = "invoiceCostDataGridViewTextBoxColumn";
            // 
            // invoiceDataGridViewTextBoxColumn
            // 
            this.invoiceDataGridViewTextBoxColumn.DataPropertyName = "Invoice #";
            this.invoiceDataGridViewTextBoxColumn.HeaderText = "Invoice #";
            this.invoiceDataGridViewTextBoxColumn.Name = "invoiceDataGridViewTextBoxColumn";
            // 
            // alternateSupplier1DataGridViewTextBoxColumn
            // 
            this.alternateSupplier1DataGridViewTextBoxColumn.DataPropertyName = "Alternate Supplier - 1";
            this.alternateSupplier1DataGridViewTextBoxColumn.HeaderText = "Alternate Supplier - 1";
            this.alternateSupplier1DataGridViewTextBoxColumn.Name = "alternateSupplier1DataGridViewTextBoxColumn";
            // 
            // alternateSupplierPartNumber1DataGridViewTextBoxColumn
            // 
            this.alternateSupplierPartNumber1DataGridViewTextBoxColumn.DataPropertyName = "Alternate Supplier Part Number - 1";
            this.alternateSupplierPartNumber1DataGridViewTextBoxColumn.HeaderText = "Alternate Supplier Part Number - 1";
            this.alternateSupplierPartNumber1DataGridViewTextBoxColumn.Name = "alternateSupplierPartNumber1DataGridViewTextBoxColumn";
            // 
            // alternateSupplier2DataGridViewTextBoxColumn
            // 
            this.alternateSupplier2DataGridViewTextBoxColumn.DataPropertyName = "Alternate Supplier - 2";
            this.alternateSupplier2DataGridViewTextBoxColumn.HeaderText = "Alternate Supplier - 2";
            this.alternateSupplier2DataGridViewTextBoxColumn.Name = "alternateSupplier2DataGridViewTextBoxColumn";
            // 
            // alternateSupplierPartNumber2DataGridViewTextBoxColumn
            // 
            this.alternateSupplierPartNumber2DataGridViewTextBoxColumn.DataPropertyName = "Alternate Supplier Part Number - 2";
            this.alternateSupplierPartNumber2DataGridViewTextBoxColumn.HeaderText = "Alternate Supplier Part Number - 2";
            this.alternateSupplierPartNumber2DataGridViewTextBoxColumn.Name = "alternateSupplierPartNumber2DataGridViewTextBoxColumn";
            // 
            // alternateSupplier3DataGridViewTextBoxColumn
            // 
            this.alternateSupplier3DataGridViewTextBoxColumn.DataPropertyName = "Alternate Supplier - 3";
            this.alternateSupplier3DataGridViewTextBoxColumn.HeaderText = "Alternate Supplier - 3";
            this.alternateSupplier3DataGridViewTextBoxColumn.Name = "alternateSupplier3DataGridViewTextBoxColumn";
            // 
            // alternateSupplierPartNumber3DataGridViewTextBoxColumn
            // 
            this.alternateSupplierPartNumber3DataGridViewTextBoxColumn.DataPropertyName = "Alternate Supplier Part Number - 3";
            this.alternateSupplierPartNumber3DataGridViewTextBoxColumn.HeaderText = "Alternate Supplier Part Number - 3";
            this.alternateSupplierPartNumber3DataGridViewTextBoxColumn.Name = "alternateSupplierPartNumber3DataGridViewTextBoxColumn";
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 593);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Inventory";
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.Inventory_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView;
        private InventoryDataSet InventoryDataSet;
        private System.Windows.Forms.BindingSource inventoryBindingSource;
        private InventoryDataSetTableAdapters.InventoryTableAdapter InventoryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentManufactureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentPartNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sheetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityInventoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costInventoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn extensionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn depreciatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn originalCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfInventoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfInvoiceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alternateSupplier1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alternateSupplierPartNumber1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alternateSupplier2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alternateSupplierPartNumber2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alternateSupplier3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alternateSupplierPartNumber3DataGridViewTextBoxColumn;
    }
}

