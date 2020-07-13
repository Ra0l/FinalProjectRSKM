using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Request
{
    public class Factura_Request
    {
        public int FacturaID { get; set; }
        public string Number { get; set; }
        public bool Payed { get; set; }
        public int Discount { get; set; }
        public string Reason { get; set; }
        public int ClienteID { get; set; }
        public int VendedorID { get; set; }

    }
}
