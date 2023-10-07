using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Management
{
    public class Order
    {
        private string order_date;
        private int total_bill;

        public Order()
        {

        }

        public string Order_Date
        {
            get
            {
                return order_date;
            }

            set
            {
                this.order_date = value;

            }


        }

        public int Total_Bill
        {
            get
            {
                return total_bill;
            }

            set
            {
                this.total_bill = value;

            }


        }
    }
}
