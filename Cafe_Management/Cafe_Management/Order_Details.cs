using Cafe_Management.AllUserControls;
using DGVPrinterHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Management
{
    public partial class Order_Details : Form
    {
        private UC_ViewOrders vo;
       
        public Order_Details(UC_ViewOrders vo, string order_id)
        {
            InitializeComponent();
            this.vo = vo;
        
            LoadData(order_id);
        }

        public void LoadData(string order_id)
        {
            function fn = new function();

            string query = "SELECT vieworder.item_name as 'Item Name', vieworder.unit_price as 'Unit Price', vieworder.quantity as 'Quantity', vieworder.total_price as 'Price', "
                + "cart.order_id, cart.customer_name, cart.address "
                + "FROM vieworder "
                + "INNER JOIN cart "
                + "ON cart.order_id = vieworder.order_id "
                + $"WHERE cart.order_id = '{order_id}'";

            DataSet orderDetails = fn.getData(query);
            guna2DataGridView1.DataSource = orderDetails.Tables[0];
            guna2DataGridView1.Columns[4].Visible = false;
            guna2DataGridView1.Columns[5].Visible = false;
            guna2DataGridView1.Columns[6].Visible = false;

            txtYourName.Text = guna2DataGridView1.Rows[0].Cells[5].Value?.ToString();
            txtYourAddress.Text = guna2DataGridView1.Rows[0].Cells[6].Value?.ToString();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            vo.Show();
            this.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            double totalAmount = 0;
            for (int i = 0; i < guna2DataGridView1.Rows.Count - 1; i++)
            {
                string value = guna2DataGridView1.Rows[i].Cells[3].Value?.ToString();
                totalAmount += double.Parse(value);
            }

            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Crimson Cafe";
            printer.SubTitle = "House No: 67,Road No: 12 \r\n Banani,Dhaka \r\n Contact No: 01734567898 \r\n\r\n Customer Bill \r\n\r\n Customer Name: " + txtYourName.Text + " \n Address: " + txtYourAddress.Text;


            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Total Payable Amount: " + totalAmount + "\r\n" + "\r\n" + "Thank You. Come Again!";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(guna2DataGridView1);

            
        }
    }
}
