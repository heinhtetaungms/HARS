
namespace HARS
{
    partial class Dashboard
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuAppliance = new System.Windows.Forms.ToolStripMenuItem();
            this.menuApplianceList = new System.Windows.Forms.ToolStripMenuItem();
            this.menuApplianceType = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBrand = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRent = new System.Windows.Forms.ToolStripMenuItem();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.LinkLabel();
            this.menuRentList = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gray;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAppliance,
            this.menuApplianceList,
            this.menuApplianceType,
            this.menuBrand,
            this.menuRent,
            this.menuRentList});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(927, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuAppliance
            // 
            this.menuAppliance.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuAppliance.Name = "menuAppliance";
            this.menuAppliance.Size = new System.Drawing.Size(96, 24);
            this.menuAppliance.Text = "Appliances";
            this.menuAppliance.Click += new System.EventHandler(this.menuAppliance_Click);
            // 
            // menuApplianceList
            // 
            this.menuApplianceList.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuApplianceList.Name = "menuApplianceList";
            this.menuApplianceList.Size = new System.Drawing.Size(116, 24);
            this.menuApplianceList.Text = "Appliance List";
            this.menuApplianceList.Click += new System.EventHandler(this.menuApplianceList_Click);
            // 
            // menuApplianceType
            // 
            this.menuApplianceType.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuApplianceType.Name = "menuApplianceType";
            this.menuApplianceType.Size = new System.Drawing.Size(125, 24);
            this.menuApplianceType.Text = "Appliance Type";
            this.menuApplianceType.Click += new System.EventHandler(this.menuApplianceType_Click);
            // 
            // menuBrand
            // 
            this.menuBrand.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuBrand.Name = "menuBrand";
            this.menuBrand.Size = new System.Drawing.Size(62, 24);
            this.menuBrand.Text = "Brand";
            this.menuBrand.Click += new System.EventHandler(this.menuBrand_Click);
            // 
            // menuRent
            // 
            this.menuRent.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuRent.Name = "menuRent";
            this.menuRent.Size = new System.Drawing.Size(53, 24);
            this.menuRent.Text = "Rent";
            this.menuRent.Click += new System.EventHandler(this.menuRent_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(791, 9);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(71, 17);
            this.lblUsername.TabIndex = 6;
            this.lblUsername.Text = "username";
            // 
            // btnLogout
            // 
            this.btnLogout.AutoSize = true;
            this.btnLogout.Location = new System.Drawing.Point(868, 9);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(52, 17);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.TabStop = true;
            this.btnLogout.Text = "Logout";
            this.btnLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnLogout_LinkClicked);
            // 
            // menuRentList
            // 
            this.menuRentList.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuRentList.Name = "menuRentList";
            this.menuRentList.Size = new System.Drawing.Size(79, 24);
            this.menuRentList.Text = "Rent List";
            this.menuRentList.Click += new System.EventHandler(this.menuRentList_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(927, 452);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuAppliance;
        private System.Windows.Forms.ToolStripMenuItem menuApplianceType;
        private System.Windows.Forms.ToolStripMenuItem menuBrand;
        private System.Windows.Forms.ToolStripMenuItem menuApplianceList;
        private System.Windows.Forms.ToolStripMenuItem menuRent;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.LinkLabel btnLogout;
        private System.Windows.Forms.ToolStripMenuItem menuRentList;
    }
}