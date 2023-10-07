using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using DGVPrinterHelper;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Cafe_Management.AllUserControls
{
    public partial class UC_PlaceOrder : UserControl
    {
        function fn = new function();
        String query;

        public UC_PlaceOrder()
        {
            InitializeComponent();
        }

       


        private void comboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            String category = comboCategory.Text;
            query = "select name from items where category = '"+category+"' ";
            showItemList(query);

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            
            String category = comboCategory.Text;
            query = "select name from items where category = '" + category + "' and name like '%"+txtSearch.Text+"%' ";
            showItemList(query);

        }

        private void showItemList(String query)
        {
            listBox1.Items.Clear();
            DataSet ds = fn.getData(query);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBox1.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtQuantityUpDown.ResetText();
            txtTotal.Clear();//after confirming order

            String text = listBox1.GetItemText(listBox1.SelectedItem);
            txtItemName.Text = text;
            query = "select price from items where name = '"+text+"' ";
            DataSet ds = fn.getData(query);

            try
            {
                txtPrice.Text = ds.Tables[0].Rows[0][0].ToString();
            }
            catch 
            {
                
            }
            

        }

        private void txtQuantityUpDown_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                Int64 quan = Int64.Parse(txtQuantityUpDown.Value.ToString());
                Int64 price = Int64.Parse(txtPrice.Text);
                if (quan <= 100)
                {
                    
                   
                    txtTotal.Text = (quan * price).ToString();


                }
                else
                {
                    MessageBox.Show("Maximum Quantity is 100", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch
            {
                MessageBox.Show("Please choose the item first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

       


        int amount;
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                amount = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
            }
            catch
            {
                MessageBox.Show("Please select items first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                guna2DataGridView1.Rows.RemoveAt(this.guna2DataGridView1.SelectedRows[0].Index);
            }
            catch
            {
                MessageBox.Show("Please select a row to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            total -= amount; // amount decrease after removing
            labelTotalAmount.Text = "TK. " + total;
            

        }


        

        private void btnPrint_Click(object sender, EventArgs e)
        {
            
            

        }

        protected int n, total = 0;

        private void btnConfirmOrder_Click(object sender, EventArgs e)
        {

            try

            {
                if (guna2DataGridView1.Rows.Count - 1 == 0)
                {
                    MessageBox.Show("Please select items to confirm order", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string customer_name = txtYourName.Text;
                    string address = txtYourAddress.Text;
                    string order_id = Guid.NewGuid().ToString();  //generates unique id
                    string cart_query = $"insert into cart(order_id,customer_name,address) values" + $"('{order_id}','{customer_name}', '{address}')";
                    fn.setData(cart_query);



                    for (int rows = 0; rows < guna2DataGridView1.Rows.Count - 1; rows++)
                    {

                        string item_name = guna2DataGridView1.Rows[rows].Cells[0].Value?.ToString();
                        string unit_price = guna2DataGridView1.Rows[rows].Cells[1].Value?.ToString();
                        string quantity = guna2DataGridView1.Rows[rows].Cells[2].Value?.ToString();
                        string price = guna2DataGridView1.Rows[rows].Cells[3].Value?.ToString();



                        query = $"insert into vieworder(customer_name,address,item_name,unit_price,quantity,total_price,order_id) values" + $"('{customer_name}', '{address}' ,'{item_name}', {unit_price} , {quantity},  {price},'{order_id}')";
                        fn.setData(query);
                        





                    }
                    MessageBox.Show("Data Processed Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  
                    



                }

            }
            catch (Exception error)
            {
                MessageBox.Show("Please select items to confirm order", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            total = 0; // amount decrease after removing
            guna2DataGridView1.Rows.Clear();
            labelTotalAmount.Text = "TK. " + total;
            clearAll();



            /* try
             {
                 string customer_name = txtYourName.Text;
                 string address = txtYourAddress.Text;
                 string order_id = Guid.NewGuid().ToString();  //generates unique id
                 string cart_query = $"insert into cart(order_id,customer_name,address) values" +$"('{order_id}','{customer_name}', '{address}')";
                 fn.setData(cart_query);

                 for (int rows = 0; rows < guna2DataGridView1.Rows.Count-1; rows++)
                 {


                     string item_name = guna2DataGridView1.Rows[rows].Cells[0].Value?.ToString();
                     string unit_price = guna2DataGridView1.Rows[rows].Cells[1].Value?.ToString();
                     string quantity = guna2DataGridView1.Rows[rows].Cells[2].Value?.ToString();
                     string price = guna2DataGridView1.Rows[rows].Cells[3].Value?.ToString();



                     query = $"insert into vieworder(customer_name,address,item_name,unit_price,quantity,total_price,order_id) values" + $"('{customer_name}', '{address}' ,'{item_name}', {unit_price} , {quantity},  {price},'{order_id}')";
                     fn.setData(query);



                 }
                 MessageBox.Show("Data Processed Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

             }
             catch(Exception error)
             {
                 MessageBox.Show("Please select items to confirm order", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
             */




        }

        public void clearAll()
        {

            txtYourName.Clear();
            txtYourAddress.Clear();
            txtItemName.Clear();
            txtPrice.Clear();
            txtTotal.Clear();
           
            
          



        }
        private void btnAddtoCart_Click(object sender, EventArgs e)
        {
            if(txtTotal.Text != "0" && txtTotal.Text != "")
            {
                n = guna2DataGridView1.Rows.Add();
                guna2DataGridView1.Rows[n].Cells[0].Value = txtItemName.Text;
                guna2DataGridView1.Rows[n].Cells[1].Value = txtPrice.Text;
                guna2DataGridView1.Rows[n].Cells[2].Value = txtQuantityUpDown.Value;
                guna2DataGridView1.Rows[n].Cells[3].Value = txtTotal.Text;

                
                

                total += int.Parse(txtTotal.Text);
                labelTotalAmount.Text = "TK. " + total;
            }

            else
            {
                MessageBox.Show("Minimum Quantity needs to be 1", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }


    }
}
