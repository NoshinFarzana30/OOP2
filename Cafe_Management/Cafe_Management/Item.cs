using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Management
{
    public class Item
    {
        private string name;
        private string category;
        private int price;

        public Item()
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

        public string Category
        {
            get
            {
                return category;
            }

            set
            {
                this.category = value;

            }


        }

        public int Price
        {
            get
            {
                return price;
            }

            set
            {
                this.price = value;

            }


        }

    }
}
