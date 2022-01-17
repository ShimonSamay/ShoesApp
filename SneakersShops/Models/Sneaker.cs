using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SneakersShops.Models
{
    public class Sneaker
    {
        public int Id { get; set; }
        public string Company { get; set; }
        public string Model { get; set; }
        public int Price { get; set; }

        public int Size { get; set; }

        public Sneaker (int _id , string _company , string _model , int _price , int _size)
        {
            this.Id = _id;
            this.Company = _company;
            this.Model = _model;
            this.Price = _price;
            this.Size = _size;
        }
        public Sneaker () { } 
    }
}