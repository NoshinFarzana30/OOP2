using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Cafe_Management
{
    public partial class GuestRegistration : Form
    {
        function fn = new function();
        String query;
        public GuestRegistration()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("data source = LAPTOP-CA6VV7F2\\SQLEXPRESS;database = restro; integrated security = True ");

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            

            try
            {

                query = "insert into registration(name,password,contact_no,address) values('" + txtName.Text + "', '" + txtPassword.Text + "',  " + txtContact.Text + ",'" + txtAddress.Text + "')";
                fn.setData(query);
                clearAll();
                MessageBox.Show("Registration Confirmed", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);



            }
            catch
            {
                MessageBox.Show("Please give a valid input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }



        }

        public void clearAll()
        {
            
            txtName.Clear();
            txtPassword.Clear();
            txtContact.Clear();
            txtAddress.Clear();


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to exit the application?", "Exit Window", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            


        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            this.Hide();
            fm.Show();
        }

        private void btnGuestLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GuestLogin gl = new GuestLogin();
            this.Hide();
            gl.Show();
        }
    }
}
