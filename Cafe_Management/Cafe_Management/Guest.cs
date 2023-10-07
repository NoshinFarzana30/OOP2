using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Management
{
    public class Guest
    {
        private string name;
        private string password;
        private int contact_no;
        private string address;

        public Guest()
        {

        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                this.name = value;

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
    }
}
