using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HARS
{
    public partial class Dashboard : Form
    {
        String role;
        public Dashboard()
        {
            InitializeComponent();
        }
        public Dashboard(String name, String role)
        {
            InitializeComponent();
            this.lblUsername.Text = name;
            this.role = role;
        }


        private void menuApplianceType_Click(object sender, EventArgs e)
        {
            AppliancesTypes appliancesTypes = new AppliancesTypes();
            appliancesTypes.Visible = true;
        
        }

        private void menuAppliance_Click(object sender, EventArgs e)
        {
            Appliances appliances = new Appliances();
            appliances.Visible = true;

        }

        private void menuBrand_Click(object sender, EventArgs e)
        {
            Brand brand = new Brand();
            brand.Visible = true;
        }

        private void menuApplianceList_Click(object sender, EventArgs e)
        {
            ApplianceList applianceList = new ApplianceList();
            applianceList.Visible = true;
        }

        private void menuRent_Click(object sender, EventArgs e)
        {
            Rent rent = new Rent(this.lblUsername.Text);
            rent.Visible = true;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            if(this.role.Equals("user"))
            {
                menuAppliance.Visible = false;
                menuApplianceType.Visible = false;
                menuBrand.Visible = false;
            }
        }

        private void btnLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            login.Visible = true;
            this.Visible = false;
        }

        private void menuRentList_Click(object sender, EventArgs e)
        {
            RentList rentList = new RentList(role);
            rentList.Visible = true;
        }
    }
}
