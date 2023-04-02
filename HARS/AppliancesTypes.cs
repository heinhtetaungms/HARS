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
    public partial class AppliancesTypes : Form
    {
        private DataAccess Da { get; set; }

        public AppliancesTypes()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }

        private void btnSave_Click(object sender, EventArgs e) //" + this.txtUserName.Text + "
        {
         string sql = "insert into appliance_type (name, description) values ('" + this.txtName.Text+ "', '"+this.txtDescription.Text+ "')";
            try
            {
                if (!string.IsNullOrEmpty(this.txtName.Text))
                {
                    int count = this.Da.ExecuteDML(sql);
                    if (count == 1)
                    {
                        MessageBox.Show("Appliance Type successfully saved.");
                        this.Visible = false;
                    
                    }
                    else
                    {
                        MessageBox.Show("Appliance Type Registeration Failed.");
                        this.txtName.Text = "";
                        this.txtDescription.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Appliance Type Name must not be empty.");
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

      
    }
}
