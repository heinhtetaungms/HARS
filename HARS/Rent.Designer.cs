
namespace HARS
{
    partial class Rent
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
            this.cboAppliance = new System.Windows.Forms.ComboBox();
            this.appliancesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hARSDBDataSet = new HARS.HARSDBDataSet();
            this.cboApplianceType = new System.Windows.Forms.ComboBox();
            this.appliancetypeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.appliancetypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Appliance = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboBrand = new System.Windows.Forms.ComboBox();
            this.brandBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSubmit = new System.Windows.Forms.Button();
            this.appliance_typeTableAdapter = new HARS.HARSDBDataSetTableAdapters.appliance_typeTableAdapter();
            this.appliancesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.appliancesTableAdapter = new HARS.HARSDBDataSetTableAdapters.appliancesTableAdapter();
            this.brandTableAdapter = new HARS.HARSDBDataSetTableAdapters.brandTableAdapter();
            this.registerTableAdapter1 = new HARS.HARSDBDataSetTableAdapters.registerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.appliancesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hARSDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appliancetypeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appliancetypeBindingSource)).BeginInit();
            this.Appliance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brandBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appliancesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // cboAppliance
            // 
            this.cboAppliance.FormattingEnabled = true;
            this.cboAppliance.Location = new System.Drawing.Point(215, 139);
            this.cboAppliance.Margin = new System.Windows.Forms.Padding(4);
            this.cboAppliance.Name = "cboAppliance";
            this.cboAppliance.Size = new System.Drawing.Size(200, 24);
            this.cboAppliance.TabIndex = 0;
            this.cboAppliance.SelectedIndexChanged += new System.EventHandler(this.cboAppliance_SelectedIndexChanged);
            // 
            // appliancesBindingSource
            // 
            this.appliancesBindingSource.DataMember = "appliances";
            this.appliancesBindingSource.DataSource = this.hARSDBDataSet;
            // 
            // hARSDBDataSet
            // 
            this.hARSDBDataSet.DataSetName = "HARSDBDataSet";
            this.hARSDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cboApplianceType
            // 
            this.cboApplianceType.DataSource = this.appliancetypeBindingSource1;
            this.cboApplianceType.DisplayMember = "name";
            this.cboApplianceType.FormattingEnabled = true;
            this.cboApplianceType.ItemHeight = 16;
            this.cboApplianceType.Location = new System.Drawing.Point(215, 42);
            this.cboApplianceType.Margin = new System.Windows.Forms.Padding(4);
            this.cboApplianceType.Name = "cboApplianceType";
            this.cboApplianceType.Size = new System.Drawing.Size(200, 24);
            this.cboApplianceType.TabIndex = 1;
            this.cboApplianceType.SelectedIndexChanged += new System.EventHandler(this.cboApplianceType_SelectedIndexChanged);
            // 
            // appliancetypeBindingSource1
            // 
            this.appliancetypeBindingSource1.DataMember = "appliance_type";
            this.appliancetypeBindingSource1.DataSource = this.hARSDBDataSet;
            // 
            // appliancetypeBindingSource
            // 
            this.appliancetypeBindingSource.DataMember = "appliance_type";
            this.appliancetypeBindingSource.DataSource = this.hARSDBDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Appliance Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 142);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Appliance";
            // 
            // Appliance
            // 
            this.Appliance.BackColor = System.Drawing.Color.LightBlue;
            this.Appliance.Controls.Add(this.label6);
            this.Appliance.Controls.Add(this.label5);
            this.Appliance.Controls.Add(this.dtpEndDate);
            this.Appliance.Controls.Add(this.dtpStartDate);
            this.Appliance.Controls.Add(this.label4);
            this.Appliance.Controls.Add(this.txtPrice);
            this.Appliance.Controls.Add(this.label3);
            this.Appliance.Controls.Add(this.cboBrand);
            this.Appliance.Controls.Add(this.btnSubmit);
            this.Appliance.Controls.Add(this.label2);
            this.Appliance.Controls.Add(this.label1);
            this.Appliance.Controls.Add(this.cboAppliance);
            this.Appliance.Controls.Add(this.cboApplianceType);
            this.Appliance.Location = new System.Drawing.Point(13, 13);
            this.Appliance.Margin = new System.Windows.Forms.Padding(4);
            this.Appliance.Name = "Appliance";
            this.Appliance.Padding = new System.Windows.Forms.Padding(4);
            this.Appliance.Size = new System.Drawing.Size(1041, 528);
            this.Appliance.TabIndex = 4;
            this.Appliance.TabStop = false;
            this.Appliance.Text = "Rent";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(568, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "End Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(568, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Start Date";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(672, 239);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(200, 22);
            this.dtpEndDate.TabIndex = 10;
            this.dtpEndDate.ValueChanged += new System.EventHandler(this.dtpEndDate_ValueChanged);
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(672, 142);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 22);
            this.dtpStartDate.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Price";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(215, 239);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(200, 22);
            this.txtPrice.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(568, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Brand";
            // 
            // cboBrand
            // 
            this.cboBrand.DataSource = this.brandBindingSource;
            this.cboBrand.DisplayMember = "name";
            this.cboBrand.FormattingEnabled = true;
            this.cboBrand.Location = new System.Drawing.Point(672, 42);
            this.cboBrand.Name = "cboBrand";
            this.cboBrand.Size = new System.Drawing.Size(200, 24);
            this.cboBrand.TabIndex = 5;
            this.cboBrand.SelectedIndexChanged += new System.EventHandler(this.cboBrand_SelectedIndexChanged);
            // 
            // brandBindingSource
            // 
            this.brandBindingSource.DataMember = "brand";
            this.brandBindingSource.DataSource = this.hARSDBDataSet;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(772, 408);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 28);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // appliance_typeTableAdapter
            // 
            this.appliance_typeTableAdapter.ClearBeforeFill = true;
            // 
            // appliancesBindingSource1
            // 
            this.appliancesBindingSource1.DataMember = "appliances";
            this.appliancesBindingSource1.DataSource = this.hARSDBDataSet;
            // 
            // appliancesTableAdapter
            // 
            this.appliancesTableAdapter.ClearBeforeFill = true;
            // 
            // brandTableAdapter
            // 
            this.brandTableAdapter.ClearBeforeFill = true;
            // 
            // registerTableAdapter1
            // 
            this.registerTableAdapter1.ClearBeforeFill = true;
            // 
            // Rent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.Appliance);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Rent";
            this.Text = "Rent";
            this.Load += new System.EventHandler(this.Rent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.appliancesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hARSDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appliancetypeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appliancetypeBindingSource)).EndInit();
            this.Appliance.ResumeLayout(false);
            this.Appliance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brandBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appliancesBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboAppliance;
        private System.Windows.Forms.ComboBox cboApplianceType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox Appliance;
        private System.Windows.Forms.Button btnSubmit;
        private HARSDBDataSet hARSDBDataSet;
        private System.Windows.Forms.BindingSource appliancetypeBindingSource;
        private System.Windows.Forms.BindingSource appliancesBindingSource;
        private System.Windows.Forms.BindingSource appliancetypeBindingSource1;
        private HARSDBDataSetTableAdapters.appliance_typeTableAdapter appliance_typeTableAdapter;
        private System.Windows.Forms.BindingSource appliancesBindingSource1;
        private HARSDBDataSetTableAdapters.appliancesTableAdapter appliancesTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboBrand;
        private System.Windows.Forms.BindingSource brandBindingSource;
        private HARSDBDataSetTableAdapters.brandTableAdapter brandTableAdapter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private HARSDBDataSetTableAdapters.registerTableAdapter registerTableAdapter1;
    }
}