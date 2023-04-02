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
    public partial class RentList : Form
    {
        String userName;
        String role;

        private DataAccess da { get; set; }
        public RentList()
        {
            InitializeComponent();
        }

        public RentList(String role)
        {
            InitializeComponent();
            this.da = new DataAccess();
            this.userName = LoadUserNameByRole(role);
        }

       

        public String LoadUserNameByRole(String role)
        {
            string sql = $@"select * from register where role = '{@role}' ";
            String username="";
            this.role = role;
            try
            {

                DataTable dt = this.da.ExecuteQueryTable(sql);
                if (dt.Rows.Count == 1)
                {
                    username = dt.Rows[0]["username"].ToString();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }
            return username;
        }

        public void loadRentlist(String userName)
        {
            String sql;
            if (role.Equals("admin"))
            {
                 sql = $@"select * from rent";
            }
            else
            {
                 sql = $@"select * from rent where rentee = '{@userName}' ";
            }
            
            DataTable dt = this.da.ExecuteQueryTable(sql);

            this.rentListView.DataSource = dt;
        }

        private void RentList_Load(object sender, EventArgs e)
        {
            loadRentlist(userName);
        }
    }
}
