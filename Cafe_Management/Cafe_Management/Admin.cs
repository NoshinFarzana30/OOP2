using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Management
{
    public class Admin
    {
        private string username;
        private string password;
        private string address;
        private string designation;
        private int salary;
        private int contact_no;

        public Admin()
        {

        }

        public string Username
        {
            get
            {
                return username;
            }

            set
            {
                this.username = value;

            }


        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                this.password = value;

            }


        }

        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                this.address = value;

            }


        }

        public string Designation
        {
            get
            {
                return designation;
            }

            set
            {
                this.designation = value;

            }


        }

        public int Salary
        {
            get
            {
                return salary;
            }

            set
            {
                this.salary = value;

            }


        }

        public int ContactNo
        {
            get
            {
                return contact_no;
            }

            set
            {
                this.contact_no = value;

            }


        }

    }
}
