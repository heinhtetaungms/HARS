
namespace HARS
{
    partial class Appliances
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtEnergy = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtModels = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDimentions = new System.Windows.Forms.TextBox();
            this.cboApplianceType = new System.Windows.Forms.ComboBox();
            this.appliancetypeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hARSDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hARSDBDataSet = new HARS.HARSDBDataSet();
            this.appliancetypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboBrands = new System.Windows.Forms.ComboBox();
            this.brandBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hARSDBDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.txtColour = new System.Windows.Forms.TextBox();
            this.appliance_typeTableAdapter = new HARS.HARSDBDataSetTableAdapters.appliance_typeTableAdapter();
            this.brandBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.brandTableAdapter = new HARS.HARSDBDataSetTableAdapters.brandTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.appliancetypeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hARSDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hARSDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appliancetypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hARSDBDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 332);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Energy Consunption";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 294);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Colours";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 249);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dimensions";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 202);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Models";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 164);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 122);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Brands";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 78);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Appliances Types";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(51, 38);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Name";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(491, 434);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 28);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(283, 434);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 28);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtEnergy
            // 
            this.txtEnergy.Location = new System.Drawing.Point(355, 332);
            this.txtEnergy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEnergy.Name = "txtEnergy";
            this.txtEnergy.Size = new System.Drawing.Size(160, 22);
            this.txtEnergy.TabIndex = 10;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(355, 160);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(160, 22);
            this.txtPrice.TabIndex = 12;
            // 
            // txtModels
            // 
            this.txtModels.Location = new System.Drawing.Point(355, 198);
            this.txtModels.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtModels.Name = "txtModels";
            this.txtModels.Size = new System.Drawing.Size(160, 22);
            this.txtModels.TabIndex = 13;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(355, 34);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(160, 22);
            this.txtName.TabIndex = 14;
            // 
            // txtDimentions
            // 
            this.txtDimentions.Location = new System.Drawing.Point(355, 245);
            this.txtDimentions.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDimentions.Name = "txtDimentions";
            this.txtDimentions.Size = new System.Drawing.Size(160, 22);
            this.txtDimentions.TabIndex = 15;
            // 
            // cboApplianceType
            // 
            this.cboApplianceType.DataSource = this.appliancetypeBindingSource1;
            this.cboApplianceType.DisplayMember = "name";
            this.cboApplianceType.FormattingEnabled = true;
            this.cboApplianceType.Location = new System.Drawing.Point(355, 74);
            this.cboApplianceType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboApplianceType.Name = "cboApplianceType";
            this.cboApplianceType.Size = new System.Drawing.Size(160, 24);
            this.cboApplianceType.TabIndex = 16;
            // 
            // appliancetypeBindingSource1
            // 
            this.appliancetypeBindingSource1.DataMember = "appliance_type";
            this.appliancetypeBindingSource1.DataSource = this.hARSDBDataSetBindingSource;
            // 
            // hARSDBDataSetBindingSource
            // 
            this.hARSDBDataSetBindingSource.DataSource = this.hARSDBDataSet;
            this.hARSDBDataSetBindingSource.Position = 0;
            // 
            // hARSDBDataSet
            // 
            this.hARSDBDataSet.DataSetName = "HARSDBDataSet";
            this.hARSDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // appliancetypeBindingSource
            // 
            this.appliancetypeBindingSource.DataMember = "appliance_type";
            // 
            // cboBrands
            // 
            this.cboBrands.DataSource = this.brandBindingSource1;
            this.cboBrands.DisplayMember = "name";
            this.cboBrands.FormattingEnabled = true;
            this.cboBrands.Location = new System.Drawing.Point(355, 118);
            this.cboBrands.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboBrands.Name = "cboBrands";
            this.cboBrands.Size = new System.Drawing.Size(160, 24);
            this.cboBrands.TabIndex = 17;
            // 
            // brandBindingSource1
            // 
            this.brandBindingSource1.DataMember = "brand";
            this.brandBindingSource1.DataSource = this.hARSDBDataSetBindingSource1;
            // 
            // hARSDBDataSetBindingSource1
            // 
            this.hARSDBDataSetBindingSource1.DataSource = this.hARSDBDataSet;
            this.hARSDBDataSetBindingSource1.Position = 0;
            // 
            // txtColour
            // 
            this.txtColour.Location = new System.Drawing.Point(355, 290);
            this.txtColour.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtColour.Name = "txtColour";
            this.txtColour.Size = new System.Drawing.Size(160, 22);
            this.txtColour.TabIndex = 11;
            // 
            // appliance_typeTableAdapter
            // 
            this.appliance_typeTableAdapter.ClearBeforeFill = true;
            // 
            // brandBindingSource
            // 
            this.brandBindingSource.DataMember = "brand";
            this.brandBindingSource.DataSource = this.hARSDBDataSetBindingSource1;
            // 
            // brandTableAdapter
            // 
            this.brandTableAdapter.ClearBeforeFill = true;
            // 
            // Appliances
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(707, 523);
            this.Controls.Add(this.cboBrands);
            this.Controls.Add(this.cboApplianceType);
            this.Controls.Add(this.txtDimentions);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtModels);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtColour);
            this.Controls.Add(this.txtEnergy);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.DarkBlue;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Appliances";
            this.Text = "Appliances";
            this.Load += new System.EventHandler(this.Appliances_Load);
            ((System.ComponentModel.ISupportInitialize)(this.appliancetypeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hARSDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hARSDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appliancetypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hARSDBDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandBindingSource)).EndInit();
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
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtEnergy;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtModels;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDimentions;
        private System.Windows.Forms.ComboBox cboApplianceType;
        private System.Windows.Forms.ComboBox cboBrands;
        private System.Windows.Forms.TextBox txtColour;
        private System.Windows.Forms.BindingSource appliancetypeBindingSource;
        private System.Windows.Forms.BindingSource hARSDBDataSetBindingSource;
        private HARSDBDataSet hARSDBDataSet;
        private System.Windows.Forms.BindingSource appliancetypeBindingSource1;
        private HARSDBDataSetTableAdapters.appliance_typeTableAdapter appliance_typeTableAdapter;
        private System.Windows.Forms.BindingSource hARSDBDataSetBindingSource1;
        private System.Windows.Forms.BindingSource brandBindingSource;
        private HARSDBDataSetTableAdapters.brandTableAdapter brandTableAdapter;
        private System.Windows.Forms.BindingSource brandBindingSource1;
    }
}