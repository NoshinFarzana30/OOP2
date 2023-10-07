using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Management.AllUserControls
{
    public partial class UC_GuestInformation : UserControl
    {
        function fn = new function();
        String query;
        public UC_GuestInformation()
        {
            InitializeComponent();
        }

        private void UC_GuestInformation_Load(object sender, EventArgs e)
        {
            loadData();
        }

        public void loadData() //fetch the guest info from database and show in gridview
        {

            query = "select name as 'Name',contact_no as 'Contact Number',address as 'Address' from registration";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];

        }

        private void txtSearchGuest_TextChanged(object sender, EventArgs e)
        {
            query = "select name,contact_no,address from registration where name like '%" + txtSearchGuest.Text + "%' ";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }
    }
}
