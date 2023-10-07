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
    public partial class UC_ViewOrders : UserControl
    {
        function fn = new function();
        String query;
        public UC_ViewOrders()
        {
            InitializeComponent();
        }

        private void UC_ViewOrders_Load(object sender, EventArgs e)
        {
            loadData();
        }

        public void loadData()
        {

            query = "select * from cart";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
            guna2DataGridView1.Columns[0].Visible = false;

        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            DataGridView dgv = sender as DataGridView;
            if (dgv == null)
                return;
            if (dgv.CurrentRow.Selected)
            {

                Order_Details od = new Order_Details(this, dgv.CurrentRow.Cells[0].Value?.ToString()); 
                od.Show();
                this.Hide();
                
            }
        }
    }
}
