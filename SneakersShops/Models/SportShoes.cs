using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SneakersShops.Models
{
    public class SportShoes
    {

        public string Company;
        public string Model;
        public int Price;
        public int Size;

        public SportShoes(string _company, string _model, int _price, int _size)
        {
            
            this.Company = _company;
            this.Model = _model;
            this.Price = _price;
            this.Size = _size;
        }
        public SportShoes() { }
    }
}