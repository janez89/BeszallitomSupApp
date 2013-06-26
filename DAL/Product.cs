using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Product
    {
        public string _id { get; set; }
        public string Name { get; set; }
        public float Size { get; set; }
        public string Item_no { get; set; }
        public string Barcode { get; set; }
        public float Price { get; set; }
        public string Unit { get; set; }
        public int Vat { get; set; }
        public float Min_order { get; set; }
        public string Sup { get; set;  }
        public string Supplier { get; set;  }
        public string Img { get; set; }
        public bool Isaction { get; set; }
        public string Note { get; set; }
        public bool Status { get; set; }
    }
}
