using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SneakersShops.Models
{
    public class ExistShoes
    {
        public int Id { get; set; }
        public string Company { get; set; }
        public string Gender { get; set; }
        public bool HasHeels { get; set; }
        public bool AtStock { get; set; }
        public int Size { get; set; }
        public int Price { get; set; }
    }
}