
namespace HARS
{
    partial class ApplianceList
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
            this.hARSDBDataSet = new HARS.HARSDBDataSet();
            this.hARSDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dimensionsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.energyconsumptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appliancesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.appliancesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.appliancesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appliancesTableAdapter = new HARS.HARSDBDataSetTableAdapters.appliancesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.hARSDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hARSDBDataSetBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appliancesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appliancesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appliancesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // hARSDBDataSet
            // 
            this.hARSDBDataSet.DataSetName = "HARSDBDataSet";
            this.hARSDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hARSDBDataSetBindingSource
            // 
            this.hARSDBDataSetBindingSource.DataSource = this.hARSDBDataSet;
            this.hARSDBDataSetBindingSource.Position = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1384, 510);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Appliance List";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.brandsDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.modelsDataGridViewTextBoxColumn,
            this.dimensionsDataGridViewTextBoxColumn,
            this.colourDataGridViewTextBoxColumn,
            this.energyconsumptionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.appliancesBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(0, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1384, 487);
            this.dataGridView1.TabIndex = 2;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // brandsDataGridViewTextBoxColumn
            // 
            this.brandsDataGridViewTextBoxColumn.DataPropertyName = "brands";
            this.brandsDataGridViewTextBoxColumn.HeaderText = "brands";
            this.brandsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.brandsDataGridViewTextBoxColumn.Name = "brandsDataGridViewTextBoxColumn";
            this.brandsDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // modelsDataGridViewTextBoxColumn
            // 
            this.modelsDataGridViewTextBoxColumn.DataPropertyName = "models";
            this.modelsDataGridViewTextBoxColumn.HeaderText = "models";
            this.modelsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.modelsDataGridViewTextBoxColumn.Name = "modelsDataGridViewTextBoxColumn";
            this.modelsDataGridViewTextBoxColumn.Width = 125;
            // 
            // dimensionsDataGridViewTextBoxColumn
            // 
            this.dimensionsDataGridViewTextBoxColumn.DataPropertyName = "dimensions";
            this.dimensionsDataGridViewTextBoxColumn.HeaderText = "dimensions";
            this.dimensionsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dimensionsDataGridViewTextBoxColumn.Name = "dimensionsDataGridViewTextBoxColumn";
            this.dimensionsDataGridViewTextBoxColumn.Width = 125;
            // 
            // colourDataGridViewTextBoxColumn
            // 
            this.colourDataGridViewTextBoxColumn.DataPropertyName = "colour";
            this.colourDataGridViewTextBoxColumn.HeaderText = "colour";
            this.colourDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.colourDataGridViewTextBoxColumn.Name = "colourDataGridViewTextBoxColumn";
            this.colourDataGridViewTextBoxColumn.Width = 125;
            // 
            // energyconsumptionDataGridViewTextBoxColumn
            // 
            this.energyconsumptionDataGridViewTextBoxColumn.DataPropertyName = "energy_consumption";
            this.energyconsumptionDataGridViewTextBoxColumn.HeaderText = "energy_consumption";
            this.energyconsumptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.energyconsumptionDataGridViewTextBoxColumn.Name = "energyconsumptionDataGridViewTextBoxColumn";
            this.energyconsumptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // appliancesBindingSource2
            // 
            this.appliancesBindingSource2.DataMember = "appliances";
            this.appliancesBindingSource2.DataSource = this.hARSDBDataSet;
            // 
            // appliancesBindingSource1
            // 
            this.appliancesBindingSource1.DataMember = "appliances";
            this.appliancesBindingSource1.DataSource = this.hARSDBDataSetBindingSource;
            // 
            // appliancesBindingSource
            // 
            this.appliancesBindingSource.DataMember = "appliances";
            this.appliancesBindingSource.DataSource = this.hARSDBDataSetBindingSource;
            // 
            // appliancesTableAdapter
            // 
            this.appliancesTableAdapter.ClearBeforeFill = true;
            // 
            // ApplianceList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1388, 508);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ApplianceList";
            this.Text = "ApplianceList";
            this.Load += new System.EventHandler(this.ApplianceList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hARSDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hARSDBDataSetBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appliancesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appliancesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appliancesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private HARSDBDataSet hARSDBDataSet;
        private System.Windows.Forms.BindingSource hARSDBDataSetBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource appliancesBindingSource;
        private HARSDBDataSetTableAdapters.appliancesTableAdapter appliancesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn appliancestypesDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource appliancesBindingSource1;
        private System.Windows.Forms.BindingSource appliancesBindingSource2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dimensionsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn energyconsumptionDataGridViewTextBoxColumn;
    }
}