using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskforAcademy.Models
{
    internal class Product
    {
        public string Name;
        private decimal _price;

        public decimal Price 
        { 
            get { return _price; } 
            set 
            {
                if (value >= 0)
                {
                    _price = value;
                } 
            } 
        } 

        public Product(string name,decimal price)
        {
            Name = name;
            _price = price;
        }
    }
}
