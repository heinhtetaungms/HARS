
namespace HARS
{
    partial class RentList
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rentListView = new System.Windows.Forms.DataGridView();
            this.rentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hARSDBDataSet = new HARS.HARSDBDataSet();
            this.rentTableAdapter = new HARS.HARSDBDataSetTableAdapters.rentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.rentListView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hARSDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1067, 552);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rent List";
            // 
            // rentListView
            // 
            this.rentListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rentListView.Location = new System.Drawing.Point(0, 0);
            this.rentListView.Name = "rentListView";
            this.rentListView.RowHeadersWidth = 51;
            this.rentListView.RowTemplate.Height = 24;
            this.rentListView.Size = new System.Drawing.Size(1579, 552);
            this.rentListView.TabIndex = 1;
            // 
            // rentBindingSource
            // 
            this.rentBindingSource.DataMember = "rent";
            this.rentBindingSource.DataSource = this.hARSDBDataSet;
            // 
            // hARSDBDataSet
            // 
            this.hARSDBDataSet.DataSetName = "HARSDBDataSet";
            this.hARSDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rentTableAdapter
            // 
            this.rentTableAdapter.ClearBeforeFill = true;
            // 
            // RentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1393, 554);
            this.Controls.Add(this.rentListView);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RentList";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.RentList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rentListView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hARSDBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView rentListView;
        private HARSDBDataSet hARSDBDataSet;
        private System.Windows.Forms.BindingSource rentBindingSource;
        private HARSDBDataSetTableAdapters.rentTableAdapter rentTableAdapter;
    }
}