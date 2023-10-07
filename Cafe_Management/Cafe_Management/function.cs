using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Management
{
    class function
    {
        protected SqlConnection getConnection()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = LAPTOP-CA6VV7F2\\SQLEXPRESS;database = restro; integrated security = True ";
            return con;
        }

        public DataSet getData(String query) //fetch the data from database
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            SqlDataAdapter da = new SqlDataAdapter(cmd); // to store data
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;

        }

        public void setData(String query) //insert the data into database
        {
            
                SqlConnection con = getConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                con.Close();
            
                
            
            

        }
    }
}
