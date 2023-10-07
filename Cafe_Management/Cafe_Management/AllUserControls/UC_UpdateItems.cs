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
    public partial class UC_UpdateItems : UserControl
    {
        function fn = new function();
        String query;
        public UC_UpdateItems()
        {
            InitializeComponent();
        }

        private void UC_UpdateItems_Load(object sender, EventArgs e)
        {
           
            loadData();
            
        }

        public void loadData()//fetch the items from database and show in gridview
        {

            query = "select id as 'Item ID', name as 'Name', category as 'Category', price as 'Unit Price' from items";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];

        }

        private void txtSearchItem_TextChanged(object sender, EventArgs e)
        {
            query = "select * from items where name like '%"+txtSearchItem.Text+"%' ";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];

          
            
        }

        
        int id;
       
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                String category = guna2DataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                String name = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                int price = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());

                txtCategory.Text = category;
                txtName.Text = name;
                txtPrice.Text = price.ToString();
            }
            catch
            {
                MessageBox.Show("Please select a row to update","Error", MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                query = "update items set name = '" + txtName.Text + "', category = '" + txtCategory.Text + "', price = " + txtPrice.Text + " where id = " + id + " ";
                fn.setData(query);
                loadData();
                

                txtName.Clear();
                txtCategory.Clear();
                txtPrice.Clear();

                MessageBox.Show("Updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Please fill all the required fields with valid input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
