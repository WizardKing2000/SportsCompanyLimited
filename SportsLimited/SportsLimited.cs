using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsLimited
{
    internal class Product 
    {
        private string Category;
        private string TypeOfItem;
        private string Brand;
        private  string size;
        private int Quantity;
        private string Cost; 

        public string category 
        {
            get { return this.Category; }
            set { this.Category = value; }
        }

        public string typeOfItem
        {
            get { return this.TypeOfItem; }
            set { this.TypeOfItem = value; }
        }
        public string brand 
        {
            get { return this.Brand; }
            set { this.Brand = value; }
        }

        public string Size
        {
            get { return this.size; }
            set { this.size = value; }
        }
        public string quantity 
        {
            get { return this.Parseint(Quantity); }
            set { this.size = value; }
        }

        private string Parseint(int quantity)
        {
            throw new NotImplementedException();
        }

        public string cost
        {
            get { return this.Cost; }
            set { this.Cost = value; }
        }

    }
}
