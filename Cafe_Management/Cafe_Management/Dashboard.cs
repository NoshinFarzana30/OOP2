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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        public Dashboard(String user)
        {
            InitializeComponent();

            if(user == "Guest")
            {
                btnAddItems.Hide();
                btnUpdate.Hide();
                btnRemove.Hide();
                btnGuestInformation.Hide();
                btnRemoveGuest.Hide();
                btnViewOrders.Hide();
                
            }
            else if(user == "Admin")
            {
                btnAddItems.Show();
                btnUpdate.Show();
                btnRemove.Show();
                btnGuestInformation.Show();
                btnRemoveGuest.Show();
                btnViewOrders.Show();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 fm = new Form1();
            this.Hide();
            fm.Show();

        }

        private void btnAddItems_Click(object sender, EventArgs e)
        {
            uC_AddItems1.Visible = true;
            uC_AddItems1.BringToFront();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            uC_AddItems1.Visible = false;
            uC_PlaceOrder1.Visible = false;
            uC_UpdateItems1.Visible = false;
            uC_RemoveItem1.Visible = false;
            uC_GuestInformation1.Visible = false;
            uC_RemoveGuest1.Visible = false;
            uC_ViewOrders1.Visible = false;
            
            
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            uC_Welcome1.SendToBack();
            guna2Transition1.ShowSync(uC_PlaceOrder1);
            uC_PlaceOrder1.Visible = true;
            uC_PlaceOrder1.BringToFront();
           
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            uC_UpdateItems1.Visible = true;
            uC_UpdateItems1.BringToFront();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            uC_RemoveItem1.Visible = true;
            uC_RemoveItem1.BringToFront();
        }

        private void btnGuestInformation_Click(object sender, EventArgs e)
        {
            uC_GuestInformation1.Visible = true;
            uC_GuestInformation1.BringToFront();
        }

        private void btnRemoveGuest_Click(object sender, EventArgs e)
        {
            uC_RemoveGuest1.Visible = true;
            uC_RemoveGuest1.BringToFront();
        }

        private void btnViewOrders_Click(object sender, EventArgs e)
        {
            uC_ViewOrders1.Visible = true;
            uC_ViewOrders1.BringToFront();
        }
    }
}
