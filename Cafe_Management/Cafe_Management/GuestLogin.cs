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
    public partial class GuestLogin : Form
    {
        function fn = new function();
        
        
        public GuestLogin()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("data source = LAPTOP-CA6VV7F2\\SQLEXPRESS;database = restro; integrated security = True ");


        private void btnClear_Click(object sender, EventArgs e)
        {
            txtGuestName.Clear();
            txtGuestPassword.Clear();

            txtGuestName.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String guestname, guestpassword;
            guestname = txtGuestName.Text;
            guestpassword = txtGuestPassword.Text;
            
            try
            {

                String query = "select * from registration where name = '" + txtGuestName.Text + "' COLLATE Latin1_General_CS_AS and  password ='" + txtGuestPassword.Text + "' COLLATE Latin1_General_CS_AS";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);
                

                if (dtable.Rows.Count > 0)
                {
                    guestname = txtGuestName.Text;
                    guestpassword = txtGuestPassword.Text;
                    
                    Dashboard ds = new Dashboard("Guest");
                    ds.Show();
                    this.Hide();


                }
                else
                {
                    MessageBox.Show("Invalid login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtGuestName.Clear();
                    txtGuestPassword.Clear();
                    

                }

            }
            catch
            {
                MessageBox.Show("Error");

            }
            finally
            {

                conn.Close();

            }
            
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
            Form1 fm = new Form1();
            this.Hide();
            fm.Show();
            
        }
    }
}
