using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Invoice_detail
    {
        public int Detail_Id { get; set; } 
        public int Invoice_Id { get; set; }
        public int Product_Id { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public double Subtotal { get; set; }

    }
}
