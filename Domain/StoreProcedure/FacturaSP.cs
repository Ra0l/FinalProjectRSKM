using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.StoreProcedure
{
   public  class FacturaSP
    {
        public int FacturaID { get; set; }

        public string Number { get; set; }

        public DateTime CreateAt { get; set; }

        public string Vendedor { get; set; }

        public string Cliente { get; set; }

        public double SubTotal { get; set; }

        public int Discount { get; set; }

        public double Total { get; set; }

        public bool Payed { get; set; }

    }
}
