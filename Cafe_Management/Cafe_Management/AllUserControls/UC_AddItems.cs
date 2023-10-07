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
    public partial class UC_AddItems : UserControl
    {
        function fn = new function();
        String query;
        public UC_AddItems()
        {
            InitializeComponent();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            try
            {
                query = "insert into items(name,category,price) values('" + txtItemName.Text + "', '" + txtCategory.Text + "',  " + txtPrice.Text + ")";
                fn.setData(query);
                clearAll(); 
                MessageBox.Show("Data Processed Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Please fill all the required fields with valid input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        public void clearAll() //clear all the textboxes after adding the items
        {
            txtCategory.SelectedIndex = -1;
            txtItemName.Clear();
            txtPrice.Clear();
        }

        private void UC_AddItems_Leave(object sender, EventArgs e) //clear the textboxes after leaving the additems page
        {
            clearAll();

        }
    }
}
