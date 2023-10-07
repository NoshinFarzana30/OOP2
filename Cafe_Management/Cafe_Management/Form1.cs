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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuest_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GuestLogin gl = new GuestLogin();
            gl.Show();
            this.Hide();
            

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Noshin" && txtPassword.Text == "pass")
            {
                Dashboard ds = new Dashboard("Admin");
                ds.Show();
                this.Hide();

            }
            
            else
            {
                MessageBox.Show("Wrong Credentials!!!\nTry again.");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to exit the application?", "Exit Window", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();

            txtUsername.Focus();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            GuestRegistration gr = new GuestRegistration();
            gr.Show();
            this.Hide();
        }
    }
}
